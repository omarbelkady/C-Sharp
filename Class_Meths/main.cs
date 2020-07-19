using System;
using System.Linq;
using System.Collections.Generic;

namespace ClassMethod
{
    class MyProg
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        static void Main(){
            User Alan = new User();
            Alan.FName = "Alan";
            Alan.LName = "Ngo";
            Wr_L("The User "+Alan.FName+" has made a decision whether/not he loves Pascal and it is: "+Alan.UserLovesPascal+" way too much!");
        }
    }
}
