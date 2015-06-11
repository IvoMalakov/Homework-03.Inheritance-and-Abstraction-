using System;
using Animals.Interfaces;

namespace Animals.Cats
{
    public class TomCat : Cat, ISoundProducible
    {
        private const string tomCatGender = "male";

        public TomCat(string name, int age) : base(name, age, tomCatGender)
        {
            
        }
    }
}
