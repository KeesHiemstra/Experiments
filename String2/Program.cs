﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace String2
{
	class Program
	{
		static void Main(string[] args)
		{
			string Line = "This is a line";
			Console.WriteLine(Line.Substring(0, 6));
			Console.WriteLine(Line.PadLeft(16));

			Console.WriteLine(Line);

			Console.Write("\nPress any key");
			Console.ReadKey();
		}
	}
}
