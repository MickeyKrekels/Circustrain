using System;
using System.Collections.Generic;
using Circus_train.Animals;
using Circus_train.Enums;
using Circus_train.Factory;
using Circus_train.Wagons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.UnitTests
{
    [TestClass]
    public class UnitTest_WagonFactory
    {
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
            Assert.IsTrue(wagons[1].AllAnimals[0].AnimalDiet == AnimalDiet.Carnivores);
        }

        [TestMethod]
        public void WagonFactory_2Ominvore1Carnivore()
        {
            //Assign
            List<Animal> animals = new List<Animal>();
            Bird bird_1 = new Bird("test", 2f, AnimalDiet.Ominvores);
            Bird bird_2 = new Bird("test", 3f, AnimalDiet.Ominvores);
            Amphibian Amphibian_1 = new Amphibian("test", 2.5f, AnimalDiet.Carnivores);

            //Act

            animals.Add(bird_1);
            animals.Add(bird_1);
            animals.Add(Amphibian_1);

            var wagons = WagonFactory.GenerateFilledWagons(animals);
            //Assert
            Assert.IsTrue(wagons.Count == 2);
            Assert.IsTrue(wagons[1].AllAnimals[0].AnimalDiet == AnimalDiet.Carnivores);
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
