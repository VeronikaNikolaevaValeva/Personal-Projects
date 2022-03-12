using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagement_AssignmentWeek12
{
    public class ExistingPersonException : Exception
    {
       
        public ExistingPersonException() : base($"This student is already assigned to this workshop.")
        {

        }
    }
}
