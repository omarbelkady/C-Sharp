using System

namespace CastingWthException
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				string str= “true”;
				bool b= Convert.ToBoolean(str);
				Console.WriteLine(b);
			}
			catch(Exception)
			{
				Console.WriteLine(“The number couldn’t be converted to a byte);
			}
		}
	}
}
