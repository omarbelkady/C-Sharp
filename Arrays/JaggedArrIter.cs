using System;
namespace myAwesomeProg{
    class JaggedArrIter {
        static void Main() {
            
            int [][] jagged_Arr= {
                new int[] {5,4,3,2,1},
                new int[] {13,12,11,10,9,8,7,6,5,4,3},
                new int[] {17,16,15,14}
            };
            
            Wr_i("The element in the Second row First column: "+jagged_Arr[1][0]+"\n");//prints 13
            Wr_L("The number of rows in the array: "+jagged_Arr.Length);//number of rows
            Wr_L("The number of columns in the 2nd row is: "+jagged_Arr[1].Length);//number of columns in the 2nd row
            
            
            //Iterate the through the entire array
            for(int row=0;row<jagged_Arr.Length;row++)//jagged_Arr.Length=3 for number of rows
            {
                for(int col=0;col<jagged_Arr[row].Length;col++)//jagged_Arr[row].Length=11 for max number of columns within the array
                {
                    Wr_i(jagged_Arr[row][col]+" ");
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
