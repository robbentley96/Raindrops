using System;
using System.Collections.Generic;
using System.Text;

namespace Raindrops
{
	public static class RaindropsLibrary
	{
		public static string RaindropsMethod(int num)
		{
			string output = "";
			if (num % 3 == 0){output += "Pling";}
			if (num % 5 == 0){output += "Plang";}
			if (num % 7 == 0){output += "Plong";}

			if (output == "")
			{
				output = num.ToString();
			}
			return output;
		}
	}
}
