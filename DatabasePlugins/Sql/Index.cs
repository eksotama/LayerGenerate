using System;
using System.Data;
using System.Data.OleDb;

namespace LayerGen35.DatabasePlugins.Sql
{
#if ENTERPRISE
	using System.Runtime.InteropServices;
	[ComVisible(true), ClassInterface(ClassInterfaceType.AutoDual), ComDefaultInterface(typeof(IIndex))]
#endif 
	public class SqlIndex : Index
	{
		public SqlIndex()
		{

		}
	}
}
