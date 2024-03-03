using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_4
{
    internal class Program
    {
        enum Action { Create = 1, Output, Exit }
        enum TypeOfPerson { Entrant = 1, Student, Lecturer, Exit }
        static void Main(string[] args)
        {
            try
            {
                PersonRepository repository = new PersonRepository();
                bool flag = true;

                while (flag)
                {
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("Choose an action:\n1 - Create person\n2 - Output all information\n3 - Exit\n");
                    ResetColor();

                    if (Enum.TryParse(ReadLine(), out Action action))
                    {
                        switch (action)
                        {
                            case Action.Create:
                                Clear();
                                ForegroundColor = ConsoleColor.Blue;
                                WriteLine("Choose a person to create:\n1 - Entrant\n2 - Student\n3 - Lecturer\n4 - Exit\n");
                                ResetColor();

                                if (Enum.TryParse(ReadLine(), out TypeOfPerson person))
                                {
                                    Clear();
                                    switch (person)
                                    {
                                        case TypeOfPerson.Entrant:
                                            repository.AddPeople(Entrant.Input());
                                            break;
                                        case TypeOfPerson.Student:
                                            repository.AddPeople(Student.Input());
                                            break;
                                        case TypeOfPerson.Lecturer:
                                            repository.AddPeople(Lecturer.Input());
                                            break;
                                        case TypeOfPerson.Exit:
                                            Environment.Exit(0);
                                            break;
                                    }
                                }
                                else { WriteLine("Wrong action. Try again!"); }
                                break;

                            case Action.Output:
                                Clear();
                                if (repository.GetPersons().Count != 0)
                                {
                                    ForegroundColor = ConsoleColor.Blue;
                                    WriteLine("All persons: \n");
                                    ResetColor();
                                    foreach (var elem in repository.GetPersons()) { WriteLine(elem.ToString()); WriteLine(); }

                                    ForegroundColor = ConsoleColor.Blue;
                                    WriteLine("Persons from 16 to 65 y. o.: \n");
                                    ResetColor();
                                    List<Person> personsInRange = repository.Compare();
                                    foreach (var persons in personsInRange) { WriteLine(persons.ToString()); WriteLine(); }
                                    break;
                                }
                                else { WriteLine("You haven't entered a single person"); break; }
                            case Action.Exit:
                                Environment.Exit(0);
                                break;
                        }
                    }
                    else { WriteLine("Wrong action. Try again!"); }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
