using System;
using System.Collections.Generic;
using System.Linq;
using Animals.Cats;

namespace Animals
{
    public class SomeAnimals
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();

            try
            {
                Dog goshko = new Dog("Goshko", 7, "male");
                Dog valkan = new Dog("Valkan", 2, "male");
                Dog sara = new Dog("Sara", 1, "female");

                animals.Add(goshko);
                animals.Add(valkan);
                animals.Add(sara);

                Cat ana = new Cat("Ana", 3, "female");
                Cat lora = new Cat("Lora", 4, "female");
                Cat krasimir = new Cat("Krasimir", 8, "male");

                animals.Add(ana);
                animals.Add(lora);
                animals.Add(krasimir);

                Kitten viki = new Kitten("Viki", 1);
                TomCat bogko = new TomCat("Bogko", 1);

                animals.Add(viki);
                animals.Add(bogko);

                Frog kvak = new Frog("Kvak", 9, "male");
                Frog kriak = new Frog("Kriak", 3, "female");

                animals.Add(kvak);
                animals.Add(kriak);


                PrintAllAnimals(animals);
                Console.WriteLine();
                AllAnimalsProduceSound(animals);

                double kittenAverageAge = animals.Where(animal => animal is Kitten).Average(age => age.Age);
                double tomCatAverageAge = animals.Where(animal => animal is TomCat).Average(age => age.Age);
                double catAverageAge = animals.Where(animal => animal is Cat).Average(age => age.Age);
                double dogAverageAge = animals.Where(animal => animal is Dog).Average(age => age.Age);
                double frogAverageAge = animals.Where(animal => animal is Frog).Average(age => age.Age);

                Dictionary<string, double> animalsAvergeAge = new Dictionary<string, double>();

                animalsAvergeAge["Dog"] = dogAverageAge;
                animalsAvergeAge["Frog"] = frogAverageAge;
                animalsAvergeAge["Cat"] = catAverageAge;
                animalsAvergeAge["Kitten"] = kittenAverageAge;
                animalsAvergeAge["TomCat"] = tomCatAverageAge;

                Console.WriteLine();
                PrintAvergeAgeOfAllAnimals(animalsAvergeAge);
            }

            catch (ArgumentNullException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

            catch (FormatException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

            catch (ArgumentException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        private static void PrintAvergeAgeOfAllAnimals(Dictionary<string, double> animalsAvergeAge)
        {
            foreach (var animal in animalsAvergeAge)
            {
                Console.WriteLine("The average age of all {0}s is {1:F2} years", animal.Key, animal.Value);
            }
        }

        private static void PrintAllAnimals(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static void AllAnimalsProduceSound(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.Write("{0} says: ", animal.Name);
                animal.ProduceSound();
            }
        }
    }
}