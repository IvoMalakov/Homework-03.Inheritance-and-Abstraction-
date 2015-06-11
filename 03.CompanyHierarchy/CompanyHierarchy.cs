using System;
using System.Collections.Generic;
using Humans.Persons;
using Humans.Persons.Employees;
using Humans.Persons.Employees.Managers;
using Humans.Persons.Employees.RegularEmployees.SalesEmployees;
using Humans.Persons.Employees.RegularEmployees;
using Humans.Persons.Employees.RegularEmployees.DeveloperUnits;
using Humans.Persons.Employees.RegularEmployees.SalesEmployeeUnits;


namespace Humans
{
    public class CompanyHierarchy
    {
        public static void Main()
        {

            Manager manager1 = new Manager("9012", "Maria", "Ivanova", 3080, "Marketing");
            Manager manager2 = new Manager("1236", "Ivan", "Ivanov", 2010, "Accounting");
            Manager manager3 = new Manager("1789", "Pepi", "Popov", 1800, "Accounting");
            Manager manager4 = new Manager("6432", "Zlati", "Zlatev", 2000, "Accounting");

            Sale mobilePhone = new Sale("Samsung S6", DateTime.Today, 530);
            Sale gadget = new Sale("Mini Pad", DateTime.Today, 45);
            Sale gadget1 = new Sale("Cable", DateTime.Today, 20);

            SalesEmployee employee1 = new SalesEmployee("3490", "Emo", "Cholakov", 890, "Sales");
            employee1.Sales.Add(mobilePhone);
            SalesEmployee employee2 = new SalesEmployee("3490", "Margarita", "Maneva", 795, "Sales");
            employee2.Sales.Add(gadget);
            employee2.Sales.Add(gadget1);

            Developer develop1 = new Developer("9087", "Mincho", "Draganov", 600, "Production");
            Project proj1 = new Project("New car electonic", new DateTime(2004, 12, 4), "Change software to ver2.2");
            proj1.CloseProject();
            develop1.AddProject(proj1);

            var allEmployees = new List<Employee>();
            allEmployees.Add(manager1);
            allEmployees.Add(manager2);
            allEmployees.Add(manager3);
            allEmployees.Add(manager4);
            allEmployees.Add(employee1);
            allEmployees.Add(employee2);
            allEmployees.Add(develop1);

            foreach (var employee in allEmployees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}