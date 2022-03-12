using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TransportationHub_VeronikaValeva_AssesmentWeek5
{
    class Ride
    {
        Vehicle vehicle;
        private int id;
        private int amountOfPersons;
        private double volumeOfCargoInM3;
        private double weightOfTheCargoInKG;
        private double startingPrice;
        private double kilometers;
        private DateTime startingTime;
        private DateTime endTime;
        private bool complete;

        public double FinalPriceOfTheRide
        {
            get { return (this.vehicle.PricePerKM * this.kilometers) + this.startingPrice; }
        }
        public DateTime GetStartingDate
        {
            get { return this.startingTime; }
        }
        public DateTime GetEndDate
        {
            get { return this.endTime; }
        }
        public double GetKilometers
        {
            get { return this.kilometers; }
        }
        public int AmountOfPassengers
        {
            get { return this.amountOfPersons; }
        }
        public Vehicle GetUsedVehicle
        {
            get { return this.vehicle; }
        }
        public bool IsItComplete
        {
            set { this.complete = value; }
            get { return this.complete; }
        }
        public string GetCargoInfo
        {
            get
            {
                if(this.vehicle is Car)
                { return $"passengers: {this.amountOfPersons}"; }
                else if(this.vehicle is Van)
                { return $"passengers: {this.amountOfPersons}, weight of cargo: {this.weightOfTheCargoInKG}," +
                        $" volume of cargo: {this.volumeOfCargoInM3}"; }
                else if(this.vehicle is Truck)
                { return $"weight of cargo: {this.weightOfTheCargoInKG}, volume of cargo: {this.volumeOfCargoInM3}"; }
                return "No information given";
            }
        }
       public Ride(int id, Vehicle v,  int amountPassengers, double StartingPrice, double amountOfKm, 
           DateTime startDate, DateTime endDate)
        {
           
            this.id = id;
            this.vehicle = v;
            this.amountOfPersons = amountPassengers;
            this.startingPrice =StartingPrice;
            this.kilometers = amountOfKm;
            this.startingTime = startDate;
            this.endTime = endDate;
            this.complete = false;
        }
        public Ride(int id, Vehicle v, double weight, double volume, double StartingPrice, double amountOfKm, 
           DateTime startDate, DateTime endDate)
        {
            
            this.id = id;
            this.vehicle = v;
            this.startingPrice = StartingPrice;
            this.kilometers = amountOfKm;
            this.startingTime = startDate;
            this.endTime = endDate;
            this.weightOfTheCargoInKG = weight;
            this.volumeOfCargoInM3 = volume;
            this.complete = false;
        }
        public string TextFileInfo
        {
            get { return $"\r\n Ride {this.id} (complete:) {this.IsItComplete} {vehicle.BrandAndModel} {vehicle.GetLicensePlate} " +
                    $"{GetRideType} {this.startingPrice} {this.kilometers} {this.startingTime} {this.endTime}"; }
        }
        public string GetRideType //For TextFileInfo
        {
            get { if(this.vehicle !=null)
                { return $"{this.AmountOfPassengers}"; }
                else { return $"{this.weightOfTheCargoInKG} {this.volumeOfCargoInM3}"; }
                }
        }
        public string GetRideInfo
        {
            get { return $"\r\n Ride N{this.id} - {GetCargoInfo} \r\n {this.startingTime} - {this.endTime}" +
                $"\r\n Starting price: {this.startingPrice:F2} / Final price: {this.FinalPriceOfTheRide:F2}. \r\n" +
                $"Transported with: {this.vehicle.GetInfo()} "; }
        }

        

    }
}
