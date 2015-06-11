using System;
using System.Collections.Generic;
using System.Linq;

public class SomeHumans
{
    public static void Main()
    {
        List<Student> students = new List<Student>();
        List<Worker> workers = new List<Worker>();
        List<Human> humans = new List<Human>();

        try
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Enter the first name of your [{0}] student: ", i);
                string studentFirstName = Console.ReadLine();

                Console.WriteLine("Enter the last name of your [{0}] student: ", i);
                string studentLastName = Console.ReadLine();

                Console.WriteLine("Enter the faculty number of your [{0}] student: ", i);
                string studetnFacultyNumber = Console.ReadLine();

                Student student = new Student(studentFirstName, studentLastName, studetnFacultyNumber);
                students.Add(student);
            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Enter the first name of your [{0}] worker: ", i);
                string workerFirstName = Console.ReadLine();

                Console.WriteLine("Enter the last name of your [{0}] worker: ", i);
                string workerLastName = Console.ReadLine();

                Console.WriteLine("Enter the week salary of your [{0}] worker: ", i);
                string trySalary = Console.ReadLine();
                decimal workerWeekSalary;
                bool isRealSalary = decimal.TryParse(trySalary, out workerWeekSalary);

                if (!isRealSalary)
                {
                    throw new FormatException("Your salary must be a positive number");
                }

                Console.WriteLine("Enter the work hours per day of your [{0}] worker: ", i);
                string tryWorkHours = Console.ReadLine();
                decimal workerWorkHoursPerDay;
                bool isRealWorkHours = decimal.TryParse(tryWorkHours, out workerWorkHoursPerDay);

                if (!isRealWorkHours)
                {
                    throw new FormatException("Your work hours must be a  positive number");
                }

                Worker worker = new Worker(workerFirstName, workerLastName, workerWeekSalary, workerWorkHoursPerDay);
                workers.Add(worker);
            }

            var orderedStudets = students.OrderBy(i => i.FacultyNumber);
            var orderedWorkers = workers.OrderByDescending(i => i.MoneyPerHour());

            Console.WriteLine();
            Console.WriteLine("You have the following students: ");
            PrintStudets(orderedStudets);

            Console.WriteLine();
            Console.WriteLine("You have the following workers: ");
            PrintWorkers(orderedWorkers);

            humans.AddRange(students);
            humans.AddRange(workers);
            humans = humans.OrderBy(human => human.FirstName).ThenBy(human => human.LastName).ToList();

            Console.WriteLine();
            Console.WriteLine("You have the following humans: ");
            PrintHumans(humans);
        }
            
        catch (ArgumentNullException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }

        catch (FormatException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }

        catch (ArgumentException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
    }

    private static void PrintHumans(List<Human> humans)
    {
        foreach (var human in humans)
        {
            Console.WriteLine(human);
        }
    }

    private static void PrintWorkers(IOrderedEnumerable<Worker> orderedWorkers)
    {
        foreach (var worker in orderedWorkers)
        {
            Console.WriteLine(worker);
        }
    }

    private static void PrintStudets(IOrderedEnumerable<Student> orderedStudets)
    {
        foreach (var student in orderedStudets)
        {
            Console.WriteLine(student);
        }
    }
}