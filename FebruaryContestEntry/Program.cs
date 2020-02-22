using System;

namespace FebruaryContestEntry
{
	class Program
	{
		const char block = '▓';

		const int numrow = 15;
		const int numcol = 30;
		const int leftrightmargin = 2;
		const int topbottommargin = 2;

		static void Main(string[] args)
		{
			// The solution implementation goes here
			int i, j;
			Console.ResetColor();
			Console.WriteLine();

			for (i = 0; i < numrow; i++)
			{
				for (j = 0; j < numcol; j++)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					if ((i<topbottommargin || i>= numrow-topbottommargin) || (j<leftrightmargin || j>=numcol-leftrightmargin)) 
					{
						Console.ForegroundColor = ConsoleColor.Green;
					} 					
					Console.Write(block);					
				}				
				Console.WriteLine();				
			}
			Console.ResetColor();
			Console.WriteLine();
			Console.WriteLine("Yay, a colorful shape!");
			Console.ReadLine();
		}
	}
}
