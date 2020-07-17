using System;
using System.Collections.Generic;


namespace ListSearchForCustObj
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
            User nelan= new User();//Instance identifier
            nelan.FName= "Nelan";//Identifier.methodName
            nelan.LName= "Rawgo";
            
            User Omar = new User();
            Omar.FName = "Omar";
            Omar.LName = "Belkady";
            
            User alanLovesAssembly = new User();
            alanLovesAssembly.FName = "AlanLoves";
            alanLovesAssembly.LName = "Assembly";
            
            List<User> users= new List<User>() {nelan, Omar, alanLovesAssembly};
            
            //Use capital U for User and not Users because we are using a static method
            Wr_L(User.Find(users, "AlanLoves Assembly"));//Outputs index 2
            Wr_L(User.Find(users, "Nelan Rawgo"));//Outputs index 0
            Wr_L(User.Find(users, "Blob Blobby"));//Outputs -1 Not Found
        }   
    }
}
