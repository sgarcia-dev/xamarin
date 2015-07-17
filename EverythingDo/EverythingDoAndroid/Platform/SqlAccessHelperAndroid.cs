using System;
using SQLite;

namespace EverythingDoAndroid
{
	public class SqlAccessHelperAndroid
	{
		private SQLiteConnection Connection;

		public SQLiteConnection Instance {
			get {
				return Connection ?? (Connection = CreateConnection());
			}
		}

		private SQLiteConnection CreateConnection () {
			return new SQLiteConnection (AppConfig.FileAccessFactory.GetLocalFilePath(AppConfig.DatabaseFileName));
		}
	}
}

