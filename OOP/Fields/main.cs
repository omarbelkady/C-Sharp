using System;
using System.Collections.Generic;
using System.Linq;

namespace FieldMaking{
    class The_Best_Prog {
    
        static void Main(){
            The_Best_Prog progA = new The_Best_Prog();
            progA.printing();
        }
        
        
        static void Wr_L(object o)//Includes a new line char
        {
            Console.WriteLine(o);
        }
        
        static void Wr_i(object m)//DOESN't
        {
            Console.Write(m);
        }
        
        public void printing()
        {
            Car merc = new Car();
            //Not calling the constructor will result in a The type or namespace name `Car' could not be found error
            merc.Manufacturer="Mercedes";
            merc.Model="CLA250";
            merc.Year=2019;
            
            Console.WriteLine("I have a "+merc.Year+" "+merc.Manufacturer+" "+merc.Model);
        }
        
    }
}
