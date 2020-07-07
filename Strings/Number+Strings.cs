using System;
namespace Ramo
{
    class Program
		{
        static void Main(string[] args)//Method or function
        {
						string phrase= "Computer Eng/Sci";
						Console.WriteLine(phrase);	
						Console.WriteLine(phrase[6]);
						Console.WriteLine(phrase.IndexOf('E'));
						Console.WriteLine(phrase.IndexOf('z'));//prints out -1 means char is not in string
						//Console.WriteLine(phrase.Substring(start, step)
						Console.WriteLine(phrase.Substring(9,3));
						int num=6;
						num++;
						Console.WriteLine(num);
						Console.WriteLine(5.0/2.0);
						Console.ReadLine();
        }
   
    }
}

