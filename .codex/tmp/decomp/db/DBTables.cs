using System;
using SQLite;
using UnityEngine;

namespace db;

public static class DBTables
{
	public static void createOrMigrateTables()
	{
		createTable<WorldLogMessage>();
		createTable<KingdomData>();
	}

	public static void createOrMigrateTable(Type pType)
	{
		SQLiteConnectionWithLock syncConnection = DBManager.getSyncConnection();
		using (syncConnection.Lock())
		{
			if (syncConnection.CreateTable(pType) != CreateTableResult.Migrated)
			{
				TableMapping mapping = syncConnection.GetMapping(pType);
				string query = "SELECT sql FROM sqlite_master WHERE type='table' AND name=?";
				string text = syncConnection.ExecuteScalar<string>(query, new object[1] { mapping.TableName });
				syncConnection.DropTable(mapping);
				text = text[..text.LastIndexOf(')')];
				text = text.Replace(" integer ", " INT ").Trim().Replace("  ", " ")
					.Replace(" ,", ",")
					.Replace(", ", ",")
					.Replace("\"", "");
				text += ",\nauto INT";
				text += ",\nPRIMARY KEY(id, timestamp)";
				text += "\n)";
				syncConnection.Execute(text);
			}
		}
	}

	public static void checkTablesOK(bool pDropTable = false)
	{
		int currentYear = Date.getCurrentYear();
		bool flag = true;
		SQLiteConnectionWithLock syncConnection = DBManager.getSyncConnection();
		using (syncConnection.Lock())
		{
			foreach (HistoryMetaDataAsset item in AssetManager.history_meta_data_library.list)
			{
				if (!flag)
				{
					break;
				}
				foreach (Type value in item.table_types.Values)
				{
					if (checkTableExists(value) && !checkTableOK(value, currentYear))
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				return;
			}
			if (pDropTable)
			{
				Debug.Log("Statistics have future data, dropping...");
				foreach (HistoryMetaDataAsset item2 in AssetManager.history_meta_data_library.list)
				{
					foreach (Type value2 in item2.table_types.Values)
					{
						if (checkTableExists(value2))
						{
							TableMapping mapping = syncConnection.GetMapping(value2);
							syncConnection.DropTable(mapping);
						}
					}
				}
				if (checkTableExists<KingdomData>())
				{
					syncConnection.DropTable<KingdomData>();
				}
				if (checkTableExists<WorldLogMessage>())
				{
					syncConnection.DropTable<WorldLogMessage>();
				}
				return;
			}
			Debug.Log("Statistics have future data, clearing...");
			foreach (HistoryMetaDataAsset item3 in AssetManager.history_meta_data_library.list)
			{
				foreach (Type value3 in item3.table_types.Values)
				{
					if (checkTableExists(value3))
					{
						TableMapping mapping2 = syncConnection.GetMapping(value3);
						syncConnection.DeleteAll(mapping2);
					}
				}
			}
			if (checkTableExists<KingdomData>())
			{
				syncConnection.DeleteAll<KingdomData>();
			}
			if (checkTableExists<WorldLogMessage>())
			{
				syncConnection.DeleteAll<WorldLogMessage>();
			}
		}
	}

	public static bool checkTableExists(Type pType)
	{
		SQLiteConnectionWithLock syncConnection = DBManager.getSyncConnection();
		using (syncConnection.Lock())
		{
			TableMapping mapping = syncConnection.GetMapping(pType);
			string query = "SELECT count(1) FROM sqlite_master WHERE type='table' AND name=?";
			if (syncConnection.ExecuteScalar<int>(query, new object[1] { mapping.TableName }) == 0)
			{
				return false;
			}
			return true;
		}
	}

	public static bool checkTableOK(Type pType, int pTimestamp)
	{
		SQLiteConnectionWithLock syncConnection = DBManager.getSyncConnection();
		using (syncConnection.Lock())
		{
			TableMapping mapping = syncConnection.GetMapping(pType);
			string query = "SELECT count(1) FROM '" + mapping.TableName + "' WHERE timestamp>?";
			if (syncConnection.ExecuteScalar<int>(query, new object[1] { pTimestamp }) == 0)
			{
				return true;
			}
			return false;
		}
	}

	public static bool checkTableExists<T>()
	{
		return checkTableExists(typeof(T));
	}

	public static void createTableIfNotExists<T>()
	{
		if (!checkTableExists<T>())
		{
			createTable<T>();
		}
	}

	public static void createTable<T>()
	{
		SQLiteConnectionWithLock syncConnection = DBManager.getSyncConnection();
		using (syncConnection.Lock())
		{
			syncConnection.CreateTable<T>();
		}
	}

	public static void createOrMigrateTablesLoader(bool pCreating = true)
	{
		string text = (pCreating ? "Creating" : "Migrating");
		if (!pCreating)
		{
			SmoothLoader.add(delegate
			{
				SQLiteConnectionWithLock syncConnection = DBManager.getSyncConnection();
				foreach (HistoryMetaDataAsset item in AssetManager.history_meta_data_library.list)
				{
					DBTriggers.dropTrigger(syncConnection, item);
				}
			}, "Dropping Triggers");
		}
		SmoothLoader.add(delegate
		{
			createOrMigrateTables();
		}, text + " Stats");
		foreach (HistoryMetaDataAsset tHistoryAsset in AssetManager.history_meta_data_library.list)
		{
			SmoothLoader.add(delegate
			{
				foreach (Type value in tHistoryAsset.table_types.Values)
				{
					createOrMigrateTable(value);
				}
			}, text + " Stats (" + tHistoryAsset.table_type.Name + ")");
		}
		SmoothLoader.add(delegate
		{
			SQLiteConnectionWithLock syncConnection = DBManager.getSyncConnection();
			foreach (HistoryMetaDataAsset item2 in AssetManager.history_meta_data_library.list)
			{
				DBTriggers.createTrigger(syncConnection, item2);
			}
		}, text + " Triggers");
	}
}
