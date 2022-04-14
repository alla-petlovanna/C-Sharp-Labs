using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10_1
{
	interface IEmp
	{
		void Role();
		void Zarplata();
		string Name { get; set; }
		int Stag_Rob { get; set; }
	}
}
