using System;//System is a namespace and console is defined within the system namespace
//in order to use the console class we need to declare the system library
namespace Variables
{
	class Program
	{
		static void logln(object o)
		{
			Console.WriteLine(o);
		}
		static void Main(string[] args)
		{
			//byte number;
			//before we can display the number on the console we have to //initialize it
			byte number=2;
			int count=10;
			//I cannot write the statement below
			//float totalPrice=20.95;
			//the correct way is this:
			float totalPrice = 20.95f;
			char character= 'a';
			string firstName= "Omar";
			bool isWorking= true;
			logln(number);
			//Instead of writing console.writeline for every variable
			//we will use a code snippet
			//cw
			logln(count);
			logln(totalPrice);
			logln(character);
			logln(firstName);
			logln(isWorking);
			//I can use the var keyword which will not require me to explicitly
			//declare the data type of each variable
			var number1=2;
			var count2=10;
			var totalPrice1=20.95f;
			var character9='b';
			var firstName1= "Joseph";
			var isWorking9=false;

		}
	}
}
