using System;
using System.Collections.Generic;
using System.Linq;
namespace MyAwesomeProg{
    class Sort_A_List {
        static void Main() {
            List<int> repin = new List<int>(){15,4,6,3,8,19,1};
            repin.Reverse();//.Reverse is a void method 
            repin.Sort();
            foreach(int i in repin)
            {
                Wr_i(i+" ");
            }
            
            List<string> names= new List<string>(){"Zoubida","Nouhaila","Angela","Daniela","Mariana"};
            names.Sort();
            Wr_L(" ");
            foreach(string j in names)
            {
                Wr_L(j);
            }
        }
        static void Wr_L(object o)
        {
            Console.WriteLine(o);
        }
        
        static void Wr_i(object m)
        {
            Console.Write(m);
        }
    }
}
