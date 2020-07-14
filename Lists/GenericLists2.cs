using System;
using System.Collections.Generic;

namespace myAwesomeProg{
    class GenericLists2 {
        static void Main() {
            
            //<============How To Create A List===========>
            /*How to initialize a list with values*/
            List<int> bestYears= new List<int>(){2004,2005,2006,2007};
            //new List Keyword is mandatory for initialization of a list
            bestYears.Add(2008);
            bestYears.Insert(4,2009);//This will take the spot of 2008 and move 2008 to index 5
            foreach(int y in bestYears)
            {
                Wr_L(y);//prints 2004,2005,2006,2007,2009,2008
            }
            
            //To Empty out the list
            bestYears.Clear();
            
            //If I put line 20 on top of line 12 I will get an Argument Out Of Range Exception
            bestYears=new List<int>();
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
