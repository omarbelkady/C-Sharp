using System;
using System.Collections.Generic;
using System.Linq;
namespace MyAwesomeProg{
    class ListToArr_ArrToList {
        static void Main() {
            List<int> coolThings = new List<int>(){2};
            
            //Convert coolThings To An Array
            coolThings.ToArray();
            
            
            
            //This is a jagged Array
            int [][] hourHands = 
            {
                new int[]{1,2,3},//index: 0
                new int[]{4,5,6},//index: 1
                new int[]{7,8,9},//index: 2
                new int[]{10,11,12}//index: 3
            };
            
            //Convert a multi-dimensional Array to A List
            List<int> jagged_to_List=hourHands[2].ToList();
            for(int i=0;i<jagged_to_List.Count;i++)
            {
                Wr_i(jagged_to_List[i]+" ");
            }
            Wr_L("\n");
            foreach(int [] hands in hourHands)
            {
                foreach(int hand in hands)
                {
                    Wr_i(hand + "\t");
                }
                Wr_L("");
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
