using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagement_AssignmentWeek12
{
    public class Online : Workshop
    {
        private string url;

        public string GetUrl
        {
            get { return this.url; }
            private set { this.url = value; }
        }

        public Online(int id, string title, string description, int maxCapacity, Person teacher)
            : base(id, title, description, maxCapacity, teacher)
        {
            this.GetUrl = $"http://www.{this.GetTitle}.nl";
        }

        public override string ToString()
        {
            return base.ToString() + " (Online)";
        }


        public override string SaveInformation()
        {
            return "ONLINE(" + base.SaveInformation() + $", URL:{this.GetUrl})";
        }


    }
}
