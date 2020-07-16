using System;
namespace Properties
{
    class MyProg {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        static void Main(){
            MyProg firstProg = new MyProg();//Calling the constructor
            firstProg.printing();
        }
        
        public void printing()
        {
            Uni_Student Alan= new Uni_Student();
            Alan.FirstName = "Alan";
            Alan.LastName= "Ngo";
            Alan.Identification_Number= 634256837;
            Alan.Major= "CS with a C-Language Concentration!";
            Alan.Year=4;
            Wr_L(Alan.FirstName+" "+Alan.LastName+" has an id of: "+Alan.Identification_Number+" and majors in: \n"+Alan.Major+" and is in his "+Alan.Year+"(th) year of University");
            
            
        }
    }
}
