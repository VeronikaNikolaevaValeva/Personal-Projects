using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagement_AssignmentWeek12
{
    public class PersonNotFoundException : Exception
    {
        public PersonNotFoundException() : base("Person was not found.")
        {

        }
    }
}
