using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_4
{
    class Entrant : Person
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of entrant</param>
        /// <param name="surname">Surname of entrant</param>
        /// <param name="birth">Date of birth</param>
        /// <param name="faculty">Faculty</param>
        public Entrant(string name, string surname, DateTime birth, string faculty) : base(name, surname, birth, faculty)
        {
            Name = name; Surname = surname; Birth = birth; Faculty = faculty;
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
        public override string ToString() => $"Name: {Name}\nSurname: {Surname}\nDate of birth: {Birth.ToLongDateString()}\nAge: {Age()}\nFaculty: {Faculty}";
        /// <summary>
        /// Input info about entrant
        /// </summary>
        /// <returns>New item of Entrant</returns>
        public static Entrant Input()
        {
            Write("Enter the entrant's name: ");
            string name = ReadLine();
            Write("Enter the entrant's surname: ");
            string surname = ReadLine();
            Write("Enter the date of birth: ");
            DateTime birth = DateTime.Parse(ReadLine());
            Write("Enter the entrant's faculty: ");
            string faculty = ReadLine();
            return new Entrant(name, surname, birth, faculty);
        }

       
    }
}
