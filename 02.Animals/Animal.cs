using System;
using Animals.Interfaces;

namespace Animals
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private string gender;

        protected Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (String.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Your name can not be empty");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The age of your animal can not be nagative");
                }

                this.age = value;
            }
        }

        public string Gender
        {
            get { return this.gender; }

            set
            {
                if (!(value.Equals("male") || value.Equals("female")))
                {
                    throw new ArgumentException("The gender of your animal can be \"male\" or \"female\" ");
                }

                this.gender = value;
            }
        }

        public abstract override string ToString();
        public abstract void ProduceSound();
    }
}