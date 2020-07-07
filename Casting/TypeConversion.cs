using System;
namespace TypeConversion
{
    class Program
	{
		static void Main(string[] args)
		{
			int i=1;
			//byte b=i;
			Console.WriteLine(i);
			//Line 9 will raise error since we cannot implicitly convert an int to a byte
			//We can however convert it explicitly
			int m=1;
			byte l=(byte) m;
			Console.WriteLine(l);
		}
	}
}
