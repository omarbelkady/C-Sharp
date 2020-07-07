using System;
namespace Ramo
{
    class Program
	{
        static void Main(string[] args)//Method or function
        {
        	string phrase= "Nelan 4Eva";
        	Console.WriteLine(phrase);	
        	Console.WriteLine(phrase[3]);
            Console.WriteLine(phrase[8]);
            Console.WriteLine(phrase.IndexOf('v'));
            Console.WriteLine(phrase.IndexOf('a'));//prints out -1 means char is not in string
            //Console.WriteLine(phrase.Substring(start, step)
            Console.Write("I am printing part of the string "+phrase.Substring(4,6));
            Console.ReadLine();
        
            
        }
   
    }
}
