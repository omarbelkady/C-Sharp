using System;
using System.Linq;
namespace CheckIfEqual{
    class Arrays {
        static void Main() {
            
            //Comparing an array
            int [] soccer_player_num={1,2,3,4,5,8,9,11};
            int [] soccer_player_num2={1,2,3,4,5,8,9,11};
            /*if(soccer_player_num2==soccer_player_num)
            {
                Wr_L("Equal!!");
            }
            //Output: Nothing
            */
            if(Enumerable.SequenceEqual(soccer_player_num,soccer_player_num2))
            {
                Wr_L("They are equal my friend!");
            }
            
            N_2526("2 ");
            
        }
        
        static void Wr_L(object o)
        {
            Console.WriteLine(o);
        }
        
        static void WR(object m)
        {
            Console.Write(m);
        }
        
        static void N_2526(object n)
        {
            Wr_L("2526 56837 "+n+ "& 6342");
        }
        
        // == Compares the object reference to see if they have the same entities
        // if I did soccer_player_num=soccer_player_num2 and then did 
        //if(soccer_player_num==soccer_player_num2) this would output to true
        
    }
}
