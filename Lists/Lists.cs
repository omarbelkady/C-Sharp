using System;
using System.Collections.Generic;

namespace myAwesomeProg{
    class Lists {
        static void Main() {
            
            //<============How To Create A List===========>
            /*ListKeyword<datatype>
            <> means GENERIC. A Generic is used to be flexible to work with different types
            and not raise an error*/
            List<int> bestYears= new List<int>();
            
            //To append use the identifier and put a dot and place the add method
            bestYears.Add(2006);
            bestYears.Add(2007);
            bestYears.Add(2005);
            bestYears.Add(2004);
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
