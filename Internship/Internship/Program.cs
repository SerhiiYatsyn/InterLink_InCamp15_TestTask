using Internship.Institution;
using Internship.Institution.InterLink;
using Internship.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    class Program
    {
        static void Main(string[] args)
        {
            University CHNU = new University("The Bohdan Khmelnytsky National University of Cherkasy");

            CHNU.AddStudent(new Student("Serhii Yatsyn", 100));
            CHNU.AddStudent(new Student("Stas Lotskin", 89));
            CHNU.AddStudent(new Student("Euhen Korzh", 38));
            CHNU.AddStudent(new Student("Vlad Kravchenko", 43));
            CHNU.AddStudent(new Student("Alina Kosholap", 58));
            CHNU.AddStudent(new Student("Irina Mogila", 66));
            CHNU.AddStudent(new Student("Andrey Kharitonov", 1));
            CHNU.AddStudent(new Student("Anna Suscheva", 25));
            CHNU.AddStudent(new Student("Diana Ratsyna", 95));
            CHNU.AddStudent(new Student("Sasha Kotov", 99));

            CHNU.ShowAllStudents();

            Console.WriteLine("\n" + CHNU.Name + " average score is " + CHNU.getAverageScore());

            InternshipInCamp InCamp = new InternshipInCamp("Interlink");
            InCamp.StudentsValidation(CHNU);
            InCamp.GetStudents();
            Console.ReadLine();
        }
    }
}
