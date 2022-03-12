using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagement_AssignmentWeek12
{
    public interface IWorkshopDAL
    {
        void WriteWorkshopsToTextFile(List<Workshop> listOfAllWorkshops, string filename);

    }
}
