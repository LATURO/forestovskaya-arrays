using System;

namespace foresr
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Random r = new Random();
			int size=int.Parse(Console.ReadLine());
			int[,] array = new int[size, size];
			for (int i = 0; i < size; i++) {
				for (int j = 0; j < size; j++) {
					array[i, j] = r.Next(0, 9);
				}
			}
			int buff = size;
			for (int i = 0; i < size; i++)
			{

				for (int j = 0; j < buff; j++)
				{
					
					Console.Write("{0} ", array[i, j]);
				}
				Console.WriteLine();
				buff--;
			}
		}
	}
}
