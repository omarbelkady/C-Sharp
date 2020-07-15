using System;
using System.Collections.Generic;
using System.Linq;


namespace NestedForEach{
    class List
    {
        static void Main(string [] args) 
        {
        
            List<List<int>> PlayerNumbers=new List<List<int>>()
            {
                //"Messi","Pele","Maradona","Ronadinho","Ronaldo","R.Carlos","Figo","Modric", "Hazard","Suarez"
                new List<int>{10,10,10}, //newList instead of new List will generate an unexpected Symbol error
                new List<int>{10,9,3},
                new List<int>{7,10,7,9}
            };
            foreach(List<int> nums in PlayerNumbers.ToArray())
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
