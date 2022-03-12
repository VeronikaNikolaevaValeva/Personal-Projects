using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopManagement_AssignmentWeek12;

namespace WorkshopManagementUnitTestingProject
{
    [TestClass]
    public class WorkshopManagerUnitTest
    {
        [TestMethod]
        public void WorkshopManagerConstructorUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Assert.AreEqual(0, workshopManager.GetAllWorkshops().Count);
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void CreateOnlineWorkshopUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Person teacher = new Person(1, "teacher", TypeOfPerson.Teacher);
            workshopManager.CreateOnlineWorkshop("Online workshop", "This is online workshop", 15, teacher);
            Assert.AreEqual(1, workshopManager.GetAllWorkshops().Count);
            Assert.AreEqual("Online workshop", workshopManager.GetAllWorkshops()[0].GetTitle);
            Assert.AreEqual("This is online workshop", workshopManager.GetAllWorkshops()[0].GetDescription);
            Assert.AreEqual("teacher", workshopManager.GetAllWorkshops()[0].GetTeacher.GetNames);
            Assert.AreEqual(15, workshopManager.GetAllWorkshops()[0].GetMaxCapacity);
            workshopManager.CreateOnlineWorkshop("Online workshop", "This is online workshop", Convert.ToInt32("one"), teacher);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void CreateInBuildingWorkshopUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Person teacher = new Person(1, "teacher", TypeOfPerson.Teacher);
            workshopManager.CreateInBuildingWorkshop("InBuilding workshop", "This is inbuilding workshop", 15, teacher, "str1", "10");
            Assert.AreEqual(1, workshopManager.GetAllWorkshops().Count);
            Assert.AreEqual("InBuilding workshop", workshopManager.GetAllWorkshops()[0].GetTitle);
            Assert.AreEqual("This is inbuilding workshop", workshopManager.GetAllWorkshops()[0].GetDescription);
            Assert.AreEqual("teacher", workshopManager.GetAllWorkshops()[0].GetTeacher.GetNames);
            Assert.AreEqual(15, workshopManager.GetAllWorkshops()[0].GetMaxCapacity);
            Assert.AreEqual("str1", ((InBuilding)workshopManager.GetAllWorkshops()[0]).GetAddress);
            Assert.AreEqual("10", ((InBuilding)workshopManager.GetAllWorkshops()[0]).GetRoomNumber);
            workshopManager.CreateInBuildingWorkshop("InBuilding workshop", "This is online workshop", Convert.ToInt32("one"), teacher, "address", "10");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotifyNewWorkshopAddedUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Person teacher = new Person(1, "teacher", TypeOfPerson.Teacher);
            Workshop workshop = new Online(1, "online", "desc", 2, teacher);
            workshopManager.AddWorkshopSubscriber(this.WorkshopUpdate);
            workshopManager.NotifyNewWorkshopAdded(workshop);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotifyWorkshopCapacityUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Person teacher = new Person(1, "teacher", TypeOfPerson.Teacher);
            Workshop workshop = new Online(1, "online", "desc", 2, teacher);
            workshopManager.AddWorkshopCapacitySubscriber(this.WorkshopUpdate);
            workshopManager.NotifyWorkshopCapacityReached(workshop);
        }
        public void WorkshopUpdate(Workshop w)
        {
            throw new FormatException();
        }

