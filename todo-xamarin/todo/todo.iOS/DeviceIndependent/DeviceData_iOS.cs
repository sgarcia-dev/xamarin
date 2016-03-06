using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

using todo.iOS.DeviceIndependent;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceData_iOS))]
namespace todo.iOS.DeviceIndependent
{
	public class DeviceData_iOS : IDeviceData
	{
		public string GetLocalFilePath(string filename)
		{
			string docfolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			string libfolder = System.IO.Path.Combine(docfolder, "..", "Library");

			if (!System.IO.Directory.Exists(libfolder))
			{
				System.IO.Directory.CreateDirectory(libfolder);
			}

			return System.IO.Path.Combine(libfolder, filename);
		}
	}
}