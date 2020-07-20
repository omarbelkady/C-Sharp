//This program converts a 24-hour clock to 12-hour clock
using System;
using System.Globalization;

namespace Dist_Between_Two_Pts{
    public class Dist_Between_Two_Pts{
        
        public static void RunMyProg()
        {
            var p1 =new int[] {16,3};
            var p2 =new int[] {9,4};

            var dist_bet_2_pts=Math.Sqrt(
                                        (Math.Pow(p1[0]-p2[0],2))+
                                        (Math.Pow(p1[1]-p2[1],2))
                                        );
            Console.WriteLine($"The Distance Between the two points is: {dist_bet_2_pts:.##}");
        }
        
        public static void Main(string [] args)
        {
            RunMyProg();
        }  
    }
}
