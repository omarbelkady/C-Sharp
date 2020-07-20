using System;
using System.Collections.Generic;
using System.Linq;

namespace CompInter{
    class CompInter{
        
        public static void RunMyProg()
        {
           double princip = 1000;
           
           //Console.ReadKey();
           
           double rate = 10;
           
           double time = 5;//years
           
           //Comp Interest formula
           double comp_inter=princip*Math.Pow(1+rate/100,time);
           
           Console.WriteLine($"You will have to pay back: ${comp_inter}");
        }
        
        public static void Main(string [] args)
        {
            RunMyProg();
        }
            
    }
}
