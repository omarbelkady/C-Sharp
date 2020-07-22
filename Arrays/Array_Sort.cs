using System;
using System.Collections; 

namespace Arrays{
        public class Array_Sort {
        static void Main() {
            string [] myArr ={"water","aqua","blossom","feet","torpedo"};
            Array.Sort(myArr,0,5);
			
			foreach(object i in myArr)
			{
				Console.WriteLine(i);
			}
        }
    }
}
