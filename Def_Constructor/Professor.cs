using System;
namespace Def_Constructor
{
    public class Professor : User{
        
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        //Not putting the parenthesis for the constructor will result in the error:
        //Unexpected symbol `{' in class, struct, or interface member declaration
        public Professor(){
            
        }
        
        public override void overrideThisPlease()
        {
            Wr_L("Howdy Howdy y'all I just overrode the User meth and by I, I am the Prof: "+TheFullName);
        }
    }
}
