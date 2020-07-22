using System;

class Leap_Or_Not{
    static void Main(){
        string start= "Y";
        while(start != "n"){
            Wr_s("Please enter a year: ");
            int yr_inp =int.Parse(Console.ReadLine());
            if((yr_inp%4==0 && yr_inp%100 !=0)||yr_inp%400==0)
            {
                Wr_L($"{yr_inp} is a leap year");
            }
        
            else{
                Wr_L("This is not a leap year");
            }
            Wr_s("Go Again?:");
            start = Console.ReadLine();
        }  
    }
    static void Wr_L(object n){
        Console.WriteLine(n);
    }
    static void Wr_s(object o){
        Console.Write(o);
    }
}
