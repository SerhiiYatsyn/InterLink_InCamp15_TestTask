using Internship.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Institution.InterLink
{
    public class InternshipInCamp
    {
        public List<Student> Students;

        public string Name { get; set; }

        public InternshipInCamp(string Name)
        {
            this.Name = Name;
            this.Students = new List<Student>();
        }

        public void StudentsValidation(University University)
        {
            foreach (Student Student in University.Students)
            {
                if (Student.Knowledge.Level >= University.getAverageScore())
                {
                    this.Students.Add(Student);
                }
            }
        }

        public void GetStudents()
        {
            Console.WriteLine("\nThe list of " + Name + " Intership students:");

            foreach (Student student in Students)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();
        }
    }
}
