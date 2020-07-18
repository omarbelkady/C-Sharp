using System;
namespace Interfaces
{
    public interface MeTalking//() will cause the error Unexpected symbol `(', expecting `:', `{', or `where'
    {
        void SomeThingToTheConsole();//There is no body we are saying it must exist
        int MakeSth{get; set;}
    }
}
