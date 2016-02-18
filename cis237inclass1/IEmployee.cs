using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    interface IEmployee
    {
        //an interface contains only method declarations and properties
        //there is no need to put an access modifier down because it will
        //always be public. we are specifying only public methods and properties

        //any class that implements this interface must implement the following
        //methods. even if they are abstract with no method body.
        string GetFormattedSalary();

        string GetLastNameFirstName();

        //any class that implements this interface must implement the following properties
        string FirstName
        {
            get;
            set;
        }

        string LastName
        {
            get;
            set;
        }
    }
}
