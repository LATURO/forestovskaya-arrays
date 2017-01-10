using System;
using System.Collections;
namespace foresr
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			ArrayList vector = new ArrayList();
			int summ = 0;
			int l = 0;
			for (int i = 0; i < size; i++)
			{
				l = int.Parse(Console.ReadLine());
				vector.Add(l);
				summ += l;
			}
			vector.Add(summ);
			for (int i = 0; i < size+1; i++)
			{
				Console.Write("{0} ", vector[i]);
			}
		}
	}
}
