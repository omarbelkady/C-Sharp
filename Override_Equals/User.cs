using System;
using System.Collections.Generic;

namespace OverrideEquals
{
    public class User
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        public string TheFullName{
            get{
                return FName+" "+LName;
            }
        }
        
        public string FName{get;set;}
        public string LName {get;set;}
        
        public override string ToString()
        {
            return TheFullName;
        }
        
        public override bool Equals(object myObj)
        {
            //return base.Equals(myObj);
            //Casting myObj to User
            if(TheFullName == ((User)myObj).TheFullName)
            {
                return true;
            }
            
            return false;
        }
        
        
        //Creating the static Method
        public static void PrintMe(List<User> users)
        {
            foreach(User user in users)
            {
                Wr_L(user.ToString());
            }
        }
        
        //Creating the static Method
        public static void PrintMe(User user)
        {
            Wr_L("Static Method");
            user.outingToCons(2);
        }
        
        public string outingToCons(int num=5)
        {
            string msg="";
            for(int j=0;j<num;j++)
            {
                msg += FName+ " " +LName+"\n";
            }
            return msg;
        }
       
        public static int Find(List<User> users, string FuName)
        {
            for(int i=0;i<users.Count;i++)
            {
                //FuName is not the same as TheFullName because this method is static
                //and TheFullName is NOT
                if(users[i].TheFullName==FuName)
                {
                    return i;
                }
            }
            //Error generated if you do not put the base case:
            //Not all code path return a value generated to overcome this do this:
            
            return -1;//MEANING NOT FOUND
        }
    }   
}
