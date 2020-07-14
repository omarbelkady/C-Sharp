using System;
namespace myAwesomeProg{
    class SquaredArrIter {
        static void Main() {
            
            int [,] square_Arr= {
                {5,9,8,4,3},
                {1,6,5,2,4},
                {7,8,6,5,2}
            };
            
            Wr_L(square_Arr.GetLength(0));//num of rows
            Wr_L(square_Arr.GetLength(1));//num of cols
     
            //Iterate the through the entire 2d-array
            for(int row=0;row<square_Arr.GetLength(0);row++)
            {
                for(int col=0;col<square_Arr.GetLength(1);col++)
                {
                    Wr_i(square_Arr[row,col]+" ");
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
