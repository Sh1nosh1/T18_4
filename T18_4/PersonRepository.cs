using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_4
{
    class PersonRepository
    {
        /// <summary>
        /// Collection of persons
        /// </summary>
        List<Person> people = new List<Person>();
        /// <summary>
        /// Method of adding persons
        /// </summary>
        /// <param name="person">Person</param>
        public void AddPeople(Person person)
        {
            people.Add(person);
            WriteLine($"You have add the new person - {person.Name}\n");
        }
        public List<Person> Compare()
        {
            List<Person> personsInRange = new List<Person>();
            foreach (Person person in people)
            {
                if (person.Age() > 15 && person.Age() < 65)
                {
                    personsInRange.Add(person);
                }
            }
            return personsInRange;
        }
        /// <summary>
        /// Get persons for output
        /// </summary>
        /// <returns>Persons</returns>
        public List<Person> GetPersons()
        {
            return people;
        }
    }
}
