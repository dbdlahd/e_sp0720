using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
	class Program
	{
		//static string line;
		
		//static System.IO.StreamReader file =new System.IO.StreamReader(@"C:\Users\csim\Desktop\Sophos_Project\FGT80C3912616416_20170717_0936.conf");
		static List<Interface> list = new List<Interface>();
		static int counter = 0;
		static void Main(string[] args)
		{

			// Read the file and display it line by line.  
			String line = null;
			StreamReader file =
				new StreamReader(@"C:\Users\csim\Desktop\Sophos_Project\FGT80C3912616416_20170717_0936.conf");
			while ((line = file.ReadLine()) != null)
			{	
				
				line=line.Trim();
				if (line.StartsWith("config system interface")) {
					findInterface(ref line,ref file);
				}

				//System.Console.WriteLine(line);
				counter++;
			}

			file.Close();
			System.Console.WriteLine("There were {0} lines.", counter);
			Console.ReadLine();
			//Suspend the screen.  

		}

		static Boolean findInterface(ref string line,ref StreamReader file)
		{
			String interfaceName = null;
			int CEcount = 0;
			do
			{
				
				line = line.Trim();		
				if (line.StartsWith("edit \""))
				{
					int startindex = line.IndexOf("\"");
					interfaceName = line.Substring(startindex+1, line.Length - startindex - 2);
					//list.Add((new interface() { interface_name = interfaceName});
					Console.WriteLine(interfaceName);
					//Interface x = new Interface();
					//x.interface_name = interfaceName;
					//list.Add(x);

				}
				if (line.StartsWith("config"))
					CEcount++;
					
				if (line.Equals("end"))
				{
					CEcount--;
					if (CEcount == 0 ) 
						return true;
					
				}
				counter++;
			} while ((line = file.ReadLine()) != null);
			return true;
		}
	}
		

}
