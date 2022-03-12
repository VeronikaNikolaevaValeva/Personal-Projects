using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
    public class Student
    {

        private string FirstName;
        private string LastName;
        private int Age;
        private string Sex;
        private int StudentNumber;
        private int RoomNumber;
        private int BankAccount;
        private double InitialBalance;

        public Student(
            string FirstName,
            string LastName,
            int Age,
            string Sex,
            int StudentNumber,
            int RoomNumber,
            int BankAccount,
            double InitialBalance
            )
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Sex = Sex;
            this.StudentNumber = StudentNumber;
            this.RoomNumber = RoomNumber;
            this.BankAccount = BankAccount;
            this.InitialBalance = InitialBalance;
        }
       
        public string GetStudentInfo()
        {
            return $"{FirstName} {LastName} - Student number: {StudentNumber} / Room: {RoomNumber}";
        }

        
        public string GetName()
        {
            return $"{FirstName} {LastName}";
        }
        public int GetAge()
        {
            return Age;
        }
        public string GetSex()
        {
            return Sex;
        }
        public int GetStudentNumber()
        {
            return StudentNumber;
        }
        public int GetRoomNumber()
        {
            return RoomNumber;
        }
        public int GetBankAccount()
        {
            return BankAccount;
        }
        public double GetInitialBalance()
        {
            return InitialBalance;
        }
        public void SetBalance(double balance)
        {
            this.InitialBalance = balance;
        }

    }
}
