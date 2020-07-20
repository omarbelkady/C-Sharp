using System;
using System.Collections.Generic;
using System.Linq;

namespace horsesToWatts{
    class horsesToWatts{
        public static void RunMyProg()
        {
            var horses=12;
            var watts = horses * 745.699872;
            Console.WriteLine($"Horses({horses})=>Watts({watts:.###})");
        }
        
        
        static void Main()
        {
            RunMyProg();
        }
    }
}
