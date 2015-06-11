using System;
using Animals.Interfaces;


namespace Animals.Cats
{
    public class Kitten : Cat, ISoundProducible
    {
        private const string kittenGender = "female";

        public Kitten(string name, int age) : base(name, age, kittenGender)
        {
            
        }
    }
}
