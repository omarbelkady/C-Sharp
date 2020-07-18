using System;

namespace Inherit_And_Override_Meths
{
    public class Student : User //Student Inherits From User
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char 
        
        //Inherit and Override
        public override void overrideThisPlease()
        {
            Wr_L("Howdy Howdy y'all my I just overrode the User meth and by I, I am: "+TheFullName.ToUpper());
                                                                //  do not put parenthesis after TheFull Name
                                                                //Error Generated: Expression denotes a `value', 
                                                                //where a `method group' was expected
        }
    }
}
