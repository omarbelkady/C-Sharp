using System;
using System.Collections.Generic;
using System.Linq;

namespace Interfaces
{
    public abstract class User
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        public User()
        {
           
        }
       
        public User(string FN, string LN)
        {
            FName=FN;
            LName=LN;
        }
        public bool User_Is_Verified{get;set;} = false;
        
        public string TheFullName{
            get{
                return FName+" "+LName;
            }
        
        }
        //Since Student inherits from User I will make the FName and LName immutable and Readonly. I get rid of set
        public string FName{get;}//How to create a default value here?
        //Create a constructor that allows the value to be passed in and after that it is immutable
        
        public string LName {get;}
        
        //Removing the static keyword removes the error:
        //`Constr_READ_ONLY_FIELD.User.FName' cannot be assigned to (it is read-only)
    
        public abstract void SomeThingToTheConsole();
    }
}
