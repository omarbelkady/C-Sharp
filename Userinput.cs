using System;
namespace UserInput
{
    class Program
    {
        static void Main(string[] args)//Method or function
        {  
			Console.Write("Enter your name: ");
			string name= Console.ReadLine();
			Console.Write("Enter your age: ");
			int age= Convert.ToInt32(Console.ReadLine());
           	Console.WriteLine("Hello " + name +" you are "+ age+" years old");
            Console.ReadLine();
        }
       
    }
}
