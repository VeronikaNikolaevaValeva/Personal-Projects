using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BicycleParking
{
    public class Bicycle
    {
        private static int ticketSeeder = 10000;
        // Instance variables
        private string ticketNumber;
        private int hoursInParking;
        private string ownerZipcode;
        // Properties
        public BicycleType Type
        {
            get; private set;
        }
        public bool IsInParking
        {
            get; set;
        }

        public string OwnerZipcode
        {
            get { return this.ownerZipcode; }
            set
            {
                if (String.IsNullOrEmpty(value)) { this.ownerZipcode = "Unknown"; }
                else { this.ownerZipcode = value; }
            }
        }
        public int HoursInParking
        {
            get { return this.hoursInParking; }
            set
            {
                if (value <= 0) { this.hoursInParking = 1; }
                else { this.hoursInParking = value; }
            }
        }
        public string TicketNumber
        {
            get { return this.ticketNumber; }

        }
        // Constructor
        public Bicycle(BicycleType type)
        {
            this.IsInParking = true;
            this.Type = type;
            this.ticketNumber = type.ToString().Substring(0, 3) + ticketSeeder;
            ticketSeeder++;

        }

        //Uncomment this method when you are done with assignment  2a
        public string GetInfo()
        {
            string s = this.ticketNumber + ": " + this.Type.ToString() + " bicycle";
            if (!this.IsInParking)
            {
                s += " - hours parked " + this.hoursInParking;
                s += " & owner zipcode " + this.ownerZipcode;
            }
            return s;
        }
    }
}
