using System;
using System.Collections.Generic;
using System.Linq;


namespace NestedForEachForArray{
    class List
    {
        static void Main(string [] args) 
        {
        
            int [][] PlayerNumbers= //As you can see no new keyword and 2526 56837 2!
            {
                //"Messi","Pele","Maradona","Ronadinho","Ronaldo","R.Carlos","Figo","Modric", "Hazard","Suarez"
                new int[] {10,10,10}, 
                new int[] {10,9,3},
                new int[] {7,10,7,9}
            };
            
            //Each element will now be an integer Array
            //foreach(List<int> nums in PlayerNumbers.ToArray())
            foreach(int[] nums in PlayerNumbers)
            {
                foreach(int num in nums)
                {    
                    Wr_i(num+"\t");
                }
                Wr_L(" ");
            }
        
        }
        static void Wr_L(object o)
        {
            Console.WriteLine(o);
        }
        
        static void Wr_i(object m)
        {
            Console.Write(m);
        }
    }
}
