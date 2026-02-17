using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using UnityPools;
using db.tables;

namespace db;

public static class DBGetter
{
	public static ListPool<GraphTimeScale> getTimeScales(NanoObject pObject)
	{
		if (Config.disable_db)
		{
			return new ListPool<GraphTimeScale>();
		}
		return getTimeScales(pObject.getID(), pObject.getType());
	}

	public static ListPool<GraphTimeScale> getTimeScales(long pID, string pMetaType)
	{
		SQLiteConnectionWithLock syncConnection = DBManager.getSyncConnection();
		using (syncConnection.Lock())
		{
			HistoryMetaDataAsset historyMetaDataAsset = AssetManager.history_meta_data_library.get(pMetaType);
			using ListPool<string> listPool = new ListPool<string>(AssetManager.graph_time_library.list.Count);
			foreach (GraphTimeAsset item in AssetManager.graph_time_library.list)
			{
				HistoryInterval interval = item.interval;
				TableMapping mapping = syncConnection.GetMapping(historyMetaDataAsset.getTableType(interval));
				listPool.Add($"select \"{item.id}\" as Scale, count() as Count from {mapping.TableName} where id = {pID} GROUP BY id HAVING Count > 0");
			}
			string query = string.Join(" UNION ", listPool);
			using ListPool<(string, int)> listPool2 = ((SQLiteConnection)syncConnection).QueryPool<(string, int)>(query, Array.Empty<object>());
			if (listPool2.Count == 0)
			{
				return new ListPool<GraphTimeScale>();
			}
			using ListPool<GraphTimeScale> listPool3 = new ListPool<GraphTimeScale>(listPool2.Count);
			foreach (ref(string, int) item2 in listPool2)
			{
				(string, int) current2 = item2;
				listPool3.Add(AssetManager.graph_time_library.get(current2.Item1).scale_id);
			}
			ListPool<GraphTimeScale> listPool4 = new ListPool<GraphTimeScale>(listPool3.Count);
			GraphTimeScale graphTimeScale = listPool3.Max();
			for (GraphTimeScale graphTimeScale2 = GraphTimeScale.year_10; graphTimeScale2 <= graphTimeScale; graphTimeScale2++)
			{
				listPool4.Add(graphTimeScale2);
			}
			return listPool4;
		}
	}

	public static ListPool<WorldLogMessage> getWorldLogMessages()
	{
		DBInserter.executeCommands();
		SQLiteConnectionWithLock syncConnection = DBManager.getSyncConnection();
		using (syncConnection.Lock())
		{
			TableMapping mapping = syncConnection.GetMapping<WorldLogMessage>();
			return syncConnection.QueryPool<WorldLogMessage>($"select * from {mapping.TableName} order by timestamp DESC, ROWID DESC LIMIT {2000}", Array.Empty<object>());
		}
	}

	public static bool getData(CategoryData pData, NanoObject pObject, HistoryInterval pInterval, HistoryTable pExtraData)
	{
		return getData(pData, pObject.getID(), pObject.getType(), pInterval, pExtraData);
	}

	public static bool getData(CategoryData pData, long pID, string pMetaType, HistoryInterval pInterval, HistoryTable pExtraData)
	{
		SQLiteConnectionWithLock syncConnection = DBManager.getSyncConnection();
		using (syncConnection.Lock())
		{
			HistoryMetaDataAsset historyMetaDataAsset = AssetManager.history_meta_data_library.get(pMetaType);
			TableMapping mapping = syncConnection.GetMapping(historyMetaDataAsset.getTableType(pInterval));
			ListPool<object> listPool = syncConnection.QueryPool(mapping, "select * from " + mapping.TableName + " where id = ? order by timestamp ASC", pID);
			if (listPool.Count > 0)
			{
				if (((HistoryTable)listPool.Last()).timestamp < pExtraData.timestamp)
				{
					listPool.Add(pExtraData);
				}
			}
			else
			{
				listPool.Add(pExtraData);
			}
			if (pData.db_list != null)
			{
				if (pData.db_list.ValuesEqual(listPool))
				{
					listPool.Dispose();
					return false;
				}
				pData.Clear();
			}
			foreach (ref object item in listPool)
			{
				Dictionary<string, long?> dictionary = parseValues(item, mapping);
				Dictionary<string, long> dictionary2 = UnsafeCollectionPool<Dictionary<string, long>, KeyValuePair<string, long>>.Get();
				foreach (string key in dictionary.Keys)
				{
					long? num = dictionary[key];
					if (!num.HasValue)
					{
						num = pData.Last?.Value[key];
						if (!num.HasValue)
						{
							num = 0L;
						}
					}
					dictionary2.Add(key, num.Value);
				}
				pData.AddLast(dictionary2);
				UnsafeCollectionPool<Dictionary<string, long?>, KeyValuePair<string, long?>>.Release(dictionary);
			}
			pData.db_list = listPool;
			return true;
		}
	}

	public static Dictionary<string, long?> parseValues(object pItem, TableMapping pTableMapping)
	{
		TableMapping.Column[] columns = pTableMapping.Columns;
		Dictionary<string, long?> dictionary = UnsafeCollectionPool<Dictionary<string, long?>, KeyValuePair<string, long?>>.Get();
		TableMapping.Column[] array = columns;
		foreach (TableMapping.Column column in array)
		{
			if (!(column.Name == "id"))
			{
				object value = column.GetValue(pItem);
				if (value == null)
				{
					dictionary.Add(column.Name, null);
					continue;
				}
				long value2 = (long)value;
				dictionary.Add(column.Name, value2);
			}
		}
		return dictionary;
	}
}
