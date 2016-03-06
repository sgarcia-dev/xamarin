using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo
{
	public interface IDeviceData
	{
		string GetLocalFilePath(string filename);
	}
}
