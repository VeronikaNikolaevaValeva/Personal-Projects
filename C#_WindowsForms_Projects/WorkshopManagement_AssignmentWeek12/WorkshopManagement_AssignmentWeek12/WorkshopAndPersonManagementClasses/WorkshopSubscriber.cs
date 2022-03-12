using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopManagement_AssignmentWeek12
{
    class WorkshopSubscriber
    {
        List<Workshop> availableWorkshops;

        public WorkshopSubscriber(WorkshopManager listOfWorkshops)
        {
            listOfWorkshops.AddWorkshopSubscriber(WorkshopUpdate);
            listOfWorkshops.AddWorkshopCapacitySubscriber(WorkshopCapacityUpdate);
            availableWorkshops = new List<Workshop>();
        }

        private void WorkshopUpdate(Workshop workshop)
        {
            availableWorkshops.Add(workshop);
        }

        private void WorkshopCapacityUpdate(Workshop workshop)
        {
            MessageBox.Show($"The enrollement for workshop: {workshop.GetTitle} exceeds 90% of its capacity.");
        }

        public List<Workshop> GetListOfAvailableWorkshops()
        {
            return this.availableWorkshops;
        }
    }
}
