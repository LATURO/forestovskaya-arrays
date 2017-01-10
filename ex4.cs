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
			int summ = 0;
			for (i = 0; i < l; i++)
			{
				
				for (j = 0; j < l1; j++)
				{
					array[i, j] = int.Parse(Console.ReadLine());
					if (j % 2 == 0) {
						summ += array[i, j];
					}
				}
			}
			for (i = 0; i < l; i++)
			{
				for (j = 0; j < l1; j++)
				{
					Console.Write("{0} ", array[i, j]);
				}
				Console.WriteLine();
			}
			Console.WriteLine("сумма {0}", summ);
		}
	}
}
