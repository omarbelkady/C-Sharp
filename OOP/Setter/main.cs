using System;

namespace SetterCreation
{
    class MyProg
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        static void Main(){
            MyProg firstProg = new MyProg();//Calling the constructor
            firstProg.printing();
        }
        
        public void printing()
        {
            Uni_Student myself= new Uni_Student();
            myself.FirstName= "OMAAAAAAAAAAAAaaaaar";
            myself.LastName= "Belkady";
            myself.Year=3;
            Wr_L(myself.outingToCons(2));
        }
    }
}
