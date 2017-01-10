using System;

namespace foresr
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[,] array = new int[10, 10];
			int i = 0, j = 0;
			for (i = 0; i < 10; i++)
				for (j = 0; j < 10; j++)
					array[i, j] = j + 1;
			for (i = 0; i < 10; i++)
			{
				for (j = 0; j < 10; j++)
				{
					Console.Write("{0} ", array[i, j]);
				}
				Console.WriteLine();
			}
		}
	}
}
