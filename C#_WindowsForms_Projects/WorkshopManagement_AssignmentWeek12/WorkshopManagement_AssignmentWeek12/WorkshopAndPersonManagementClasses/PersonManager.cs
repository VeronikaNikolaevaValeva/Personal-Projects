using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagement_AssignmentWeek12
{
    public class PersonManager
    {
        private List<Person> listOfAllPeople;
        public PersonManager()
        {

        }

        public List<Person> SetListOfPeople
        {
            set { this.listOfAllPeople = value; }
        }

        public void CheckIfPersonExists(int pcn)
        {
            if (FindPerson(pcn) != null)
            {
                throw new ExistingPersonException();
            }
        }

        public TypeOfPerson GetTypeOfPerson(Person person)
        {
            return person.GetTypeOfPerson();
        }

        public string GetPersonNames(Person person)
        {
            return person.GetNames;
        }
        public int GetPersonPCN(Person person)
        {
            return person.GetPCN;
        }

        public string GetPersonInfo(Person person)
        {
            return person.ToString();
        }
        public void AddPerson(int pcn, string names, TypeOfPerson typeOfPerson)
        {
            CheckIfPersonExists(pcn);
            listOfAllPeople.Add(new Person(pcn, names, typeOfPerson));
        }

        public List<Person> GetListOfAllPeople(TypeOfPerson typeOfPerson)
        {
            List<Person> ListOfPeople = new List<Person>();
            foreach (Person person in listOfAllPeople)
            {
                if (person.GetTypeOfPerson() == typeOfPerson)
                {
                    ListOfPeople.Add(person);
                }

            }
            return ListOfPeople;
        }
        public List<Person> GetListOfPeople()
        {
            return listOfAllPeople;
        }

        public void EditPersonInfo(int pcn, int newPCN, string names, TypeOfPerson typeOfPerson)
        {
            if (pcn != newPCN)
            {
                CheckIfPersonExists(newPCN);
            }
            FindPerson(pcn).GetPCN = newPCN;
            FindPerson(newPCN).GetNames = names;
            FindPerson(newPCN).SetTypeOfPerson = typeOfPerson;
        }


        public bool RemovePerson(int pcn)
        {
            if (FindPerson(pcn) != null)
            {
                listOfAllPeople.Remove(FindPerson(pcn));
                return true;
            }
            return false;
        }

        public Person FindPerson(int pcn)
        {
            foreach (Person person in listOfAllPeople)
            {
                if (person.GetPCN == pcn)
                {
                    return person;
                }
            }
            return null;
        }
        public void SetLoginCode(Person student, string workshopTitle)
        {
            student.GetLoginCode = $"Login code: {workshopTitle}-{student.GetPCN}";
        }

        public void SetSeatNumber(Person student, int num)
        {
            student.GetSeatNumber = num;
        }
        public int GetStudentSeatnumber(Person student)
        {
            return Convert.ToInt32(student.GetSeatNumber);
        }
        public string GetStudentLoginSeatNumber(Workshop workshop, Person student)
        {
            if (workshop.GetType() == typeof(InBuilding))
            {
                return $"{student.GetPCN} {student.GetNames}, Seat number: {student.GetSeatNumber.ToString()}";
            }
            return $"{student.GetPCN} {student.GetNames}, {student.GetLoginCode}";
        }


    }
}
