using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TransportationHub_VeronikaValeva_AssesmentWeek5
{
    class Car : Vehicle
    {
        private int maximumPassengers;
        private bool available;
        public override bool Available
        {
            set { this.available = value; }
            get { return this.available; }
        }
        public string StringIsItAvailable
        {
            get
            {
                if (Available) { return "is available"; }
                else { return "is unavailable"; }
            }
        }
        public int MaxPassengers
        {
            set { this.maximumPassengers = value; }
            get { return this.maximumPassengers; }
        }
        public Car(string MakeAndModel, string LicensePlate, double GasUsagePerKM, 
            int MaxPass, int idSeeker)
            : base(MakeAndModel, LicensePlate, GasUsagePerKM,  idSeeker)
        {
            this.maximumPassengers = MaxPass;
            this.available = true;
        }
        public override String GetFullInfo()
        {
            return "Car: " + base.GetInfo() + $"\r\n Max passengers: {this.MaxPassengers} " +
                $"\r\n Gas usage/km: {this.GasUsagePerKm}, Price/km {this.PricePerKM} " +
                $"Total kms: { this.TotalKM}/ Consumed fuel: {this.CalculateConsumedFuel} - {StringIsItAvailable} ";
        }
        public override String GetInfo()
        {
            return "\r\n Car: " + base.GetInfo();
        }
        public override String TextFileInfo()
        {
           return $"Car {this.ID} {this.BrandAndModel} {this.GetLicensePlate} {this.GasUsagePerKm} {this.MaxPassengers}"; 
        }

    }
}
