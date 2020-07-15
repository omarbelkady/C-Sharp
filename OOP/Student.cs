using System;

namespace MyAwesomeProg
{
    public class Student{
        //Default Constructor
        public Student() => Wr_L("I automatically say this when I am created!");
        
        //Arrow Function
        static void Wr_L(object o)=>Console.WriteLine(o);
        
        static void Wr_i(object m)=>Console.Write(m);
    }
}
