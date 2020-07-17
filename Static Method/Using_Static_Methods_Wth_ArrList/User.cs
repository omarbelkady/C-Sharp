using System;
using System.Collections.Generic;

namespace Static_Methods
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
        
        public static void PrintThemAndMe(List<User> users)
        {
            foreach(User user in users)
            {
                Wr_L(user.outingToCons(1));
            }
        }

        //Creating the static Method
        public static void PrintMe(User user)
        {
            Wr_L("Static Method");
            Wr_L(user.outingToCons(2)+"\n");
        }
        
        public string outingToCons(int num)
        {
            string msg="";
            for(int j=0;j<num;j++)
            {
                msg += FName+ " " +LName+" ";
            }
            return msg;
        }
    }
}
