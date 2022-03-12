using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationHub_VeronikaValeva_AssesmentWeek5
{
    class Van : Vehicle
    {
        private int maximumPassengers;
        private double freighterMaxKg;
        private double freighterMaxVolume;
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
        public double MaxWeight
        {
            set { this.freighterMaxKg = value; }
            get { return this.freighterMaxKg; }
        }
        public double MaxVolume
        {
            set { this.freighterMaxVolume = value; }
            get { return this.freighterMaxVolume; }
        }
        public int MaxPassengers
        {
            set { this.maximumPassengers = value; }
            get { return this.maximumPassengers; }
        }
        public Van(string MakeAndModel, string LicensePlate, double GasUsagePerKM, 
            int MaxPass, double MaxWeight, double MaxVolume, int idSeeker)
            : base(MakeAndModel, LicensePlate, GasUsagePerKM, idSeeker)
        {
            this.freighterMaxKg = MaxWeight;
            this.freighterMaxVolume = MaxVolume;
            this.maximumPassengers = MaxPass;
            this.available = true;
        }
        public override String GetFullInfo()
        {
            return "Van: " + base.GetInfo() + $"\r\n Max passengers: {this.MaxPassengers}. Max weight: {this.MaxWeight}. Max volume: {this.MaxVolume}" +
                $"\r\n Total kms: {this.TotalKM}/ Consumed fuel: {this.CalculateConsumedFuel} - {StringIsItAvailable} ";
        } 
        public override String GetInfo()
        {
            return "\r\n Van: " + base.GetInfo();
        }
        public override string TextFileInfo()
        {
            return $"Truck {this.ID} {this.BrandAndModel} {this.GetLicensePlate} {this.GasUsagePerKm} {this.MaxPassengers} {this.MaxWeight} {this.MaxVolume}";
        }
    }
    

}

