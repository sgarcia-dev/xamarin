using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using todo.WinPhone.DeviceIndependent;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceData_WinPhone))]
namespace todo.WinPhone.DeviceIndependent
{
	public class DeviceData_WinPhone : IDeviceData
	{
		public string GetLocalFilePath(string filename) {
			string path = Windows.Storage.ApplicationData.Current.LocalFolder.Path;
			return System.IO.Path.Combine(path, filename);
		}
	}
}
