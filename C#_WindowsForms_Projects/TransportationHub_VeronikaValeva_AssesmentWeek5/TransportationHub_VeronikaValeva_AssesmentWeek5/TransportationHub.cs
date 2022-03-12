using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text.RegularExpressions;

namespace TransportationHub_VeronikaValeva_AssesmentWeek5
{
    class TransportationHub
    {
        Vehicle vehicle;
        List<Vehicle> ListOfAllVehicles;
        List<Ride> ListOfAllRides;
        private int idSeeker = 1;
        private int idRides = 101;

        public void CreateLists()
        {
            ListOfAllRides = new List<Ride>();
            ListOfAllVehicles = new List<Vehicle>();
        }

        public bool AddVehicle(int index, string BrandAndModel, string LicensePlate, double GasUsagePerKm,
            int MaxPassengers, double MaxWeight, double MaxVolume)
        {
            switch (index)
            {
                case 0:
                    ListOfAllVehicles.Add(new Car(BrandAndModel, LicensePlate, GasUsagePerKm, MaxPassengers, idSeeker));
                    idSeeker++;
                    return true;

                case 1:
                    ListOfAllVehicles.Add(new Van(BrandAndModel, LicensePlate, GasUsagePerKm, MaxPassengers, MaxWeight, MaxVolume, idSeeker));
                    idSeeker++;
                    return true;

                case 2:
                    ListOfAllVehicles.Add(new Truck(BrandAndModel, LicensePlate, GasUsagePerKm, MaxWeight, MaxVolume, idSeeker));
                    idSeeker++;
                    return true;
            }
            return true;
        }

        public bool DeleteVehicle(Vehicle v)
        {
            if (ListOfAllVehicles.Contains(v))
            {
                ListOfAllVehicles.Remove(v);
                return true;
            }
            else { return false; }
        }

        public bool AddRide(int index, int amountPassengers, double volume, double weight, double startingPrice,
            double amOfKm, DateTime startDate, DateTime endDate)
        {
            List<Vehicle> AvailableVehicles = GetAvailableVehicles();
            switch (index)
            {
                case 0:
                    if (AvailableVehicles.Any(x => x.GetType() == typeof(Car)))
                    {
                        foreach (Car car in AvailableVehicles.Where(x => x.GetType() == typeof(Car)))
                        {
                            if (car.MaxPassengers >= amountPassengers && amountPassengers != -1)
                            {
                                ListOfAllRides.Add(new Ride(idRides, car, amountPassengers, startingPrice, amOfKm, startDate, endDate));
                                idRides++;
                                car.TotalKM = amOfKm;
                                car.Available = false;
                                return true;
                            }
                        }
                    }
                    if (AvailableVehicles.Any(x => x.GetType() == typeof(Van)))
                    {
                        foreach (Van van in AvailableVehicles.Where(x => x.GetType() == typeof(Van)))
                        {
                            if (van.MaxPassengers >= amountPassengers && amountPassengers != -1)
                            {
                                ListOfAllRides.Add(new Ride(idRides, van, amountPassengers, startingPrice, amOfKm, startDate, endDate));
                                idRides++;
                                van.TotalKM = amOfKm;
                                van.Available = false;
                                return true;
                            }
                        }
                    }
                    MessageBox.Show("No vehicles available!");
                    break;
                case 1:
                    if (AvailableVehicles.Any(x => x.GetType() == typeof(Truck)))
                    {
                        foreach (Truck truck in AvailableVehicles.Where(x => x.GetType() == typeof(Truck)))
                        {
                            if (truck.MaxVolume >= volume && truck.MaxWeight >= weight && volume != -1 && weight != -1)
                            {
                                ListOfAllRides.Add(new Ride(idRides, truck, weight, volume, startingPrice, amOfKm, startDate, endDate));
                                idRides++;
                                truck.TotalKM = amOfKm;
                                truck.Available = false;
                                return true;
                            }
                        }
                    }
                    if (AvailableVehicles.Any(x => x.GetType() == typeof(Van)))
                    {
                        foreach (Van van in AvailableVehicles.Where(x => x.GetType() == typeof(Van)))
                        {
                            if (van.MaxVolume >= volume && van.MaxWeight >= weight && volume != -1 && weight != -1)
                            {
                                ListOfAllRides.Add(new Ride(idRides, van, weight, volume, startingPrice, amOfKm, startDate, endDate));
                                idRides++;
                                van.TotalKM = amOfKm;
                                van.Available = false;
                                return true;
                            }
                        }
                    }
                    MessageBox.Show("No vehicles available!");
                    break;
            }
            return false;
        }
        public List<Ride> ListOfAllCompleteRides()
        {
            List<Ride> CompletedRides = new List<Ride>();
            foreach (Ride r in ListOfAllRides)
            {
                if (r.IsItComplete)
                {
                    CompletedRides.Add(r);
                }
            }
            return CompletedRides;
        }
        public List<Ride> ListOfAllIncompleteRides()
        {
            List<Ride> IncompletedRides = new List<Ride>();
            foreach (Ride r in ListOfAllRides)
            {
                if (!r.IsItComplete)
                {
                    IncompletedRides.Add(r);
                }
            }
            return IncompletedRides;
        }

