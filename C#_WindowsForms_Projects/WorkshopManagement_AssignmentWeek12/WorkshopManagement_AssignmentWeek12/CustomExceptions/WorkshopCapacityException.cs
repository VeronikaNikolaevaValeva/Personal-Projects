using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagement_AssignmentWeek12
{
    public class WorkshopCapacityException : Exception
    {
        public WorkshopCapacityException() : base($"The workshop has more students" +
            $" enrolled for it than the edited maximum capacity. You have to delete some of the students to change the capacity of the workshop! ") 
        {

        }
    }
}