        [TestMethod]
        public void WorkshopInfoUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Person teacher = new Person(1, "teacher", TypeOfPerson.Teacher);
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, teacher);
            Workshop workshop = workshopManager.FindWorkshopByID(1);
            Assert.AreEqual(1, workshopManager.GetWorkshopID(workshop));
            Assert.AreEqual("online", workshopManager.GetWorkshopTitle(workshop));
            Assert.AreEqual("teacher", workshopManager.GetWorkshopTeacher(workshop).GetNames);
            Assert.AreEqual("desc", workshopManager.GetWorkshopDescription(workshop));
            Assert.AreEqual(2, workshopManager.GetWorkshopMaxCapacity(workshop));
            Assert.AreEqual("1 online - (desc) - Teacher: teacher (Online)", workshopManager.GetWorkshopInfo(workshop));

        }
        [TestMethod]
        public void FindWorkshopByIDUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Person teacher = new Person(1, "teacher", TypeOfPerson.Teacher);
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, teacher);
            Assert.AreEqual(null, workshopManager.FindWorkshopByID(2));
            Assert.AreEqual(1, workshopManager.FindWorkshopByTeacher(1).GetID);
            Assert.AreEqual(null, workshopManager.FindWorkshopByTeacher(2));
        }

        [TestMethod]
        public void CheckWorkshopTeacherInfoTrueUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Person teacher = new Person(1, "teacher", TypeOfPerson.Teacher);
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, teacher);
            Workshop w1 = workshopManager.FindWorkshopByID(1);
            Assert.AreEqual(true, workshopManager.CheckWorkshopTeacherInfo(1));
        }
        [TestMethod]
        public void CheckWorkshopTeacherInfofalseUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Person teacher = new Person(1, "teacher", TypeOfPerson.Teacher);
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, teacher);
            Workshop w1 = workshopManager.FindWorkshopByID(1);
            w1.IsWorkshopStarted = true;
            Assert.AreEqual(false, workshopManager.CheckWorkshopTeacherInfo(1));
        }

        [TestMethod]
        public void EditOnlineWorkshopInfoUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Person teacher = new Person(1, "teacher", TypeOfPerson.Teacher);
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, teacher);
            Workshop w1 = workshopManager.FindWorkshopByID(1);
            workshopManager.EditOnlineWorkshopInfo(w1, "title", "desc", 3, teacher);
        }
        [TestMethod]
        [ExpectedException(typeof(WorkshopNotFoundException))]
        public void ExceptionNotFoundEditOnlineWorkshopInfoUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Person teacher = new Person(1, "teacher", TypeOfPerson.Teacher);
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, teacher);
            Workshop w1 = workshopManager.FindWorkshopByID(1);
            workshopManager.RemoveWorkshop(w1);
            workshopManager.EditOnlineWorkshopInfo(w1, "title", "desc", 3, teacher);
        }

        [TestMethod]
        [ExpectedException(typeof(WorkshopNotFoundException))]
        public void ExceptionNotFoundEditInBuildingWorkshopInfoUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Person teacher = new Person(1, "teacher", TypeOfPerson.Teacher);
            workshopManager.CreateInBuildingWorkshop("online", "desc", 2, teacher, "address", "room10");
            Workshop w1 = workshopManager.FindWorkshopByID(1);
            workshopManager.RemoveWorkshop(w1);
            workshopManager.EditInBuildingWorkshopInfo(w1, "title", "desc", 3, teacher, "addr", "room1");
        }


        [TestMethod]
        public void ListOfEnrolledStudentsExceptionEditOnlineWorkshopInfoUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            workshopManager.SetObjectReference();
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();

            personManager.AddPerson(1, "t1", TypeOfPerson.Teacher);
            personManager.AddPerson(2, "s1", TypeOfPerson.Student);
            Person t1 = personManager.FindPerson(1);
            Person s1 = personManager.FindPerson(2);

            workshopManager.CreateOnlineWorkshop("online", "desc", 2, t1);
            Workshop w1 = workshopManager.FindWorkshopByID(1);

            workshopManager.EnrollForWorkshop(s1, w1);
            CollectionAssert.AreEqual(new Person[] { s1 }, workshopManager.ListOfEnrolledStudents(w1));
        }


        [TestMethod]
        [ExpectedException(typeof(WorkshopCapacityException))]
        public void ExceptionCapacityEditOnlineWorkshopInfoUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            workshopManager.SetObjectReference();
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();

            personManager.AddPerson(1, "t1", TypeOfPerson.Teacher);
            personManager.AddPerson(2, "s1", TypeOfPerson.Student);
            personManager.AddPerson(3, "s2", TypeOfPerson.Student);
            Person t1 = personManager.FindPerson(1);
            Person s1 = personManager.FindPerson(2);
            Person s2 = personManager.FindPerson(3);

            workshopManager.CreateOnlineWorkshop("online", "desc", 2, t1);
            Workshop w1 = workshopManager.FindWorkshopByID(1);

            workshopManager.EnrollForWorkshop(s1, w1);
            workshopManager.EnrollForWorkshop(s2, w1);

            workshopManager.EditOnlineWorkshopInfo(w1, "online", "desc", 1, t1);
        }

        [TestMethod]
        [ExpectedException(typeof(WorkshopCapacityException))]
        public void ExceptionEditInBuildingWorkshopInfoUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            workshopManager.SetObjectReference();
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();

            personManager.AddPerson(1, "t1", TypeOfPerson.Teacher);
            personManager.AddPerson(11, "t2", TypeOfPerson.Teacher);
            personManager.AddPerson(2, "s1", TypeOfPerson.Student);
            personManager.AddPerson(3, "s2", TypeOfPerson.Student);
            Person t1 = personManager.FindPerson(1);
            Person t2 = personManager.FindPerson(11);
            Person s1 = personManager.FindPerson(2);
            Person s2 = personManager.FindPerson(3);

            workshopManager.CreateInBuildingWorkshop("inbuilding", "desc", 2, t1, "addr", "roomNumber");
            Workshop w1 = workshopManager.FindWorkshopByID(1);

            workshopManager.EnrollForWorkshop(s1, w1);
            workshopManager.EnrollForWorkshop(s2, w1);

            workshopManager.EditInBuildingWorkshopInfo(w1, "title", "description", 2, t2, "address", "room10");
            Assert.AreEqual("1 title - (description) - Teacher: t2 (InBuilding)", workshopManager.GetWorkshopInfo(w1));
            Assert.AreEqual("address", ((InBuilding)w1).GetAddress);
            Assert.AreEqual("room10", ((InBuilding)w1).GetRoomNumber);
            workshopManager.EditInBuildingWorkshopInfo(w1, "inbuilding", "desc", 1, t1, "address", "room10");
        }

        [TestMethod]
        [ExpectedException(typeof(WorkshopNotFoundException))]
        public void RemoveWorkshopUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            workshopManager.SetObjectReference();
            Person t1 = new Person(1, "t1", TypeOfPerson.Teacher);

            workshopManager.CreateInBuildingWorkshop("inbuilding", "desc", 2, t1, "addr", "roomNumber");
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, t1);
            Workshop w1 = workshopManager.FindWorkshopByID(1);
            Workshop w2 = workshopManager.FindWorkshopByID(2);
            Workshop w3 = new Online(3, "fakeWorkshop", "fakeDesc", 0, t1);

            Assert.AreEqual(2, workshopManager.GetAllWorkshops().Count);
            workshopManager.RemoveWorkshop(w1);
            workshopManager.RemoveWorkshop(w2);
            Assert.AreEqual(0, workshopManager.GetAllWorkshops().Count);
            workshopManager.RemoveWorkshop(w3);
        }

        [TestMethod]
        [ExpectedException(typeof(PersonNotFoundException))]
        public void RemoveStudentFromWorkshopUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            workshopManager.SetObjectReference();
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();

            personManager.AddPerson(1, "t1", TypeOfPerson.Teacher);
            personManager.AddPerson(2, "s1", TypeOfPerson.Student);
            personManager.AddPerson(3, "s2", TypeOfPerson.Student);
            Person t1 = personManager.FindPerson(1);
            Person s1 = personManager.FindPerson(2);
            Person s2 = personManager.FindPerson(3);

            workshopManager.CreateInBuildingWorkshop("inbuilding", "desc", 2, t1, "addr", "roomNumber");
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, t1);
            Workshop w1 = workshopManager.FindWorkshopByID(1);
            Workshop w2 = workshopManager.FindWorkshopByID(2);

            workshopManager.EnrollForWorkshop(s1, w1);
            workshopManager.EnrollForWorkshop(s1, w2);
            workshopManager.RemoveStudentFromWorkshop(w1, s1);
            workshopManager.RemoveStudentFromWorkshop(w1, s2);
        }
        [TestMethod]
        public void GetAllAvailableWorkshopsUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            workshopManager.SetObjectReference();
            Person t1 = new Person(1, "t1", TypeOfPerson.Teacher);

            workshopManager.CreateInBuildingWorkshop("inbuilding", "desc", 2, t1, "addr", "roomNumber");
            workshopManager.CreateInBuildingWorkshop("inbuilding", "desc", 2, t1, "addr", "roomNumber");
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, t1);
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, t1);
            Workshop w1 = workshopManager.FindWorkshopByID(1);
            Workshop w2 = workshopManager.FindWorkshopByID(2);
            Workshop w3 = workshopManager.FindWorkshopByID(3);
            Workshop w4 = workshopManager.FindWorkshopByID(4);
            w2.IsWorkshopStarted = true;
            w4.IsWorkshopStarted = true;
            Assert.AreEqual(2, workshopManager.GetAvailableWorkshops().Count);
            Assert.AreEqual(4, workshopManager.GetAllWorkshops().Count);
        }
        [TestMethod]
        [ExpectedException(typeof(WorkshopCapacityReachedException))]
        public void NineTyPercentCapacityUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            workshopManager.SetObjectReference();
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();

            personManager.AddPerson(11, "t1", TypeOfPerson.Teacher);
            personManager.AddPerson(1, "s1", TypeOfPerson.Student);
            personManager.AddPerson(2, "s2", TypeOfPerson.Student);
            personManager.AddPerson(3, "s3", TypeOfPerson.Student);
            Person t1 = personManager.FindPerson(11);
            Person s1 = personManager.FindPerson(1);
            Person s2 = personManager.FindPerson(2);
            Person s3 = personManager.FindPerson(3);

            workshopManager.CreateInBuildingWorkshop("inbuilding", "desc", 2, t1, "addr", "roomNumber");
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, t1);
            Workshop w1 = workshopManager.FindWorkshopByID(1);
            Workshop w2 = workshopManager.FindWorkshopByID(2);

            workshopManager.EnrollForWorkshop(s1, w1);
            workshopManager.EnrollForWorkshop(s2, w1);
            workshopManager.EnrollForWorkshop(s1, w2);
            workshopManager.EnrollForWorkshop(s2, w2);

            Assert.AreEqual(true, w1.NinetyPercentCapacityReached);
            Assert.AreEqual(true, w2.NinetyPercentCapacityReached);
            workshopManager.EnrollForWorkshop(s3, w2);
            workshopManager.EnrollForWorkshop(s3, w1);

        }
        [TestMethod]
        [ExpectedException(typeof(PersonNotFoundException))]
        public void SetLoginSeatNumForStudentsUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            workshopManager.SetObjectReference();
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();

            personManager.AddPerson(11, "t1", TypeOfPerson.Teacher);
            personManager.AddPerson(1, "s1", TypeOfPerson.Student);
            personManager.AddPerson(2, "s2", TypeOfPerson.Student);
            Person t1 = personManager.FindPerson(11);
            Person s1 = personManager.FindPerson(1);
            Person s2 = personManager.FindPerson(2);
            Person s3 = new Person(3, "s3", TypeOfPerson.Student);
            workshopManager.CreateInBuildingWorkshop("inbuilding", "desc", 2, t1, "addr", "roomNumber");
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, t1);
            Workshop w1 = workshopManager.FindWorkshopByID(1);
            Workshop w2 = workshopManager.FindWorkshopByID(2);

            workshopManager.EnrollForWorkshop(s1, w1);
            workshopManager.EnrollForWorkshop(s2, w1);
            workshopManager.EnrollForWorkshop(s1, w2);
            workshopManager.EnrollForWorkshop(s2, w2);

            Assert.AreEqual(1, s1.GetSeatNumber);
            Assert.AreEqual(2, s2.GetSeatNumber);
            Assert.AreEqual("Login code: online-1", s1.GetLoginCode);
            Assert.AreEqual("Login code: online-2", s2.GetLoginCode);

            workshopManager.SetLoginSeatNumForStudents(s3, w1);
            workshopManager.SetLoginSeatNumForStudents(s3, w2);
        }
        [TestMethod]
        [ExpectedException(typeof(WorkshopNotFoundException))]
        public void StartWorkshopUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            workshopManager.SetObjectReference();
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();

            personManager.AddPerson(11, "t1", TypeOfPerson.Teacher);
            Person t1 = personManager.FindPerson(11);
            workshopManager.CreateInBuildingWorkshop("inbuilding", "desc", 2, t1, "addr", "roomNumber");
            workshopManager.CreateInBuildingWorkshop("inbuilding", "desc", 2, t1, "addr", "roomNumber");
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, t1);
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, t1);
            Workshop w1 = workshopManager.FindWorkshopByID(1);
            Workshop w2 = workshopManager.FindWorkshopByID(2);
            Workshop w3 = workshopManager.FindWorkshopByID(3);
            Workshop w4 = workshopManager.FindWorkshopByID(4);
            Assert.AreEqual(4, workshopManager.GetAvailableWorkshops().Count);
            w3.IsWorkshopStarted = true;
            w4.IsWorkshopStarted = true;
            Assert.AreEqual(2, workshopManager.GetAvailableWorkshops().Count);
            workshopManager.StartWorkshop(w1);
            workshopManager.StartWorkshop(w2);
            Assert.AreEqual(0, workshopManager.GetAvailableWorkshops().Count);
            workshopManager.StartWorkshop(w3);
            workshopManager.StartWorkshop(w4);

        }

        [TestMethod]
        [ExpectedException(typeof(WorkshopNotFoundException))]
        public void EndWorkshopUnitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            workshopManager.SetObjectReference();
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();

            personManager.AddPerson(11, "t1", TypeOfPerson.Teacher);
            Person t1 = personManager.FindPerson(11);
            workshopManager.CreateInBuildingWorkshop("inbuilding", "desc", 2, t1, "addr", "roomNumber");
            workshopManager.CreateInBuildingWorkshop("inbuilding", "desc", 2, t1, "addr", "roomNumber");
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, t1);
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, t1);
            Workshop w1 = workshopManager.FindWorkshopByID(1);
            Workshop w2 = workshopManager.FindWorkshopByID(2);
            Workshop w3 = workshopManager.FindWorkshopByID(3);
            Workshop w4 = workshopManager.FindWorkshopByID(4);

            w1.IsWorkshopStarted = true;
            w2.IsWorkshopStarted = true;
            w3.IsWorkshopEnded = true;
            Assert.AreEqual(2, workshopManager.GetAvailableWorkshops().Count);
            workshopManager.EndWorkshop(w1);
            workshopManager.EndWorkshop(w2);
            workshopManager.EndWorkshop(w3);
            workshopManager.EndWorkshop(w4);
            Assert.AreEqual(0, workshopManager.GetAvailableWorkshops().Count);
        }


    }
}
