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
			int[,] array = new int[l, l1];
			for (i = 0; i < l; i++)
			{
				
				for (j = 0; j < l1; j++)
				{
					array[i, j] = 0;

				}
				array[i, l1 - i - 1] = 1;
				array[i, i] = 1;
			}
			for (i = 0; i < l; i++)
			{
				for (j = 0; j < l1; j++)
				{
					Console.Write("{0} ", array[i, j]);
				}
				Console.WriteLine();
			}
		}
	}
}