        public List<Vehicle> GetListOfAllVehicles()
        {
            return ListOfAllVehicles;
        }
        public List<Vehicle> GetAvailableVehicles()
        {
            List<Vehicle> AvailableVehicles = new List<Vehicle>();
            foreach (Vehicle v in ListOfAllVehicles)
            {
                if (v.Available)
                {
                    AvailableVehicles.Add(v);
                }
            }
            return AvailableVehicles;
        }
        public List<Vehicle> GetUnavailableVehicles()
        {
            List<Vehicle> UnavailableVehicles = new List<Vehicle>();
            foreach (Vehicle v in ListOfAllVehicles)
            {
                if (!v.Available)
                {
                    UnavailableVehicles.Add(v);
                }
            }
            return UnavailableVehicles;
        }

        public void RideTimers()
        {
            foreach (Ride r in ListOfAllRides)
            {
                if (r.GetEndDate <= DateTime.Today)
                {
                    r.IsItComplete = true;
                    r.GetUsedVehicle.Available = true;
                }
            }
        }

        //////////////////////////TextFiles
        public void WriteVehiclesToTextFile(string filename)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
                fs.Seek(0, SeekOrigin.End);
                sw = new StreamWriter(fs);

                foreach (Vehicle v in ListOfAllVehicles)
                {
                    sw.WriteLine($"{v.TextFileInfo()}");
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error writing file");
            }
            finally
            { if (sw != null) { sw.Close(); } }
        }
        public void ReadVehicleFromTextFile(string fileName)
        {
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] words = line.Split(' ');
                    if (words[0] == "Car")
                    {
                        ListOfAllVehicles.Add(new Car(words[2], words[3], Convert.ToDouble(words[4]),
                            Convert.ToInt32(words[5]), Convert.ToInt32(words[1])));

                    }
                    else if (words[0] == "Van")
                    {
                        ListOfAllVehicles.Add(new Van(words[2], words[3], Convert.ToDouble(words[4]),
                            Convert.ToInt32(words[5]), Convert.ToDouble(words[6]), Convert.ToDouble(words[7]),
                            Convert.ToInt32(words[1])));
                    }
                    else if (words[0] == "Truck")
                    {
                        ListOfAllVehicles.Add(new Truck(words[2], words[3], Convert.ToDouble(words[4]),
                            Convert.ToDouble(words[5]), Convert.ToDouble(words[6]),
                            Convert.ToInt32(words[1])));
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error reading file");
            }
            finally
            { if (sr != null) { sr.Close(); } }
        }

        public void WriteRidesToTextFile(string filename)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
                fs.Seek(0, SeekOrigin.End);
                sw = new StreamWriter(fs);

                foreach (Ride r in ListOfAllRides)
                {
                    sw.WriteLine($"{r.TextFileInfo}");
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error writing file");
            }
            finally
            { if (sw != null) { sw.Close(); } }
        }
        public void ReadRidesFromTextFile(string fileName)
        {
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] words = line.Split(' ');
                    if (words.Length == 15)  //For Rides with Passengers
                    {
                        if (ListOfAllVehicles.Any(x => x.GetLicensePlate == words[5]))
                        {
                            string startDate = $"{words[9]} + {words[10]} + {words[11]}";
                            string endDate = $"{words[12]} + {words[13]} + {words[14]}";
                            vehicle = ListOfAllVehicles.Find(x => x.GetLicensePlate == words[5]);
                            ListOfAllRides.Add(new Ride(Convert.ToInt32(words[1]), vehicle, Convert.ToInt32(words[6]), Convert.ToDouble(words[7]),
                                Convert.ToDouble(words[8]), Convert.ToDateTime(words[9]), Convert.ToDateTime(words[10])));

                        }
                        else
                        {
                            MessageBox.Show($"There is no present vehicle coresponding to ride N{Convert.ToInt32(words[1])}");
                        }
                    }
                    else if (words.Length == 16) //For rides with freighter
                    {
                        if (ListOfAllVehicles.Any(x => x.GetLicensePlate == words[5]))
                        {
                            string startDate = $"{words[11]} + {words[12]} + {words[13]}";
                            string endDate = $"{words[14]} + {words[15]} + {words[16]}";
                            vehicle = ListOfAllVehicles.Find(x => x.GetLicensePlate == words[5]);
                            ListOfAllRides.Add(new Ride(Convert.ToInt32(words[1]), vehicle, Convert.ToDouble(words[6]), Convert.ToDouble(words[7]), Convert.ToDouble(words[8]),
                                Convert.ToDouble(words[9]), Convert.ToDateTime(startDate), Convert.ToDateTime(endDate)));

                        }
                        else
                        {
                            MessageBox.Show($"There is no present vehicle coresponding to ride N{Convert.ToInt32(words[1])}");
                        }
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error reading file");
            }
            finally
            { if (sr != null) { sr.Close(); } }
        }
    }
}
