using System;
namespace myAwesomeProg{
    class Arrays {
        static void Main() {
            
            //Comparing an array
            int [] soccer_player_num={1,2,3,4,5,8,9,11};
            int [] soccer_player_num2={1,2,3,4,5,8,9,11};
            if(soccer_player_num2==soccer_player_num)
            {
                Wr_L("Equal!!");
            }
            //Output: Nothing
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
