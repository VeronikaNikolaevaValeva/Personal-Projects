using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopManagement_AssignmentWeek12;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WorkshopManagementUnitTestingProject
{
    [TestClass]
    public class WorkshopDALUnitTest
    {
        [TestMethod]
        public void SaveWorkshopInformationUitTest()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            workshopManager.SetObjectReference();
            PersonManager personManager = new PersonManager();
            personManager.SetListOfPeople = new List<Person>();

            personManager.AddPerson(11, "t1", TypeOfPerson.Teacher);
            Person t1 = personManager.FindPerson(11);

            workshopManager.CreateInBuildingWorkshop("inbuilding", "desc", 2, t1, "addr", "roomNumber");
            workshopManager.CreateOnlineWorkshop("online", "desc", 2, t1);
            string filename = "WorkshopInformation";
            
            IWorkshopDAL saveInfo = new WorkshopDAL();
            saveInfo.WriteWorkshopsToTextFile( workshopManager.GetAllWorkshops(), filename);

        }

    }
}
