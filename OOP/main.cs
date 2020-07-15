using System;
using System.Collections.Generic;
using System.Linq;


namespace MyAwesomeProg{
    class Objecty
    {
        static void Main(string [] args) 
        {
            Objecty omars_objecty = new Objecty();//instantiation of the class Objecty
            omars_objecty.Shouting_At_You("Yes Sir");
            Student ramoBelkady = new Student();
        }
        static void Wr_L(object o)
        {
            Console.WriteLine(o);
        }
        static void Wr_i(object m)
        {
            Console.Write(m);
        }
        
        public void Shouting_At_You(object b)
        {
            //Instantiation of a Student Object
            Wr_L(b+"!!!!!!!!!");
        }
    }
}
