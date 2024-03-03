using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_4
{
    class Lecturer : Person
    {
        /// <summary>
        /// Lecturer's work position
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Lecturer's work experience in years
        /// </summary>
        public double Experience { get; set; }
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Lecturer() { }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Lecturer's name</param>
        /// <param name="surname">Lecturer's surname</param>
        /// <param name="birth">Lecturer's date of birth</param>
        /// <param name="faculty">Lecturer's faculty</param>
        /// <param name="position">Lecturer's work position</param>
        /// <param name="experience">Lecturer's work experience in years</param>
        public Lecturer(string name, string surname, DateTime birth, string faculty, string position, double experience) : base(name, surname, birth, faculty)
        {
            Position = position; Experience = experience;
        }
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
        public override string ToString() => $"Name: {Name}\nSurname: {Surname}\nDate of birth: {Birth.ToLongDateString()}\nAge: {Age()}\nPosition: {Position}\nExperience in years: {Experience}";
        /// <summary>
        /// Input info about student
        /// </summary>
        /// <returns>New item of Student</returns>
        public static Lecturer Input()
        {
            Write("Enter the lecturer's name: ");
            string name = ReadLine();
            Write("Enter the lecturer's surname: ");
            string surname = ReadLine();
            Write("Enter the date of birth: ");
            DateTime birth = DateTime.Parse(ReadLine());
            Write("Enter the lecturer's faculty: ");
            string faculty = ReadLine();
            Write("Enter lecturer's work position: ");
            string position = ReadLine();
            Write("Enter lecturer's work experience in years: ");
            double experience = Convert.ToDouble(ReadLine());
            return new Lecturer(name, surname, birth, faculty, position, experience);
        }
    }
}
