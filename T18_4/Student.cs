using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_4
{
    class Student : Person
    {
        /// <summary>
        /// Сourse of study
        /// </summary>
        public int Course { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of student</param>
        /// <param name="surname">Surname of student</param>
        /// <param name="birth">Date of birth</param>
        /// <param name="faculty">Faculty</param>
        /// <param name="course">Course</param>
        public Student(string name, string surname, DateTime birth, string faculty, int course) : base(name, surname, birth, faculty) => Course = course;
        /// <summary>
        /// Overriden method Age
        /// </summary>
        /// <returns>Age at this moment</returns>
        public override int Age()
        {
            if (DateTime.Now > Birth.AddYears(DateTime.Now.Year - Birth.Year)) { return DateTime.Now.Year - Birth.Year - 1; }
            else { return DateTime.Now.Year - Birth.Year; }
        }
        /// <summary>
        /// Overriden method Output info
        /// </summary>
        public override string ToString() => $"Student: {Name}, {Surname}\nDate of birth: {Birth.ToLongDateString()}\nCourse: {Course}\nAge: {Age()}";
        /// <summary>
        /// Input info about student
        /// </summary>
        /// <returns>New item of Student</returns>
        public static Student Input()
        {
            Write("Enter the student's name: ");
            string name = ReadLine();
            Write("Enter the student's surname: ");
            string surname = ReadLine();
            Write("Enter the date of birth: ");
            DateTime birth = DateTime.Parse(ReadLine());
            Write("Enter the student's faculty: ");
            string faculty = ReadLine();
            Write("Enter the course: ");
            int course = Convert.ToInt32(ReadLine());
            return new Student(name, surname, birth, faculty, course);
        }
    }
}
