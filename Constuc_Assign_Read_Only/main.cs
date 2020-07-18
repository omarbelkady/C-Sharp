using System;
using System.Collections.Generic;
using System.Linq;

namespace Constr_READ_ONLY_FIELD
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
            Student myself = new Student("Omar", "Belkady");
            //Now I cannot give a value for FName and LName for Student because FName and LName are Read only
            Wr_L(myself.TheFullName);
            
            Student nelan = new Student("Alan", "6342 56837");
            Wr_L(nelan.TheFullName);
            
            Student nouhaila = new Student("nouhaila", "223727");
            Wr_L(nouhaila.TheFullName);
            //I must create a constructor at the user level to overcome this error
            
            //I have to give it a value in the beginning
            //I cannot do myself.FName because the fields are readOnly
            //I have to give it a value at the very beginning
            //That is why I created a constructor at the User level
            nouhaila.overrideThisPlease();
            nelan.overrideThisPlease();
            
            //Remember I cannot instantiate a User object because the class is Abstract
        }     
    }
}
