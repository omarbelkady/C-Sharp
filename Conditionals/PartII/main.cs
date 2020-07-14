using System;
namespace Conditionals{
    class main
    {
        static void Main()
        {
            //Individual eliya;
            //The above line of code will generate a null reference exception
            //because the constructor was not called
            Individual martin= new Individual();
            
            martin.FName="Martin";
            martin.LName="Smith";
            
            
            Console.Write("Make An Educated Guess of the full Name of the Individual: ");
            string FullNamGuess= Console.ReadLine();
            
            Console.Write("Make A 2nd Educated Guess: ");
            string FullNamGuess2= Console.ReadLine();
            
            if(martin.retFullNam==FullNamGuess)
            {
                Console.WriteLine("Spot On!");
            }
            else if(martin.retFullNam==FullNamGuess2)
            {
                Console.WriteLine("2nd Try but hey at least you got it");
            }
            
            else{
                Console.WriteLine("Just quit! You do not have the sufficient level!");
            }
        }
    }
}
