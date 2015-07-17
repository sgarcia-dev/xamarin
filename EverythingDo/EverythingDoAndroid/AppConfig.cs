using System;

namespace EverythingDoAndroid
{
	public static class AppConfig
	{
		public const string DatabaseFileName = "todos.db3";
		public static FileAccessHelperAndroid FileAccessFactory = new FileAccessHelperAndroid();
		public static SqlAccessHelperAndroid SqlConnectionFactory = new SqlAccessHelperAndroid();
	}
}