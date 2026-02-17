using System;
using System.IO;
using SQLite;
using UnityEngine;

namespace db;

public class DBManager : MonoBehaviour
{
	private static SQLiteAsyncConnection _dbconn;

	private static string _dbpath;

	private static void resetDataPath()
	{
		_dbpath = Application.persistentDataPath + "/stats.s3db";
	}

	public static bool loadDBFrom(string pPath)
	{
		try
		{
			closeDB();
			if (!File.Exists(pPath))
			{
				return false;
			}
			resetDataPath();
			if (File.Exists(_dbpath))
			{
				File.Delete(_dbpath);
			}
			File.Copy(pPath, _dbpath);
			openDB();
			return true;
		}
		catch (Exception message)
		{
			Debug.Log("[SQLITE] error loading db");
			Debug.LogError(message);
			return false;
		}
	}

	public static void createDB()
	{
		try
		{
			closeDB();
			resetDataPath();
			if (File.Exists(_dbpath))
			{
				File.Delete(_dbpath);
			}
			Debug.Log("[SQLITE] new db " + _dbpath);
			openDB();
		}
		catch (Exception message)
		{
			Debug.Log("[SQLITE] error creating db");
			Debug.Log(message);
		}
	}

	public static void openDB()
	{
		if (Config.disable_db || _dbconn != null)
		{
			return;
		}
		_dbconn = new SQLiteAsyncConnection(_dbpath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.NoMutex);
		Debug.Log("[SQLITE] opening db " + _dbconn.LibVersionNumber);
		_dbconn.Trace = false;
		SQLiteConnectionWithLock connection = _dbconn.GetConnection();
		using (connection.Lock())
		{
			connection.ExecuteScalar<string>("PRAGMA temp_store=MEMORY;", Array.Empty<object>());
			connection.ExecuteScalar<string>("PRAGMA synchronous=OFF;", Array.Empty<object>());
			connection.ExecuteScalar<string>("PRAGMA cache_size=4000;", Array.Empty<object>());
			connection.ExecuteScalar<string>("PRAGMA journal_mode=MEMORY;", Array.Empty<object>());
		}
	}

	public static SQLiteAsyncConnection getAsyncConnection()
	{
		openDB();
		return _dbconn;
	}

	public static SQLiteConnectionWithLock getSyncConnection()
	{
		openDB();
		return _dbconn.GetConnection();
	}

	public static void clearAndClose()
	{
		DBInserter.waitForAsync();
		DBInserter.clearCommands();
		closeDB();
	}

	public static void closeDB()
	{
		if (!Config.disable_db && _dbconn != null)
		{
			Debug.Log("[SQLITE] closing db");
			try
			{
				_dbconn.CloseAsync().WaitAndUnwrapException();
			}
			catch (Exception message)
			{
				Debug.LogError("[SQLITE] error closing db");
				Debug.LogError(message);
			}
			_dbconn = null;
			Debug.Log("[SQLITE] db closed");
		}
	}

	private static void vacuum()
	{
		openDB();
		SQLiteConnectionWithLock connection = _dbconn.GetConnection();
		using (connection.Lock())
		{
			connection.Execute("vacuum");
		}
	}

	private static void backupTo(string pPath)
	{
		openDB();
		SQLiteConnectionWithLock connection = _dbconn.GetConnection();
		using (connection.Lock())
		{
			connection.Backup(pPath);
		}
	}

	public static void saveToPath(string pPath)
	{
		if (File.Exists(pPath))
		{
			File.Delete(pPath);
		}
		if (Config.disable_db)
		{
			return;
		}
		string text = "Stats DB";
		string text2 = pPath + ".bak";
		bool flag = false;
		try
		{
			DBInserter.executeCommands();
			vacuum();
			backupTo(text2);
		}
		catch (IOException ex)
		{
			if (Toolbox.IsDiskFull(ex))
			{
				WorldTip.showNow("Error saving " + text + " : Disk full!", pTranslate: false, "top");
			}
			else
			{
				Debug.Log("Could not save " + text + " due to hard drive / IO Error : ");
				Debug.Log(ex);
				WorldTip.showNow("Error saving " + text + " due to IOError! Check console for details", pTranslate: false, "top");
			}
			flag = true;
		}
		catch (Exception message)
		{
			Debug.Log("Could not save " + text + " due to error : ");
			Debug.Log(message);
			WorldTip.showNow("Error saving " + text + "! Check console for errors", pTranslate: false, "top");
			flag = true;
		}
		if (flag)
		{
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
		}
		else
		{
			Toolbox.MoveSafely(text2, pPath);
		}
	}

	private void Awake()
	{
		ScrollWindow.addCallbackShowStarted(delegate
		{
			DBInserter.executeCommands();
		});
	}

	private void OnApplicationQuit()
	{
		DBInserter.quitting();
		closeDB();
	}
}
