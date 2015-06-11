using System;
using Animals.Interfaces;

namespace Animals
{
    public class Dog : Animal, ISoundProducible
    {
        public Dog(string name, int age, string gender) : base(name, age, gender)
        {
            
        }

        public override string ToString()
        {
            return String.Format("Name : {0}, Age: {1}, Gender: {2}", this.Name, this.Age, this.Gender);
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bau Bau");
        }
    }
}
