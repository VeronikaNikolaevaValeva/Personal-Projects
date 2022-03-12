using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagement_AssignmentWeek12
{
    public class InBuilding : Workshop
    {
        private string address;
        private string roomNumber;

        public string GetAddress
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string GetRoomNumber
        {
            get { return this.roomNumber; }
            set { this.roomNumber = value; }
        }

        public InBuilding(int id, string title, string description, int maxCapacity, Person teacher, string address, string roomNumber)
            : base(id, title, description, maxCapacity, teacher)
        {
            this.GetAddress = address;
            this.GetRoomNumber = roomNumber;
        }

        public override string ToString()
        {
            return base.ToString() + " (InBuilding)";
        }

        public override string SaveInformation()
        {
            return "INBUILDING(" + base.SaveInformation() + $", Location:{this.GetAddress} {this.GetRoomNumber})";
        }
    }
}
