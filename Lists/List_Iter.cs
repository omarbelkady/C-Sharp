using System;
using System.Collections.Generic;
using System.Linq;

namespace MyAwesomeProg{
    class List_Iter {
        static void Main() {
            
            List<string> bestPlayers=new List<string>()
            {"Messi","Pele","Maradona","Ronadinho","Ronaldo","R.Carlos","Figo","Modric", "Hazard","Suarez"};
            for(int i=0;i<bestPlayers.Count;i++)
            {
                bestPlayers[i]+="*";// Appending Making a modification to every element in the list
                Wr_i(bestPlayers[i]+" ");
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
