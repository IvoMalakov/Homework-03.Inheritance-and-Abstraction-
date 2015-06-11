using System;
using Humans.Persons.Employees;

namespace Humans.Persons
{
    public class Employee : Person, IPerson, IEmployee
    {
        private decimal salary;
        private string departament;

        public Employee(string id, string firstName, string lastName, decimal salary, string departament) :
            base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Departament = departament;
        }

        public decimal Salary
        {
            get { return this.salary; }

            set
            {
                if (value <= 0.0m)
                {
                    throw new ArgumentException("Your salary can not be nagative");
                }

                this.salary = value;
            }
        }

        public string Departament
        {
            get { return this.departament; }

            set
            {
                if (!(value.Equals("Production".Trim()) || value.Equals("Accounting".Trim()) ||
                      value.Equals("Sales".Trim()) || value.Equals("Marketing".Trim())))
                {
                    throw new ArgumentException("Your departament can be only \"Production\", \"Accounting\"" +
                                                " \"Sales\" or \"Marketing\" ");
                }

                this.departament = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}, Salary: {1}, Departamen: {2}", base.ToString(), this.Salary, this.Departament);
        }
    }
}