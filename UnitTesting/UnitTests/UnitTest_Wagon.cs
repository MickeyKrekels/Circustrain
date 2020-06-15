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
    public class UnitTest_Wagon
    {
        [TestMethod]
        public void CattleWagon_FillToMaxWeight()
        {
            //Assign
            CattleWagon cattleWagon = new CattleWagon("testCattleWagon", 0,100);
            Animal animal = new Animal("testAnimal", 100, AnimalDiet.Ominvores);
            bool added = false;
            //Act
            added = cattleWagon.AddAnimal(animal);

            //Assert
            Assert.IsTrue(added);
        }

        [TestMethod]
        public void CattleWagon_OverFillMaxWeight()
        {
            //Assign
            CattleWagon cattleWagon = new CattleWagon("testCattleWagon", 0, 100);
            Animal animal1 = new Animal("testAnimal1", 100, AnimalDiet.Ominvores);
            Animal animal2 = new Animal("testAnimal2", 100, AnimalDiet.Ominvores);
            bool added = false;
            //Act
            added = cattleWagon.AddAnimal(animal1);
            added = cattleWagon.AddAnimal(animal2);
            //Assert
            Assert.IsFalse(added);
        }

        [TestMethod]
        public void CattleWagon_FillToMaxWeightScore()
        {
            //Assign
            List<Animal> animals = new List<Animal>();
            //Act
            for (int i = 0; i < 10; i++)
            {
                Animal animal = new Animal("testAnimal", 5, AnimalDiet.Herbivores);
                animals.Add(animal);
            }
            var result = WagonFactory.GenerateFilledWagons(animals);

            //Assert
            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result[0].AllAnimals.Count == 10);
        }

        [TestMethod]
        public void CattleWagon_MoreThanOneCarnivores()
        {
            //Assign
            CattleWagon cattleWagon = new CattleWagon("testCattleWagon", 0, 1000);
            Animal animal1 = new Animal("testAnimal1", 100, AnimalDiet.Carnivores);
            Animal animal2 = new Animal("testAnimal1", 100, AnimalDiet.Carnivores);
            bool added = false;

            //Act
            added = cattleWagon.AddAnimal(animal1);
            added = cattleWagon.AddAnimal(animal2);

            //Assert
            Assert.IsFalse(added);
        }

        [TestMethod]
        public void CattleWagon_SmallerHerbivoreAndCarnivores()
        {
            //Assign
            CattleWagon cattleWagon = new CattleWagon("testCattleWagon", 0, 1000);
            Animal animal1 = new Animal("testAnimal1", 100, AnimalDiet.Carnivores);
            Animal animal2 = new Animal("testAnimal1", 10, AnimalDiet.Herbivores);
            bool added = false;

            //Act
            added = cattleWagon.AddAnimal(animal1);
            added = cattleWagon.AddAnimal(animal2);

            //Assert
            Assert.IsFalse(added);
        }

        [TestMethod]
        public void CattleWagon_BiggerHerbivoreAndCarnivores()
        {
            //Assign
            CattleWagon cattleWagon = new CattleWagon("testCattleWagon", 0, 1000);
            Animal animal1 = new Animal("testAnimal1", 100, AnimalDiet.Carnivores);
            Animal animal2 = new Animal("testAnimal1", 200, AnimalDiet.Herbivores);
            bool added = false;

            //Act
            added = cattleWagon.AddAnimal(animal1);
            added = cattleWagon.AddAnimal(animal2);

            //Assert
            Assert.IsTrue(added);
        }

    }
}
