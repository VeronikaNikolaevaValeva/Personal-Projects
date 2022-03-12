using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagement_AssignmentWeek12
{
    public class WorkshopManager
    {
        private List<Workshop> listOfALlWorkshops;
        PersonManager personManager;
        public delegate void WorshopHandler(Workshop workshop);
        private event WorshopHandler newWorkshopAdded;
        public delegate void WorshopCapacityHandler(Workshop workshop);
        private event WorshopCapacityHandler workshopCapacityReached;
        IWorkshopDAL workshopDAL;
        int workshopID = 1;
        public WorkshopManager()
        {
            listOfALlWorkshops = new List<Workshop>();
        }
        public void SetObjectReference()
        {
            personManager = new PersonManager();
        }
        public void CreateOnlineWorkshop(string title, string description, int maxCapacity, Person teacher)
        {
            listOfALlWorkshops.Add(new Online(workshopID, title, description, maxCapacity, teacher));
            this.NotifyNewWorkshopAdded(FindWorkshopByID(workshopID));
            workshopID++;
        }
        public void CreateInBuildingWorkshop(string title, string description, int maxCapacity, Person teacher, string address, string roomNumber)
        {
            listOfALlWorkshops.Add(new InBuilding(workshopID, title, description, maxCapacity, teacher, address, roomNumber));
            this.NotifyNewWorkshopAdded(FindWorkshopByID(workshopID));
            workshopID++;
        }

        public void NotifyNewWorkshopAdded(Workshop workshop)
        {
            WorshopHandler wr = this.newWorkshopAdded;

            if (wr != null)
            { wr(workshop); }
        }
        public void NotifyWorkshopCapacityReached(Workshop workshop)
        {
            WorshopCapacityHandler wr = this.workshopCapacityReached;

            if (wr != null)
            { wr(workshop); }
        }

        public void AddWorkshopSubscriber(WorshopHandler wr)
        {
            this.newWorkshopAdded += wr;
        }
        public void AddWorkshopCapacitySubscriber(WorshopCapacityHandler wr)
        {
            this.workshopCapacityReached += wr;
        }

        public int GetWorkshopID(Workshop workshop)
        {
            return workshop.GetID;
        }

        public string GetWorkshopTitle(Workshop workshop)
        {
            return workshop.GetTitle;
        }

        public string GetWorkshopDescription(Workshop workshop)
        {
            return workshop.GetDescription;
        }

        public int GetWorkshopMaxCapacity(Workshop workshop)
        {
            return workshop.GetMaxCapacity;
        }

        public Person GetWorkshopTeacher(Workshop workshop)
        {
            return workshop.GetTeacher;
        }

        public string GetWorkshopInfo(Workshop workshop)
        {
            return workshop.ToString();
        }

        public List<Person> ListOfEnrolledStudents(Workshop workshop)
        {
            return workshop.GetListOfEnrolledStudents();
        }

        public Workshop FindWorkshopByID(int id)
        {
            foreach (Workshop workshop in listOfALlWorkshops)
            {
                if (workshop.GetID == id)
                {
                    return workshop;
                }
            }
            return null;
        }

        public Workshop FindWorkshopByTeacher(int teacherPCN)
        {
            foreach (Workshop workshop in listOfALlWorkshops)
            {
                if (workshop.GetTeacher.GetPCN == teacherPCN)
                {
                    return workshop;
                }
            }
            return null;
        }

        public bool CheckWorkshopTeacherInfo(int teacherPCN)
        {
            foreach (Workshop workshop in listOfALlWorkshops)
            {
                if (workshop.GetTeacher.GetPCN == teacherPCN && workshop.IsWorkshopStarted == false)
                {
                    return true;
                }
            }
            return false;
        }

        public void EditOnlineWorkshopInfo(Workshop workshop, string title, string description, int maxCapacity, Person teacher)
        {
            if (!this.listOfALlWorkshops.Contains(workshop))
            {
                throw new WorkshopNotFoundException();
            }
            workshop.GetTitle = title;
            workshop.GetDescription = description;
            workshop.GetTeacher = teacher;
            if (workshop.GetListOfEnrolledStudents().Count > maxCapacity)
            {
                throw new WorkshopCapacityException();
            }
            else
            {
                workshop.GetMaxCapacity = maxCapacity;
            }
            foreach (Person student in workshop.GetListOfEnrolledStudents())
            {
                SetLoginSeatNumForStudents(student, workshop);
            }

        }
        public void EditInBuildingWorkshopInfo(Workshop workshop, string title, string description, int maxCapacity, Person teacher, string address, string roomNumber)
        {
            if (!this.listOfALlWorkshops.Contains(workshop))
            {
                throw new WorkshopNotFoundException();
            }
            workshop.GetTitle = title;
            workshop.GetDescription = description;
            if (workshop.GetListOfEnrolledStudents().Count > maxCapacity)
            {
                throw new WorkshopCapacityException();
            }
            else if (workshop.GetMaxCapacity > maxCapacity)
            {
                workshop.GetMaxCapacity = maxCapacity;
                workshop.FillListOfSeatNumbers(workshop.GetListOfEnrolledStudents().Count + 1);

            }
            workshop.GetTeacher = teacher;
            ((InBuilding)workshop).GetAddress = address;
            ((InBuilding)workshop).GetRoomNumber = roomNumber;
        }

        public void RemoveWorkshop(Workshop workshop)
        {
            if (listOfALlWorkshops.Contains(workshop))
            {
                workshop.IsWorkshopStarted = true;
                listOfALlWorkshops.Remove(workshop);
            }
            else { throw new WorkshopNotFoundException(); }
        }

        public void RemoveStudentFromWorkshop(Workshop workshop, Person student)
        {
            if (workshop.GetListOfEnrolledStudents().Contains(student))
            {
                workshop.GetListOfSeatNumbers().Add(personManager.GetStudentSeatnumber(student));
                workshop.RemoveStudentFromWorkshop(student);
                CheckWorkshopCapacity(workshop);
            }
            else { throw new PersonNotFoundException(); }

        }
        public List<Workshop> GetAvailableWorkshops()
        {
            List<Workshop> AvailableWorkshops = new List<Workshop>();
            foreach (Workshop workshop in listOfALlWorkshops.Where(x => x.IsWorkshopStarted == false))
            {
                AvailableWorkshops.Add(workshop);
            }
            return AvailableWorkshops;
        }

        public List<Workshop> GetAllWorkshops()
        {
            return listOfALlWorkshops;
        }


        public void CheckWorkshopCapacity(Workshop workshop)    //Check if 90% capacity's reached
        {
            if ((workshop.GetListOfEnrolledStudents().Count * 100) >= (workshop.GetMaxCapacity * 90))
            {
                workshop.NinetyPercentCapacityReached = true;
                this.NotifyWorkshopCapacityReached(workshop);
            }
            else { workshop.NinetyPercentCapacityReached = false; }
        }

        public void EnrollForWorkshop(Person student, Workshop workshop)
        {
            if (workshop.GetListOfEnrolledStudents().Contains(student))
            {
                throw new ExistingPersonException();
            }
            if (workshop.GetListOfEnrolledStudents().Count == workshop.GetMaxCapacity)
            {
                throw new WorkshopCapacityReachedException();
            }
            workshop.EnrollStudentFOrWorkshop(student);
            SetLoginSeatNumForStudents(student, workshop);
            CheckWorkshopCapacity(workshop);
        }

        public void SetLoginSeatNumForStudents(Person student, Workshop workshop)
        {
            if (!workshop.GetListOfEnrolledStudents().Contains(student))
            {
                throw new PersonNotFoundException();
            }
            else if (workshop.GetType() == typeof(InBuilding))
            {
                for (int i = 0; i < workshop.GetMaxCapacity; i++)
                {
                    if (i == workshop.GetListOfEnrolledStudents().Count)
                    {
                        break;
                    }
                    personManager.SetSeatNumber(workshop.GetListOfEnrolledStudents()[i], (i + 1));
                }
            }
            else if (workshop.GetType() == typeof(Online))
            {
                personManager.SetLoginCode(student, workshop.GetTitle);
            }
        }

        public void StartWorkshop(Workshop workshop)
        {
            if (this.GetAvailableWorkshops().Contains(workshop))
            {
                workshop.IsWorkshopStarted = true;
            }
            else { throw new WorkshopNotFoundException(); }
        }

        public void EndWorkshop(Workshop workshop)
        {
            if (this.GetAllWorkshops().Contains(workshop) && workshop.IsWorkshopStarted == true && workshop.IsWorkshopEnded == false)
            {
                workshop.IsWorkshopEnded = true;
            }
            else { throw new WorkshopNotFoundException(); }

        }

        public void SaveInformationToTextFile(string filename)
        {
            workshopDAL = new WorkshopDAL();
            workshopDAL.WriteWorkshopsToTextFile(this.GetAvailableWorkshops(), filename);
        }
    }
}
