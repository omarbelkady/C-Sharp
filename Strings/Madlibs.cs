using System;
namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)//
        {
    		string color,pNoun,celeb;
    		Console.Write("Enter a color: ");
    		color= Console.ReadLine();
    
    		Console.Write("Enter a plural noun: ");
    		pNoun=Console.ReadLine();
    
    		Console.Write("Enter a celebrity: ");
    		celeb= Console.ReadLine();
    
            Console.WriteLine("Roses are " +color+" "+pNoun + " are blue " + celeb+" Loves You.");
            Console.ReadLine();



        }
    }
}	
