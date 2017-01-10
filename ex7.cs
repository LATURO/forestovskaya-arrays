using System;

namespace foresr
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			

			int i = 0, j = 0;
			int l = int.Parse(Console.ReadLine());
			int l1 = int.Parse(Console.ReadLine());
			int[][] array = new int[l][];
			for (i = 0; i < l; i++)
			{
				array[i] = new int[l1];
			}
			for (i = 0; i < l; i++)
			{
				
				for (j = 0; j < l1; j++)
				{
					array[i][j] = int.Parse(Console.ReadLine());
				}
			}
			for (i = 0; i < l; i++)
			{
				for (j = 0; j < l1; j++)
				{
					Console.Write("{0} ", array[i][j]);
				}
				Console.WriteLine();
			}
			Console.Write("Номер строки:");
			i = int.Parse(Console.ReadLine());
			i -= 1;
			Array.Reverse((array[i]));
			for (i = 0; i < l; i++)
			{
				for (j = 0; j < l1; j++)
				{
					Console.Write("{0} ", array[i][j]);
				}
				Console.WriteLine();
			}
		}
	}
}
