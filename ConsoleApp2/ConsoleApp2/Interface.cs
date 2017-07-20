using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Interface
	{
		public string interface_name;
		public string vdom;
		public string ip;
		public string allowaccess;
		public string type;
		public string device_identification;
		public string snmp_index;
		public string secondary_IP;
		public string speed;

		


		private int _i;

		public int i
		{
			get { return _i; }
			set { _i = value; }
		}

		public void setInterface_name(String name)
		{
			this.interface_name = name;
		}
		public String getInterface_name()
		{
			return interface_name;
		}
	}
}
