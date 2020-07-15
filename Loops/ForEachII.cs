using System;
using System.Collections.Generic;
using System.Linq;

namespace MyAwesomeProg{
    class ForEachII
    {
        static void Main(string [] args) 
        {
        
            List<int> bestPlayersNums=new List<int>(){
                //"Messi","Pele","Maradona","Ronadinho","Ronaldo","R.Carlos","Figo","Modric", "Hazard","Suarez"
                10,10,10,10,9,3,7,10,7,9
            };
            foreach(int num in bestPlayersNums)
            {
                Wr_i(num+" ");
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
