using System;
using System.Collections.Generic;
using System.Linq;

namespace FtToCm{
    class FtToCm{
        
        public static void RunMyProg()
        {
           double feet = 3;
           double ft_to_cm=2.54*12*feet;
           
           Console.WriteLine($"I am converting Feet to Centimeters: Feet({feet})=>CM({ft_to_cm:.##})");
        }
        
        public static void Main(string [] args)
        {
            RunMyProg();
        }
            
    }
}
