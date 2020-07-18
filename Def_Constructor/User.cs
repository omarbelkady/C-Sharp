using System;
using System.Collections.Generic;
using System.Linq;

namespace Def_Constructor
{
    public abstract class User
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        public User()
        {
            Wr_L("You know what I get printed out first because Both Student and Professor inherit from me. Finally, Alan 56837 C!");
        }
        
        public bool User_Is_Verified{get;set;}=false;
        public static string TheFullName{
            get{
                return FName+" "+LName;
            }
        }
        
        public static string FName{get;set;}
        
        public static string LName {get;set;}
    
        public abstract void overrideThisPlease();
    }
}
