using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using todo.Droid.DeviceIndependent;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceData_Droid))]
namespace todo.Droid.DeviceIndependent
{
	public class DeviceData_Droid : IDeviceData
	{
		public string GetLocalFilePath(string filename)
		{
			string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			return System.IO.Path.Combine(path, filename);
		}
	}
}