using System;
using System.Collections.Generic;
using Humans.Persons.Employees.RegularEmployees.SalesEmployees;
using Humans.Persons.Employees.RegularEmployees.SalesEmployeeUnits;


namespace Humans.Persons.Employees.RegularEmployees
{
    public class SalesEmployee : Employee, ISalesEmployee
    {
        private List<Sale> sales = new List<Sale>();

        public SalesEmployee(string id, string firstName, string lastName, decimal salary, string departament,
            List<Sale> sales) : base(id, firstName, lastName, salary, departament)
        {
            this.Sales = sales;
        }

        public SalesEmployee(string id, string firstName, string lastName, decimal salary, string departament) :
            base(id, firstName, lastName, salary, departament)
        {
            this.Sales = new List<Sale>();
        }

        public List<Sale> Sales
        {
            get { return this.sales; }

            set { this.sales = value; }
        }

        public void AddASale(Sale sale)
        {
            this.Sales.Add(sale);
        }

        public override string ToString()
        {
            return String.Format("{0} \n Sales: \n{1}", base.ToString(), String.Join("\n", this.Sales));
        }
    }
}
