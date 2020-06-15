using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Circus_train.Animals;
using Circus_train.Enums;
using Circus_train.Factory;
using System.Linq;
using Circus_train.Animals.Base;

namespace UnitTesting.UnitTests
{
    [TestClass]
    public class UnitTest_WagonFactory
    {
        [TestMethod]
        public void WagonFactory_RandomAmphibianAnimals()
        {
            int animalAmount = 40;

            var animals = AnimalFactory.GenerateAnimals(typeof(Amphibian).Name, AnimalNames.Amphibians, animalAmount, 50);

            var wagons = WagonFactory.GenerateFilledWagons(animals);

            //check if all animals are added 
            Assert.IsTrue(wagons.Sum(x => x.AllAnimals.Count) == animalAmount);

            foreach (var wagon in wagons)
            {
                var carnivore = wagon.AllAnimals.Where(x => x.AnimalDiet == AnimalDiet.Carnivores).ToList();
                var herbivore = wagon.AllAnimals.Where(x => x.AnimalDiet == AnimalDiet.Herbivores).ToList();

                if (carnivore != null && carnivore.Count > 0)
                {

                    Assert.IsTrue(carnivore.Count == 1);

                    for (int i = 0; i < carnivore.Count; i++)
                    {
                        var herbivoresIsSmaller = herbivore.Any(x => x.Weight < carnivore[i].Weight);

                        // if there is a carnivore in the wagon there can't be a smaller herbivore
                        Assert.IsTrue(herbivoresIsSmaller == false);
                    }

                }


            }
        }
        [TestMethod]
        public void WagonFactory_RandomBirdAnimals()
        {
            int animalAmount = 40;

            var animals = AnimalFactory.GenerateAnimals(typeof(Bird).Name, AnimalNames.Amphibians, animalAmount, 50);

            var wagons = WagonFactory.GenerateFilledWagons(animals);

            //check if all animals are added 
            Assert.IsTrue(wagons.Sum(x => x.AllAnimals.Count) == animalAmount);

            foreach (var wagon in wagons)
            {
                var carnivore = wagon.AllAnimals.Where(x => x.AnimalDiet == AnimalDiet.Carnivores).ToList();
                var herbivore = wagon.AllAnimals.Where(x => x.AnimalDiet == AnimalDiet.Herbivores).ToList();

                if (carnivore != null && carnivore.Count > 0)
                {

                    Assert.IsTrue(carnivore.Count == 1);

                    for (int i = 0; i < carnivore.Count; i++)
                    {
                        var herbivoresIsSmaller = herbivore.Any(x => x.Weight < carnivore[i].Weight);

                        // if there is a carnivore in the wagon there can't be a smaller herbivore
                        Assert.IsTrue(herbivoresIsSmaller == false);
                    }

                }


            }
        }

        [TestMethod]
        public void WagonFactory_RandomFishAnimals()
        {
            int animalAmount = 40;

            var animals = AnimalFactory.GenerateAnimals(typeof(Fish).Name, AnimalNames.Amphibians, animalAmount, 50);

            var wagons = WagonFactory.GenerateFilledWagons(animals);

            //check if all animals are added 
            Assert.IsTrue(wagons.Sum(x => x.AllAnimals.Count) == animalAmount);

            foreach (var wagon in wagons)
            {
                var carnivore = wagon.AllAnimals.Where(x => x.AnimalDiet == AnimalDiet.Carnivores).ToList();
                var herbivore = wagon.AllAnimals.Where(x => x.AnimalDiet == AnimalDiet.Herbivores).ToList();

                if (carnivore != null && carnivore.Count > 0)
                {

                    Assert.IsTrue(carnivore.Count == 1);

                    for (int i = 0; i < carnivore.Count; i++)
                    {
                        var herbivoresIsSmaller = herbivore.Any(x => x.Weight < carnivore[i].Weight);

                        // if there is a carnivore in the wagon there can't be a smaller herbivore
                        Assert.IsTrue(herbivoresIsSmaller == false);
                    }

                }


            }
        }

