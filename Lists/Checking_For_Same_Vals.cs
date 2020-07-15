using System;
using System.Collections.Generic;
using System.Linq;

namespace MyAwesomeProg{
    class Checking_For_Same_Vals {
        static void Main() {
            List<int> multsOfX = new List<int>(){6,12,18,24,30,36,42,48,54,60};
            List<int> multsofEerht = new List<int>(){3,6,9,12,15,18,21,24};
            List<int> multsOfXII = new List<int>(){6,12,18,24,30,36,42,48,54,60};
            //if(multsOfX.Equals(multsOfXII)) 
                /*
                    Wr_L("True");
                */
            //The above if statement outputs to false which means nothing will be outputted because 
            //We are checking if multsOfX is the same entity as multsOfXII not if they 
            //have the same values. In whole, we are checking if the multsOfX and multsOfXII reference
            //the same list. It is not true because multsOfX is stored in a different memory location
            //than where multsOfXII is stored.
            
            List<char> awesomeChars=new List<char>(){'!','@','#','$','%','^','&','*','(',')','-','_','=','+'};
            List<char> awesomeCharsPartII= awesomeChars;
            
            if(awesomeChars.Equals(awesomeCharsPartII))
            {
                Wr_L("Equal in Location");
            }
            
            //Now I check if they have the same values
            if(awesomeChars.SequenceEqual(awesomeCharsPartII))
            {
                Wr_L("Same Values Dude!");
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
