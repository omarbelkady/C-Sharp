using System;
namespace Classes{
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
            martin.isAnnoying(true);
            
        }
    }
}
