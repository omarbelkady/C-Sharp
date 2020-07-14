using System;
namespace myAwesomeProg{
    class MultiDim {
        static void Main() {
            //int [,] player_Nums= new int [2,4];//8 players 2 rows 4 colums
            //number 3- gerard Piqué
            //number 5-sergio busquets,
            //number 7-philippe coutinho
            //number 8-arthur melo,
            //number 9- luis suarez
            //number 10- lionel messi
            //number 11- dembele
            //number 18- jordi alba
            
            //give it values up front
            /*CHANGE THIS 
                int [,] player_Nums= new int [2,4]{
                    {3,5,7,8},{9,10,11,18}
            };
            */
            
            //To THIS
            int [,] player_Nums= {
                {3,5,7,8},{9,10,11,18}
            };
            
            foreach(int col in player_Nums)
            {
               System.Console.Write("player_Num: "+col+"\n");
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
