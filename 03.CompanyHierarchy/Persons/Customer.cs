using System;
using Humans.Persons.Employees.Customers;

namespace Humans.Persons
{
    public class Customer : Person, ICustomer
    {
        private decimal amount;

        public Customer(string id, string firstName, string lastName, decimal amount) :
            base(id, firstName, lastName)
        {
            this.Amount = amount;
        }

        public decimal Amount
        {
            get { return this.amount; }

            set
            {
                if (amount < 0m)
                {
                    throw new ArgumentException("Your spended money can not be negative");
                }

                this.amount = value;
            }
        }

        public void AddAmount(decimal amount)
        {
            this.Amount += amount;
        }

        public override string ToString()
        {
            return String.Format("{0} Net purchase amount: {1}", base.ToString(), this.Amount);
        }
    }
}
