using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TransportationHub_VeronikaValeva_AssesmentWeek5
{
    public abstract class Vehicle
    {
        private string makeAndModel;
        private string licensePlate;
        private double gasUsagePerKM;
        private double pricePerKM;
        private double totalKM;
        private int id;
        public abstract bool Available { set; get; }
        public abstract string TextFileInfo();
        public int ID
        {
            get { return this.id; }
        }
        public string BrandAndModel
        {
            set { this.BrandAndModel = value; }
            get { return this.makeAndModel; }
        }
        public string GetLicensePlate
        {
            set { this.licensePlate = value; }
            get { return this.licensePlate; }
        }
        public double GasUsagePerKm
        {
            set { this.gasUsagePerKM = value;}
            get { return this.gasUsagePerKM; }
        }
        public double PricePerKM
        {
            set { this.pricePerKM = GasUsagePerKm*10; }
            get { return this.pricePerKM; }
        }
        public double TotalKM
        {
            set { this.totalKM += value; }
            get { return this.totalKM; }
        }
        public double CalculateConsumedFuel
        {
            get { return TotalKM * GasUsagePerKm; }
        }
        protected Vehicle(string MakeAndModel, string LicensePlate, double GasUsagePerKM,  int idSeeker)
        {
            this.licensePlate = LicensePlate;
            this.gasUsagePerKM = GasUsagePerKM;
            this.pricePerKM = GasUsagePerKM * 10;
            this.id = idSeeker;
            this.totalKM = 0;
            this.makeAndModel = MakeAndModel;
        }
        public virtual String GetFullInfo()
        {
            return $"{this.licensePlate} {this.makeAndModel}";
        }
        public virtual String GetInfo()
        {
            return $"({this.ID}) ({this.licensePlate}) {this.makeAndModel} ";
        }

        



    }
}