        [TestMethod]
        public void WagonFactory_RandomInsectAnimals()
        {
            int animalAmount = 40;

            var animals = AnimalFactory.GenerateAnimals(typeof(Insect).Name, AnimalNames.Amphibians, animalAmount, 50);

            var wagons = WagonFactory.GenerateFilledWagons(animals);

            //check if all animals are added 
            Assert.IsTrue(wagons.Sum(x => x.AllAnimals.Count) == animalAmount);

            foreach (var wagon in wagons)
            {
                var carnivore = wagon.AllAnimals.Where(x => x.AnimalDiet == AnimalDiet.Carnivores).ToList();
                var herbivore = wagon.AllAnimals.Where(x => x.AnimalDiet == AnimalDiet.Herbivores).ToList();

                if (carnivore != null && carnivore.Count > 0)
                {

                    Assert.IsTrue(carnivore.Count == 1);

                    for (int i = 0; i < carnivore.Count; i++)
                    {
                        var herbivoresIsSmaller = herbivore.Any(x => x.Weight < carnivore[i].Weight);

                        // if there is a carnivore in the wagon there can't be a smaller herbivore
                        Assert.IsTrue(herbivoresIsSmaller == false);
                    }

                }


            }
        }

        [TestMethod]
        public void WagonFactory_RandomMammalAnimals()
        {
            int animalAmount = 40;

            var animals = AnimalFactory.GenerateAnimals(typeof(Mammal).Name, AnimalNames.Amphibians, animalAmount, 50);

            var wagons = WagonFactory.GenerateFilledWagons(animals);

            //check if all animals are added 
            Assert.IsTrue(wagons.Sum(x => x.AllAnimals.Count) == animalAmount);

            foreach (var wagon in wagons)
            {
                var carnivore = wagon.AllAnimals.Where(x => x.AnimalDiet == AnimalDiet.Carnivores).ToList();
                var herbivore = wagon.AllAnimals.Where(x => x.AnimalDiet == AnimalDiet.Herbivores).ToList();

                if (carnivore != null && carnivore.Count > 0)
                {

                    Assert.IsTrue(carnivore.Count == 1);

                    for (int i = 0; i < carnivore.Count; i++)
                    {
                        var herbivoresIsSmaller = herbivore.Any(x => x.Weight < carnivore[i].Weight);

                        // if there is a carnivore in the wagon there can't be a smaller herbivore
                        Assert.IsTrue(herbivoresIsSmaller == false);
                    }

                }


            }
        }

        [TestMethod]
        public void WagonFactory_RandomReptileAnimals()
        {
            int animalAmount = 40;

            var animals = AnimalFactory.GenerateAnimals(typeof(Reptile).Name, AnimalNames.Amphibians, animalAmount, 50);

            var wagons = WagonFactory.GenerateFilledWagons(animals);

            //check if all animals are added 
            Assert.IsTrue(wagons.Sum(x => x.AllAnimals.Count) == animalAmount);

            foreach (var wagon in wagons)
            {
                var carnivore = wagon.AllAnimals.Where(x => x.AnimalDiet == AnimalDiet.Carnivores).ToList();
                var herbivore = wagon.AllAnimals.Where(x => x.AnimalDiet == AnimalDiet.Herbivores).ToList();

                if (carnivore != null && carnivore.Count > 0)
                {

                    Assert.IsTrue(carnivore.Count == 1);

                    for (int i = 0; i < carnivore.Count; i++)
                    {
                        var herbivoresIsSmaller = herbivore.Any(x => x.Weight < carnivore[i].Weight);

                        // if there is a carnivore in the wagon there can't be a smaller herbivore
                        Assert.IsTrue(herbivoresIsSmaller == false);
                    }

                }


            }
        }

        [TestMethod]
        public void WagonFactory_2Herbivore1Carnivore()
        {
            //Assign
            List<Animal> animals = new List<Animal>();
            Bird bird_1 = new Bird("bird_1", 2f, AnimalDiet.Herbivores);
            Bird bird_2 = new Bird("bird_2", 3f, AnimalDiet.Herbivores);
            Amphibian Amphibian_1 = new Amphibian("Amphibian_1", 2.5f, AnimalDiet.Carnivores);

            //Act

            animals.Add(bird_1);
            animals.Add(bird_2);
            animals.Add(Amphibian_1);

            var wagons = WagonFactory.GenerateFilledWagons(animals);
            //Assert
            Assert.IsTrue(wagons.Count == 2);

            foreach (var wagon in wagons)
            {
                var carnivore = wagon.AllAnimals.Where(x => x.AnimalDiet == AnimalDiet.Carnivores).ToList();
                var herbivore = wagon.AllAnimals.Where(x => x.AnimalDiet == AnimalDiet.Herbivores).ToList();

                if (carnivore != null && carnivore.Count > 0)
                {


                    Assert.IsTrue(carnivore.Count == 1);

                    for (int i = 0; i < carnivore.Count; i++)
                    {
                        var herbivoresIsSmaller = herbivore.Any(x => x.Weight < carnivore[i].Weight);

                        // if there is a carnivore in the wagon there can't be a smaller herbivore
                        Assert.IsTrue(herbivoresIsSmaller == false);
                    }

                }


            }
        }

