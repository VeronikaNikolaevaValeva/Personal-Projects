using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagement_AssignmentWeek12
{
    public class WorkshopNotFoundException : Exception
    {
        public WorkshopNotFoundException(): base ("Workshop was not found.")
        {

        }
    }
}
