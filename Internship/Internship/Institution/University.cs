using Internship.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Institution
{
    public class University
    {
        public List<Student> Students;

        public string Name { get; set; }

        public University(string Name)
        {
            this.Name = Name;
            this.Students = new List<Student>();
        }

        public void AddStudent(Student Student)
        {
            this.Students.Add(Student);
        }

        public void ShowAllStudents()
        {
            Console.WriteLine("The list students of " + Name);

            foreach (Student student in Students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public double getAverageScore()
        {
            double Score = 0;
            foreach (Student student in Students)
            {
                Score += student.Knowledge.Level;
            }
            return Score / Students.Count;
        }
    }
}
