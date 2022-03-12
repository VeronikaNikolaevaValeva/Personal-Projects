using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagement_AssignmentWeek12
{
    public abstract class Workshop
    {

        private int id;
        private string title;
        private string description;
        private int maxCapacity;
        private List<int> seatNumberGenerator;
        private Person teacher;
        private List<Person> listOfStudents;
        private bool workshopStarted;
        private bool workshopPassed;
        private bool ninetyPercentCapacityReached;

        public int GetID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string GetTitle
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string GetDescription
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public int GetMaxCapacity
        {
            get { return this.maxCapacity; }
            set { this.maxCapacity = value; }
        }
        public Person GetTeacher
        {
            get { return this.teacher; }
            set { this.teacher = value; }
        }

        public bool NinetyPercentCapacityReached
        {
            get { return this.ninetyPercentCapacityReached; }
            set { this.ninetyPercentCapacityReached = value; }
        }
        public bool IsWorkshopStarted
        {
            get { return this.workshopStarted; }
            set { this.workshopStarted = value; }
        }
        public bool IsWorkshopEnded
        {
            get { return this.workshopPassed; }
            set { this.workshopPassed = value; }
        }


        public List<Person> GetListOfEnrolledStudents()
        {
            return listOfStudents;
        }
        public void EnrollStudentFOrWorkshop(Person student)
        {
            if(this.GetListOfEnrolledStudents().Contains(student))
            {
                throw new ExistingPersonException();
            }
            this.listOfStudents.Add(student);
        }
        public void RemoveStudentFromWorkshop(Person student)
        {
            if (!this.GetListOfEnrolledStudents().Contains(student))
            {
                throw new PersonNotFoundException();
            }
            this.listOfStudents.Remove(student);
        }

        protected Workshop(int id, string title, string description, int maxCapacity, Person teacher)
        {
            if(teacher.GetTypeOfPerson()!= TypeOfPerson.Teacher)
            {
                throw new PersonNotFoundException();
            }
            this.GetID = id;
            this.GetTitle = title;
            this.GetDescription = description;
            this.GetTeacher = teacher;
            this.GetMaxCapacity = maxCapacity;
            this.IsWorkshopStarted = false;
            this.IsWorkshopEnded = false;
            this.listOfStudents = new List<Person>();
            this.FillListOfSeatNumbers(1);
            this.NinetyPercentCapacityReached = false;
        }

        public void FillListOfSeatNumbers(int firstSeat)
        {
            seatNumberGenerator = new List<int>();
            for (int i = firstSeat; i <= this.GetMaxCapacity; i++)
            {
                seatNumberGenerator.Add(i);
            }
        }

        public List<int> GetListOfSeatNumbers()
        {
            return this.seatNumberGenerator;
        }

        public virtual string ToString()
        {
            return $"{this.GetID} {this.title} - ({this.description}) - Teacher: {this.GetTeacher.GetNames}";
        }

        public virtual string SaveInformation()
        {
            return $"Title:{this.GetTitle}, Description:{this.GetDescription}, Teacher:{this.GetTeacher.GetNames}, Capacity:{this.GetMaxCapacity}";
        }

    }

}
