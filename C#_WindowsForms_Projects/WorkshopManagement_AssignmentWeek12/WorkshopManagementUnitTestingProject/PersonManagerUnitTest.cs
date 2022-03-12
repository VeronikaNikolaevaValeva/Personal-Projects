using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopManagement_AssignmentWeek12;

namespace WorkshopManagementUnitTestingProject
{
    [TestClass]
    public class PersonManagerUnitTest
    {
        [TestMethod]
        public void SetListOfPeopleUnitTest()
        {
            PersonManager personManager = new PersonManager();
            List<Person> listOfPeople = new List<Person>();
            personManager.SetListOfPeople = new List<Person>();
            CollectionAssert.AreEqual(listOfPeople, personManager.GetListOfPeople());
        }

        [TestMethod]

        public void FindPersonExceptionUnitTest()
        {
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();

            Assert.AreEqual(null, personManager.FindPerson(4090349));
        }

        [TestMethod]
        public void FindPersonUnitTest()
        {
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();

            Person newPerson = new Person(4090349, "Veronika Valeva", TypeOfPerson.Student);
            personManager.AddPerson(4090349, "Veronika Valeva", TypeOfPerson.Student);
            Person testPerson = personManager.FindPerson(4090349);

            Assert.AreEqual(newPerson.GetPCN, testPerson.GetPCN);
        }

        [TestMethod]
        public void AddPersonUnitTest()
        {
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();

            Person newPerson = new Person(4090349, "Veronika Valeva", TypeOfPerson.Student);
            personManager.AddPerson(4090349, "Veronika Valeva", TypeOfPerson.Student);
            Person testPerson = personManager.GetListOfPeople()[0];

            Assert.AreEqual(newPerson.GetPCN, testPerson.GetPCN);
        }

        [TestMethod]
        [ExpectedException(typeof(ExistingPersonException))]
        public void CheckIfPersonExistsUnitTest()
        {
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();

            personManager.AddPerson(4090349, "Veronika Valeva", TypeOfPerson.Student);
            personManager.CheckIfPersonExists(4090349);
        }

        [TestMethod]
        public void GetTypeOfPersonUnitTest()
        {
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();

            Person newPerson = new Person(4090349, "Veronika Valeva", TypeOfPerson.Student);
            TypeOfPerson testTypeOfPerson = personManager.GetTypeOfPerson(newPerson);

            Assert.AreEqual(testTypeOfPerson, TypeOfPerson.Student);
        }

        [TestMethod]
        public void GetPersonInformationUnitTest() //Names, PCN, Info
        {
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();
            Person newPerson = new Person(4090349, "Veronika Valeva", TypeOfPerson.Student);

            string testNames = personManager.GetPersonNames(newPerson);
            int testPCN = personManager.GetPersonPCN(newPerson);
            string testPersonInfo = personManager.GetPersonInfo(newPerson);

            Assert.AreEqual(testPCN, 4090349);
            Assert.AreEqual(testNames, "Veronika Valeva");
            Assert.AreEqual(testPersonInfo, "4090349 Veronika Valeva (Student)");

        }

        [TestMethod]
        public void GetListOfAllPeopleByTypeOfPersonUnitTest()
        {
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();

            Person s1 = new Person(1, "1", TypeOfPerson.Student);
            Person t2 = new Person(4, "4", TypeOfPerson.Teacher);

            personManager.AddPerson(1, "1", TypeOfPerson.Student);
            personManager.AddPerson(4, "4", TypeOfPerson.Teacher);

            Assert.AreEqual(s1.GetPCN, personManager.GetListOfAllPeople(TypeOfPerson.Student)[0].GetPCN);
            Assert.AreEqual(t2.GetPCN, personManager.GetListOfAllPeople(TypeOfPerson.Teacher)[0].GetPCN);
        }

        [TestMethod]
        public void EditPersonInfoUnitTest()
        {
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();
            Person newPerson = new Person(4090349, "Veronika Valeva", TypeOfPerson.Student);
            personManager.AddPerson(1, "Viktoria Petrova", TypeOfPerson.Teacher);

            personManager.EditPersonInfo(1, 4090349, "Veronika Valeva", TypeOfPerson.Student);

            Assert.AreEqual(newPerson.GetPCN, personManager.FindPerson(4090349).GetPCN);
            Assert.AreEqual(newPerson.GetNames, personManager.FindPerson(4090349).GetNames);
            Assert.AreEqual(newPerson.GetTypeOfPerson(), personManager.FindPerson(4090349).GetTypeOfPerson());
        }

        [TestMethod]
        public void RemovePersonUnitTest()
        {
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();
            personManager.AddPerson(4090349, "Veronika Valeva", TypeOfPerson.Student);

            personManager.RemovePerson(4090349);
            Assert.AreEqual(null, personManager.FindPerson(4090349));
        }


        [TestMethod]
        public void SetLoginCodeUnitTest()
        {
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();
            personManager.AddPerson(4090349, "Veronika Valeva", TypeOfPerson.Student);

            personManager.SetLoginCode(personManager.FindPerson(4090349), "workshopTitle");
            Assert.AreEqual("Login code: workshopTitle-4090349", personManager.FindPerson(4090349).GetLoginCode);
        }

        [TestMethod]
        public void SetSeatNumberUnitTest()
        {
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();
            personManager.AddPerson(4090349, "Veronika Valeva", TypeOfPerson.Student);

            personManager.SetSeatNumber(personManager.FindPerson(4090349), 2);
            Assert.AreEqual(2, personManager.GetStudentSeatnumber(personManager.FindPerson(4090349)));
        }
    }
}
