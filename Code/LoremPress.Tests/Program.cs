using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoremPress.Tests
{
	public static class Program
	{
		static void Main()
		{
			for (int i = 0; i < 20; i++)
			{
				string title = TitleBuilder.GetTitle();

				Console.WriteLine(title);
			}

		}
	}
}
