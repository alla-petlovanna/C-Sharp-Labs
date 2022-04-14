using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10_1
{
	interface IEmp
	{
		void Role();
		void Slr();
		string Name { get; set; }
		int Work_Exp { get; set; }
	}
}
