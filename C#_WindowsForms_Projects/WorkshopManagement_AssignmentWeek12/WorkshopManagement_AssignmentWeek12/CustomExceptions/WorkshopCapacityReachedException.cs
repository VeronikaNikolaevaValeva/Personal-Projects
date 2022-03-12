using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagement_AssignmentWeek12
{
    public class WorkshopCapacityReachedException : Exception
    {
        public WorkshopCapacityReachedException() : base ($"Workshop capacity reached. Students cannot be added to this workshop.")
        {

        }

    }
}
