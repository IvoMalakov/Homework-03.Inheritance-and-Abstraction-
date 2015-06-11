using System;
using System.Collections.Generic;
using System.Text;
using Humans.Persons.Employees.Managers;

namespace Humans.Persons.Employees
{
    public class Manager : Employee, IManager
    {
        private List<Employee> employeesUnderComand = new List<Employee>();

        public Manager(string id, string firstName, string lastName, decimal salary, string departament)
             : base(id, firstName, lastName, salary, departament)
        {
    
        }

        public void AddEmployee(Employee employee)
        {
            employeesUnderComand.Add(employee);
        }

        public override string ToString()
        {
            StringBuilder allEmployes = new StringBuilder();

            foreach (var employee in employeesUnderComand)
            {
                allEmployes.AppendFormat("{0}, ", employee);
            }

            return String.Format("{0} Emploees under command: {1} ", base.ToString(), allEmployes);
        }
    }
}
