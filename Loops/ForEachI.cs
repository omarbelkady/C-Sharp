using System;
using System.Collections.Generic;
using System.Linq;

namespace MyAwesomeProg{
    class ForEachI
    {
        static void Main() 
        {
        
            List<string> bestPlayers=new List<string>(){
                "Messi","Pele","Maradona","Ronadinho","Ronaldo","R.Carlos","Figo","Modric", "Hazard","Suarez"
            };
            foreach(string player in bestPlayers)
            {
                Wr_L(player);
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
