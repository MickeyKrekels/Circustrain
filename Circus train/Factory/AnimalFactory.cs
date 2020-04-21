using Circus_train.Animals;
using Circus_train.Animals.Base;
using Circus_train.Enums;
using System;
using System.Collections.Generic;

namespace Circus_train.Factory
{
    public static class AnimalFactory
    {
        public static List<Animal> GenerateRandomAnimals(int animalAmount)
        {
            var result = new List<Animal>();

            Random random = new Random();

            //Amphibians
            var Amphibians = GenerateAnimals(typeof(Amphibian).Name, AnimalNames.Amphibians, animalAmount, 180, 0.01f);
            result.AddRange(Amphibians);

            //Reptile
            var Reptiles = GenerateAnimals(typeof(Reptile).Name, AnimalNames.Reptiles, animalAmount, 70);
            result.AddRange(Reptiles);

            //Mammal
            var Mammals = GenerateAnimals(typeof(Mammal).Name, AnimalNames.Mammals, animalAmount, 300);
            result.AddRange(Mammals);

            //Fish
            var Fishes = GenerateAnimals(typeof(Fish).Name, AnimalNames.Fishes, animalAmount, 300);
            result.AddRange(Fishes);

            //insect
            var Insects = GenerateAnimals(typeof(Insect).Name, AnimalNames.Insects, animalAmount, 100, 0.001f);
            result.AddRange(Insects);

            //bird
            var Birds = GenerateAnimals(typeof(Bird).Name, AnimalNames.Birds, animalAmount, 100);
            result.AddRange(Birds);


            return result;
        }

        public static Animal GenerateAnimal(string AnimalType, string[] animalNames, int maxWeight, float weightScale = 1)
        {

            Animal animal = null;
            Random random = new Random();
            Array values = Enum.GetValues(typeof(AnimalDiet));
            AnimalDiet randomAnimalDiet = (AnimalDiet)values.GetValue(random.Next(values.Length));

            int index = random.Next(0, animalNames.Length);
            string animalname = animalNames[index];

            if (AnimalType == typeof(Amphibian).Name)
            {
                animal = new Amphibian(animalname, random.Next(1, maxWeight) * weightScale, randomAnimalDiet);
            }
            if (AnimalType == typeof(Reptile).Name)
            {
                animal = new Reptile(animalname, random.Next(1, maxWeight) * weightScale, randomAnimalDiet);
            }
            if (AnimalType == typeof(Mammal).Name)
            {
                animal = new Mammal(animalname, random.Next(1, maxWeight) * weightScale, randomAnimalDiet);
            }
            if (AnimalType == typeof(Fish).Name)
            {
                animal = new Fish(animalname, random.Next(1, maxWeight) * weightScale, randomAnimalDiet);
            }
            if (AnimalType == typeof(Insect).Name)
            {
                animal = new Insect(animalname, random.Next(1, maxWeight) * weightScale, randomAnimalDiet);
            }
            if (AnimalType == typeof(Bird).Name)
            {
                animal = new Bird(animalname, random.Next(1, maxWeight) * weightScale, randomAnimalDiet);
            }

            return animal;
        }

        public static List<Animal> GenerateAnimals(string AnimalType, string[] animalNames, int animalAmount, int maxWeight, float weightScale = 1)
        {
            Array values = Enum.GetValues(typeof(AnimalDiet));
            var result = new List<Animal>();

            for (int a = 0; a < animalAmount; a++)
            {

                var animal = GenerateAnimal(AnimalType, animalNames, maxWeight, weightScale);
                if (animal == null)
                    continue;

                result.Add(animal);
            }

            return result;
        }
    }
}
