using System;

namespace EverythingDoAndroid
{
	public class FileAccessHelperAndroid
	{
		public string GetLocalFilePath (string filename) {
			string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			var result = System.IO.Path.Combine(path, filename);
			return result;
		}
	}
}

