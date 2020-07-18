using System;
using System.Collections.Generic;
using System.Linq;

namespace Def_Constructor
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
            Student alan = new Student();
            Student.FaName = "Alan";
            Student.LaName = "Ngo";
            alan.User_Is_Verified = true;
            Wr_L(Student.TheFullName);
            
            /*Invoking the Default Constructor by not passing anything within the parenthesis*/
            /*Def Cstrct brings an obj to Memory so that it exists */
            Professor wolesensky = new Professor();
            /*YOU CANNOT ACCESS A STATIC MEMBER OF A CLASS WITH THE INSTANCE NAME 
            YOU MUST ACCESS IT WITH THE CLASS NAME
            Error: Polymorphism.User.FName' cannot be accessed with an instance reference, qualify it with a type name instead
            */
            /*
            wolesensky.FName = "William";
            wolesensky.LName = "Wolesensky";
            */
            Professor.FName = "Captain";
            Professor.LName = "Insane-O";
            wolesensky.User_Is_Verified = true;
            
            List<User> teach_And_Stud= new List<User>() {wolesensky, alan};
            
            foreach(User user in teach_And_Stud){
                user.overrideThisPlease();
            }
        }     
    }
}