        [TestMethod]
        public void WagonFactory_2Ominvore1Carnivore()
        {
            //Assign
            List<Animal> animals = new List<Animal>();
            Bird bird_1 = new Bird("bird_1", 2f, AnimalDiet.Ominvores);
            Bird bird_2 = new Bird("bird_2", 3f, AnimalDiet.Ominvores);
            Amphibian Amphibian_1 = new Amphibian("Amphibian_1", 2.5f, AnimalDiet.Carnivores);

            //Act

            animals.Add(bird_1);
            animals.Add(bird_1);
            animals.Add(Amphibian_1);

            var wagons = WagonFactory.GenerateFilledWagons(animals);
            //Assert
            Assert.IsTrue(wagons.Count == 2);

            foreach (var wagon in wagons)
            {
                var carnivore = wagon.AllAnimals.Where(x => x.AnimalDiet == AnimalDiet.Carnivores).ToList();
                var ominvore = wagon.AllAnimals.Where(x => x.AnimalDiet == AnimalDiet.Ominvores).ToList();

                if (carnivore != null && carnivore.Count > 0)
                {


                    Assert.IsTrue(carnivore.Count == 1);

                    for (int i = 0; i < carnivore.Count; i++)
                    {
                        var ominvoresIsSmaller = ominvore.Any(x => x.Weight < carnivore[i].Weight);

                        // if there is a carnivore in the wagon there can't be a smaller ominvore
                        Assert.IsTrue(ominvoresIsSmaller == false);
                    }

                }


            }
        }

        [TestMethod]
        public void WagonFactory_3Carnivore()
        {
            //Assign
            List<Animal> animals = new List<Animal>();
            Bird bird_1 = new Bird("test", 1f, AnimalDiet.Carnivores);
            Bird bird_2 = new Bird("test", 2f, AnimalDiet.Carnivores);
            Amphibian Amphibian_1 = new Amphibian("test", 3f, AnimalDiet.Carnivores);

            //Act

            animals.Add(bird_1);
            animals.Add(bird_1);
            animals.Add(Amphibian_1);

            var wagons = WagonFactory.GenerateFilledWagons(animals);
            //Assert
            Assert.IsTrue(wagons.Count == 3);
        }

        [TestMethod]
        public void WagonFactory_3Herbivore()
        {
            //Assign
            List<Animal> animals = new List<Animal>();
            Bird bird_1 = new Bird("test", 10f, AnimalDiet.Herbivores);
            Bird bird_2 = new Bird("test", 10f, AnimalDiet.Herbivores);
            Amphibian Amphibian_1 = new Amphibian("test", 10f, AnimalDiet.Herbivores);

            //Act

            animals.Add(bird_1);
            animals.Add(bird_1);
            animals.Add(Amphibian_1);

            var wagons = WagonFactory.GenerateFilledWagons(animals);
            //Assert
            Assert.IsTrue(wagons.Count == 1);
        }

        [TestMethod]
        public void WagonFactory_3Ominvore()
        {
            //Assign
            List<Animal> animals = new List<Animal>();
            Bird bird_1 = new Bird("test", 10f, AnimalDiet.Ominvores);
            Bird bird_2 = new Bird("test", 10f, AnimalDiet.Ominvores);
            Amphibian Amphibian_1 = new Amphibian("test", 10f, AnimalDiet.Ominvores);

            //Act

            animals.Add(bird_1);
            animals.Add(bird_1);
            animals.Add(Amphibian_1);

            var wagons = WagonFactory.GenerateFilledWagons(animals);
            //Assert
            Assert.IsTrue(wagons.Count == 1);
        }
    }
}
