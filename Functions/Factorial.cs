using System;
using System.Collections.Generic;
using System.Linq;

namespace factorial{
    class Facti{
        public static void RunMyProg()
        {
            var num = 10;
            var fact=Fact(num);
            
            Console.WriteLine($"Factorial of {num} =>{fact}");
            
            
        }
        
        public static int Fact(int n)
        {
            var result = 1;
            while(n > 0)
            {
                result = result*n;
                n -=1;
                
            }
            
            return result;
            
        }
        
        static void Main()
        {
            RunMyProg();
        }
    }
}
