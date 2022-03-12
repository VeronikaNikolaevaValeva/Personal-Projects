using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopManagement_AssignmentWeek12;

namespace WorkshopManagementUnitTestingProject
{
    [TestClass]
    public class PersonUnitTest
    {
        [TestMethod]
        public void PersonConstructorUnitTest()
        {
            Person testStudent = new Person(4090349, "Veronika Valeva", TypeOfPerson.Student);
            Person testTeacher = new Person(4090340, "Teacher", TypeOfPerson.Teacher);

            Assert.AreEqual(testStudent.GetNames, "Veronika Valeva");
            Assert.AreEqual(testTeacher.GetNames, "Teacher");
            Assert.AreEqual(testStudent.GetPCN, 4090349);
            Assert.AreEqual(testTeacher.GetPCN, 4090340);
            Assert.AreEqual(testStudent.GetTypeOfPerson(), TypeOfPerson.Student);
            Assert.AreEqual(testTeacher.GetTypeOfPerson(), TypeOfPerson.Teacher);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void WrongPersonConstructorUnitTest()
        {
            Person testStudent = new Person(Convert.ToInt32("text"), "Veronika Valeva", TypeOfPerson.Student);
            Person testTeacher = new Person(Convert.ToInt32("text"), "Teacher", TypeOfPerson.Teacher);
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void WrongPersonTypeOfPersonUnitTest()
        {
            Person testPerson = new Person(4090349, "Veronika Valeva", TypeOfPerson.Teacher);
            testPerson.SetTypeOfPerson = (TypeOfPerson)(Convert.ToInt32("text"));
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void SeatNumberANdLoginCodeUnitTest()
        {
            Person testPerson = new Person(4090349, "Veronika Valeva", TypeOfPerson.Student);
            testPerson.GetLoginCode = "login";
            Assert.AreEqual(testPerson.GetLoginCode, "login");
            testPerson.GetSeatNumber = Convert.ToInt32("one");
        }

        [TestMethod]
        public void PersonInformationUnitTest()
        {
            Person testStudent = new Person(4090349, "Veronika Valeva", TypeOfPerson.Student);
            Person testTeacher = new Person(4090340, "Teacher", TypeOfPerson.Teacher);
            Assert.AreEqual(testTeacher.ToString(), "4090340 Teacher (Teacher)");
            Assert.AreEqual(testStudent.ToString(), "4090349 Veronika Valeva (Student)");
        }

    }
}
