using System;

namespace foresr
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			int[] vector = new int[size];
			int summ = 0;
			for (int i = 0; i < vector.Length; i++) {
				vector[i] = int.Parse(Console.ReadLine());
				summ += vector[i];
			}
			Array.Resize(ref vector,size+1);
			vector[size] = summ;
			for (int i = 0; i < vector.Length; i++) {
				Console.Write("{0} ", vector[i]);
			}
		}
	}
}
