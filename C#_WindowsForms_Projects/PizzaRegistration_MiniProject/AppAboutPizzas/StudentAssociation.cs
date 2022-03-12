using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutPizzas
{
    class StudentAssociation
    {
        private String name;
        Student student;
        Pizza pizza;
        private List<Student> students;
        private List<Pizza> pizzas;

        public StudentAssociation(String Name)
        {   //todo
            this.name = Name;
            students = new List<Student>();
            pizzas = new List<Pizza>();
        }

        public Student GetStudent(int studentnumber)
        {   
            foreach(Student s in students)
            {
                if(s.StudentsNumber == studentnumber)
                {
                    return s;
                }
            }
            return null; 
        }
        public bool AddStudent(int studentnumber, String name)
        {
            foreach(Student s in students)
            {
                if(s.StudentsNumber == studentnumber)
                {
                    return false;
                }
            }
            student = new Student(studentnumber, name);
            students.Add(student);
            return true;
        }

        public bool RegisterStudentsChoice(int studentnumber, KindOfPizza kind)
        {   
            foreach(Student s in students)
            {
                if(s.StudentsNumber == studentnumber)
                {
                    pizza = new Pizza(kind);
                    pizzas.Add(pizza);
                    if(s.StudentsPizza())
                    {
                        pizzas.Remove(s.GetStudentsPizza);
                    }
                    s.RegisterPizza(pizza);
                    return true;
                }
            }
            return false; 
        }
        
        public Pizza[] ShowAllPizzas()
        {
            return pizzas.ToArray();
        }

        public Student[] ShowAllStudents()
        {
            return students.ToArray();
        }
    }
}
