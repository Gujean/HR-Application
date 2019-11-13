using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataApi.Settings
{
	public class DataApiSettings: IDataApiSettings
	{
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
	}

	public interface IDataApiSettings
	{
		string ConnectionString { get; set; }
		string DatabaseName { get; set; }
	}
}
