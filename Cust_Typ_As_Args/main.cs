using System;
using System.Collections.Generic;

namespace Cust_Typ_As_Args
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
            List<string> goodClothingBrands = new List<string>(){"Abercrombie", "Hollister", "Tommy Hilfiger"};
            List<string> goodCologneBrands = new List<string>(){"Calvin Klein", "Paco Rabane", "Dior"};
            
            
            
            //Creating the List OF Custom Type Uni_Student
            List<Uni_Student> uniStudents = new List<Uni_Student>();
            
            for(int i=0;i<goodCologneBrands.Count;i++)
            {
                Uni_Student uniStud = new Uni_Student();//creating a new uniStud object and add it to the list
                uniStud.FName = goodClothingBrands[i];
                uniStud.LName = goodCologneBrands[i];
                uniStudents.Add(uniStud);
            }
            
            foreach(Uni_Student uniStud in uniStudents)
                Wr_L(uniStud.TheFullName);
                //Without the .TheFullName it will print Lists_Of_Cust_Typ which is the name of the namespace
            
            takeStud(uniStudents[0]);
            Wr_L(uniStudents[0].TheFullName);
        }
        
        public void takeStud(Uni_Student uniStud)
        {
            uniStud.FName="Moschino";
            Wr_L(uniStud.TheFullName);
        }
        //Anytime we pass in objects they are modifiable
        //We can change objects but we cannot assign new objects
    }
}
