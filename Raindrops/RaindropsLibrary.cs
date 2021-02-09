using System;
using System.Collections.Generic;
using System.Text;

namespace Raindrops
{
	public static class RaindropsLibrary
	{
		public static string RaindropsMethod(int num)
		{
			StringBuilder sb = new StringBuilder();
			if (num % 3 == 0){ sb.Append("Pling"); }
			if (num % 5 == 0){ sb.Append("Plang"); }
			if (num % 7 == 0){ sb.Append("Plong"); }
			string output = sb.ToString();
			if (output == "")
			{
				output = num.ToString();
			}
			return output;
		}
	}
}
