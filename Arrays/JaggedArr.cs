using System;
namespace myAwesomeProg{
    class JaggedArr {
        static void Main() {
            
            int [][] jagged_Arr= {
                new int[] {5,4,3,2,1},
                new int[] {13,12,11,10,9,8,7,6,5,4,3},
                new int[] {17,16,15,14}
            };
            
            Wr_L(jagged_Arr[1][0]);//prints 13
            
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
