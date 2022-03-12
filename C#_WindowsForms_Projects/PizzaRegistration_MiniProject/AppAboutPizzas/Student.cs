using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutPizzas
{
    public class Student
    {
        Pizza pizza;
        private int studentnumber;
        private String name;

        public string GetStudentName
        {
            get { return this.name; }
        }
        public int StudentsNumber
        {
            get { return this.studentnumber; }
        }
        public Student(int studentnumber, String name)
        { 
            this.studentnumber = studentnumber;
            this.name = name;
        }
        public void RegisterPizza(Pizza p)
        {
            this.pizza = p;
        }
        public bool StudentsPizza()
        {
            if(this.pizza != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Pizza GetStudentsPizza
        {
            get { return this.pizza; }
        }
        public String GetInfo()
        {
            if(this.pizza != null)
            {
                return this.name + " (" + this.studentnumber + ") " + this.pizza.GetInfo();
            }
            else
            {
                return this.name + " (" + this.studentnumber + ") ";
            }
        }
    }
}
