using System;
using System.Collections.Generic;

namespace myAwesomeProg{
    class ListIteration {
        
        static void Main() {
            
            //           HOW TO INSTANTIATE A LIST BY ENUMERATION
            var names = new List<string>{ "nihitha", "waleed", "hannah", "sam" };
            var nelanFavProgLangs= new List<string>{"C","C","C","C","C","ALL THE WAY"};
            
            var omars = new List<string>{"flask", "assembly", "Chromebook"};
            
            //CAMEL CASE FOR VARS
            //PASCAL FOR FUNCTIONS AND PROPER
            foreach(string Cfan in nelanFavProgLangs)
            {
                Wr_i("Alan is "+Cfan+" LOVER ");
            }
            Wr_i("\nOmar LOVES ");
            foreach(string pl in omars)
            {
                Wr_i(pl+" ");
            }
            
            Wr_L("\nTAKE THIS WITH A GRAIN OF SALT FYI BUT FOR ALAN THIS IS TRUE!");
        }
        
        
        static void Wr_L(object o)//Includes a new line char
        {
            Console.WriteLine(o);
        }
        
        static void Wr_i(object m)//DOESN't
        {
            Console.Write(m);
        }
        
    }
}
