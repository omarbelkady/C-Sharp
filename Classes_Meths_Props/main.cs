using System;
namespace Classes{
    class Classes{
        static void Main(string [] args)
        {
            Individual Marcus= new Individual();
            Marcus.FName= "Marcus";
            Marcus.LName= "Jacobs";
            
            //myFullN is a method must have a parenthesis
            //Console.WriteLine(Marcus.myFullN());
            
            //retFullNam is a property no parenthesis
            Console.WriteLine(Marcus.retFullNam);
            
        }
    }
}
