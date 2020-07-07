using System;
namespace Non-Compat-Type-Conv
{
    class Program
	{
		static void Main(string[] args)
		{
            var number = "1234";
			//If I try to cast the number variable to an int it will error
			//int i= (int) number;
			//This will error because they are not compatible
			//When we get an error of” cannot cast expression of type "string" to type "int"
			//We need to use the convert class
			int i= Convert.ToInt32(number);
			Console.WriteLine(i);
        }
	}
}
    
