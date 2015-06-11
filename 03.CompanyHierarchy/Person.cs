using System;
using Humans.Persons;

namespace Humans
{
    public abstract class Person : IPerson
    {
        private string id;
        private string firstName;
        private string lastName;

        protected Person(string id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string ID
        {
            get { return this.id; }

            set
            {
                if (String.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentNullException("Your Id can not be empty");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }

            set
            {
                if (String.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentNullException("Your person's first name can not be empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }

            set
            {
                if (String.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentNullException("Your person's last name can not be empty");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return String.Format("ID: {0}, First name: {1}, Last name: {2}", this.ID, this.FirstName, this.LastName);
        }
    }
}