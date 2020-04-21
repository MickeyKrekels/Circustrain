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

            for (int i = 0; i < animalAmount; i++)
            {
                int randomIndex = random.Next(0, 5);

                if (randomIndex == 0)
                {
                    //Amphibians
                    var Amphibian = GenerateAnimal(typeof(Amphibian).Name, AnimalNames.Amphibians, 180,random, 0.01f);
                    result.Add(Amphibian);
                }
                if (randomIndex == 1)
                {
                    //Reptile
                    var Reptile = GenerateAnimal(typeof(Reptile).Name, AnimalNames.Reptiles,70, random);
                    result.Add(Reptile);
                }
                if (randomIndex == 2)
                {
                    //Mammal
                    var Mammal = GenerateAnimal(typeof(Mammal).Name, AnimalNames.Mammals, 300, random);
                    result.Add(Mammal);
                }
                if (randomIndex == 3)
                {
                    //Fish
                    var Fishe = GenerateAnimal(typeof(Fish).Name, AnimalNames.Fishes, 300,random);
                    result.Add(Fishe);
                }
                if (randomIndex == 4)
                {
                    //insect
                    var Insect = GenerateAnimal(typeof(Insect).Name, AnimalNames.Insects, 100, random, 0.001f);
                    result.Add(Insect);
                }
                if (randomIndex == 5)
                {
                    //bird
                    var Bird = GenerateAnimal(typeof(Bird).Name, AnimalNames.Birds, 100, random);
                    result.Add(Bird);
                }
            }

            return result;
        }

        public static Animal GenerateAnimal(string AnimalType, string[] animalNames, int maxWeight,Random random, float weightScale = 1)
        {

            Animal animal = null;
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
            Random random = new Random();
            var result = new List<Animal>();

            for (int a = 0; a < animalAmount; a++)
            {

                var animal = GenerateAnimal(AnimalType, animalNames, maxWeight, random, weightScale);
                if (animal == null)
                    continue;

                result.Add(animal);
            }

            return result;
        }

    }
}
