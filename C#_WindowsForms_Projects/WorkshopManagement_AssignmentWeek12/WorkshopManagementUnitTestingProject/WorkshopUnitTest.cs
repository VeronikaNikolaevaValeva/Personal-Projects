using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopManagement_AssignmentWeek12;


namespace WorkshopManagementUnitTestingProject
{
    [TestClass]
    public class WorkshopUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void FormatExceptionCreateWorkshopUnitTest()
        {
            Person t1 = new Person(123, "t1", TypeOfPerson.Teacher);
            Workshop online1 = new Online(Convert.ToInt32("one"), "online", "online workshop", Convert.ToInt32("one"), t1);
            Workshop inbuilding2 = new InBuilding(Convert.ToInt32("one"), "online", "online workshop", Convert.ToInt32("one"), t1, "addr", "room1");
        }

        [TestMethod]
        [ExpectedException(typeof(PersonNotFoundException))]
        public void TeacherExceptionCreateWorkshopUnitTest()
        {
            Person s1 = new Person(100, "s1", TypeOfPerson.Student);
            Workshop online2 = new Online(1, "online", "online workshop", 1, s1);
            Workshop inbuilding1 = new InBuilding(2, "online", "online workshop", 2, s1, "addr", "room1");
        }
        [TestMethod]
        public void CreateAndEnrollForWorkshopUnitTest()
        {
            Person t1 = new Person(123, "t1", TypeOfPerson.Teacher);
            Person s1 = new Person(100, "s1", TypeOfPerson.Student);
            Workshop online = new Online(1, "online", "online workshop", 12, t1);
            Workshop inbuilding = new InBuilding(1, "online", "online workshop", 12, t1, "addr", "room1");
            online.EnrollStudentFOrWorkshop(s1);
            inbuilding.EnrollStudentFOrWorkshop(s1);
            Assert.AreEqual(1, online.GetListOfEnrolledStudents().Count);
            Assert.AreEqual(1, inbuilding.GetListOfEnrolledStudents().Count);
            online.RemoveStudentFromWorkshop(s1);
            inbuilding.RemoveStudentFromWorkshop(s1);
            Assert.AreEqual(0, online.GetListOfEnrolledStudents().Count);
            Assert.AreEqual(0, inbuilding.GetListOfEnrolledStudents().Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ExistingPersonException))]
        public void EnrollExceptionUnitTest()
        {
            Person t1 = new Person(123, "t1", TypeOfPerson.Teacher);
            Person s1 = new Person(100, "s1", TypeOfPerson.Student);
            Workshop online = new Online(1, "online", "online workshop", 12, t1);
            Workshop inbuilding = new InBuilding(1, "online", "online workshop", 12, t1, "addr", "room1");
            online.EnrollStudentFOrWorkshop(s1);
            inbuilding.EnrollStudentFOrWorkshop(s1);
            online.EnrollStudentFOrWorkshop(s1);
            inbuilding.EnrollStudentFOrWorkshop(s1);
        }

        [TestMethod]
        [ExpectedException(typeof(PersonNotFoundException))]
        public void RemoveStudentFromWorkshopExceptionUnitTest()
        {
            Person t1 = new Person(123, "t1", TypeOfPerson.Teacher);
            Person s1 = new Person(100, "s1", TypeOfPerson.Student);
            Workshop online = new Online(1, "online", "online workshop", 12, t1);
            Workshop inbuilding = new InBuilding(1, "online", "online workshop", 12, t1, "addr", "room1");
            online.EnrollStudentFOrWorkshop(s1);
            inbuilding.EnrollStudentFOrWorkshop(s1);
            online.RemoveStudentFromWorkshop(s1);
            inbuilding.RemoveStudentFromWorkshop(s1);
            online.RemoveStudentFromWorkshop(s1);
            inbuilding.RemoveStudentFromWorkshop(s1);
        }

        [TestMethod]
        public void FillListOfSeatNumbersUnitTest()
        {
            Person t1 = new Person(123, "t1", TypeOfPerson.Teacher);
            Workshop online = new Online(1, "online", "online workshop", 12, t1);
            online.FillListOfSeatNumbers(8);
            CollectionAssert.AreEqual(new int[] { 8, 9, 10, 11, 12 }, online.GetListOfSeatNumbers());
            online.GetMaxCapacity = 5;
            online.FillListOfSeatNumbers(1);
            CollectionAssert.AreEqual(new int[] { 1,2,3,4,5 }, online.GetListOfSeatNumbers());
        }

        [TestMethod]
        public void WorkshopInfoUnitTest()
        {
            Person t1 = new Person(123, "t1", TypeOfPerson.Teacher);
            Workshop online = new Online(1, "online", "online workshop", 12, t1);
            Workshop inbuilding = new InBuilding(3, "inbuilding", "inbuilding workshop", 12, t1, "addr", "room1");
            string onlineInfo = "1 online - (online workshop) - Teacher: t1 (Online)";
            string inbuildingInfo = "3 inbuilding - (inbuilding workshop) - Teacher: t1 (InBuilding)";
            string onlineURL = "http://www.online.nl";
            string onlineSaveInfo = "ONLINE(Title:online, Description:online workshop, Teacher:t1, Capacity:12, URL:http://www.online.nl)";
            string inbuildingSaveInfo = "INBUILDING(Title:inbuilding, Description:inbuilding workshop, Teacher:t1, Capacity:12, Location:addr room1)";
            Assert.AreEqual(onlineURL, ((Online)online).GetUrl);
            Assert.AreEqual(online.ToString(), onlineInfo);
            Assert.AreEqual(inbuilding.ToString(), inbuildingInfo);
            Assert.AreEqual(inbuilding.SaveInformation(), inbuildingSaveInfo);
            Assert.AreEqual(online.SaveInformation(), onlineSaveInfo);

        }
    }
}
