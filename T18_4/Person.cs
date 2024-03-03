using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_4
{
    abstract class Person
    {
        /// <summary>
        /// Name of person
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Surname of student
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Date of birth
        /// </summary>
        public DateTime Birth { get; set; }
        /// <summary>
        /// Faculty
        /// </summary>
        public string Faculty { get; set; }
        /// <summary>
        /// Construtcor without parameters
        /// </summary>
        public Person() { }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of person</param>
        /// <param name="surname">Surname of person</param>
        /// <param name="birth">Date of birth</param>
        /// <param name="faculty">Faculty</param>
        public Person(string name, string surname, DateTime birth, string faculty)
        {
            Name = name; Surname = surname; Birth = birth; Faculty = faculty;
        }
        public abstract int Age();
        /// <summary>
        /// Output information about person
        /// </summary>
        public abstract string ToString();
    }
}
