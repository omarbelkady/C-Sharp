using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassMethod
{
    public class User
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char 
        
        //Making it static to prevent it from being overriden and prevent the error
        public string FName{get;set;}
        
        //Making it static to prevent it from being overriden and prevent the error
        public string LName {get;set;}
        
        public bool UserLovesPascal
        {
            //Use .Equals when comparing Objects
            get => (FName.Equals("Alan") && LName.Equals("Ngo"));
        }
    }
}
