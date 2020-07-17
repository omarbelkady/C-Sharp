using System;
using System.Collections.Generic;
namespace MethOverLoad
{
    class MyProg
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        static void Main(){
            MyProg firstProg = new MyProg();//Creating an object
            firstProg.printing();
        }
        
        public void printing()
        {
            
            User myself = new User();
            myself.FName= "Omar";
            myself.LName = "Belkady";
            
            User him = new User();
            him.FName= "Nelan";
            him.LName = "IsACLover";
            
            List<User> users = new List<User>() {myself,him};
            
            User search = new User();
            search.FName = "Nelan";
            search.LName = "IsACLover";
            
            Wr_L(User.Find(users, search));
            //Outputs 1 because him has index 1 and search is the exact same field values as search         
        }
    }
}
