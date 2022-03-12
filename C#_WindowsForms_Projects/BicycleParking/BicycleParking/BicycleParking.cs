using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleParking
{
    public class BicycleParking
    {
        // Instance variables
        private double pricePerHour;
        private double surchargeElectricPerHour;
        Bicycle bicycle;
        List<Bicycle> bikes;
        // Properties        

        // Constructor
        public BicycleParking(double pricePerHour, double surchargeElectricPerHour)
        {
            this.pricePerHour = pricePerHour;
            this.surchargeElectricPerHour = surchargeElectricPerHour;
            bikes = new List<Bicycle>();
        }

        // Methods       
        private Bicycle GetBicycle(string ticketNumber)
        {
            foreach (Bicycle b in bikes)
            {
                if (b.TicketNumber == ticketNumber)
                {
                    return b;
                }
            }
            return null;
        }
        public string ParkBicycle(BicycleType type)
        {
            bicycle = new Bicycle(type);
            bikes.Add(bicycle);
            return bicycle.TicketNumber;
        }
        public double RetrieveBicycle(string ticketNumber, int hoursInParking, string zipcode)
        {
            double price = -1;
            Bicycle b = this.GetBicycle(ticketNumber);
            if (b.IsInParking && b != null)
            {
                b.HoursInParking = hoursInParking;
                b.OwnerZipcode = zipcode;
                b.IsInParking = false;
                switch (b.Type)
                {
                    case BicycleType.ELECTRIC:
                        price = (this.pricePerHour * bicycle.HoursInParking) + this.surchargeElectricPerHour;
                        break;
                    case BicycleType.FOLDING:
                        price = (this.pricePerHour * bicycle.HoursInParking) / 2;
                        break;
                    case BicycleType.NORMAL:
                        price = this.pricePerHour * bicycle.HoursInParking;
                        break;
                    case BicycleType.TANDEM:
                        price = (this.pricePerHour * bicycle.HoursInParking) * 2;
                        break;
                }
            }
            return price;
        }
        public Bicycle[] GetAllRetrievedBicyclesByZipcode(string partialZipcode)
        {
            List<Bicycle> RetrievedBikes = new List<Bicycle>();
            foreach (Bicycle b in this.bikes)
            {
                if (!b.IsInParking && b.OwnerZipcode.Contains(partialZipcode))
                {
                    RetrievedBikes.Add(b);
                }
            }
            return RetrievedBikes.ToArray();
        }
    }
}
