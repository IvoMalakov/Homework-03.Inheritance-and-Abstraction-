using System;
using Microsoft.SqlServer.Server;


namespace Humans.Persons.Employees.RegularEmployees.SalesEmployeeUnits
{
    public class Sale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }

            set
            {
                if (String.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("The product name can not be empty");
                }

                this.productName = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }

            set
            {
                if (value < 0m)
                {
                    throw new ArgumentException("The price of your product can not be nagative");
                }

                this.price = value;
            }
        }

        public DateTime Date { get; set; }

        public override string ToString()
        {
            return String.Format("Product name: {0}, Date: {1}, Price: {2}", this.ProductName, this.Date, this.Price);
        }
    }
}
