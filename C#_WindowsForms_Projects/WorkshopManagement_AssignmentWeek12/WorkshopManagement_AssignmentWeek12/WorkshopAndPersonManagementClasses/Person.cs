using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagement_AssignmentWeek12
{
    public class Person
    {
        private int pcn;
        private string names;
        private TypeOfPerson typeOfPerson;
        private string loginCode;
        private int seatNumber;
        public int GetPCN
        {
            get { return this.pcn; }
            set { this.pcn = value; }
        }
        public string GetNames
        {
            get { return this.names; }
            set { this.names = value; }
        }
        public TypeOfPerson SetTypeOfPerson
        {
            set { this.typeOfPerson = value; }
        }

        public TypeOfPerson GetTypeOfPerson()
        {
            return this.typeOfPerson;
        }

        public string GetLoginCode
        {
            get { return this.loginCode; }
            set { this.loginCode = value; }
        }

        public int GetSeatNumber
        {
            get { return this.seatNumber; }
            set { this.seatNumber = value; }
        }


        public Person(int pcn, string names, TypeOfPerson typeOfPerson)
        {
            this.GetPCN = pcn;
            this.GetNames = names;
            this.SetTypeOfPerson = typeOfPerson;
        }

        public string ToString()
        {
            return $"{this.GetPCN} {this.GetNames} ({this.GetTypeOfPerson()})";
        }
    }
}
