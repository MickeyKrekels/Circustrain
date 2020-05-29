using System;
using System.Collections.Generic;
using Circus_train.Animals;
using Circus_train.Animals.Base;
using Circus_train.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.UnitTests
{
    [TestClass]
    public class UnitTest_AnimalFactory
    {
        [TestMethod]
        public void AnimalFactory_GenerateRandomAnimals_NotNull()
        {
            //Assign
            var fishNames = AnimalNames.Fishes;
            var birdNames = AnimalNames.Birds;
            var mammalNames = AnimalNames.Mammals;
            var insectNames = AnimalNames.Insects;
            var reptileNames = AnimalNames.Reptiles;
            var amphibianNames = AnimalNames.Amphibians;


            //Act
            var fish = AnimalFactory.GenerateAnimals("Fish", fishNames, 5, 300);
            var bird = AnimalFactory.GenerateAnimals("Bird", birdNames, 5, 300);
            var mammal = AnimalFactory.GenerateAnimals("Mammal", mammalNames, 5, 300);
            var insect = AnimalFactory.GenerateAnimals("Insect", insectNames, 5, 300);
            var reptile = AnimalFactory.GenerateAnimals("Reptile", reptileNames, 5, 300);
            var amphibian = AnimalFactory.GenerateAnimals("Amphibian", amphibianNames, 5, 300);

            Assert.IsTrue(fish != null);
            Assert.IsTrue(bird != null);
            Assert.IsTrue(mammal != null);
            Assert.IsTrue(insect != null);
            Assert.IsTrue(reptile != null);
            Assert.IsTrue(amphibian != null);
        }
        [TestMethod]
        public void AnimalFactory_GenerateRandomAnimals_CheckCount()
        {
            //Assign
            var fishNames = AnimalNames.Fishes;
            var birdNames = AnimalNames.Birds;
            var mammalNames = AnimalNames.Mammals;
            var insectNames = AnimalNames.Insects;
            var reptileNames = AnimalNames.Reptiles;
            var amphibianNames = AnimalNames.Amphibians;
            List<Animal> animals = new List<Animal>();

            //Act
            var fish = AnimalFactory.GenerateAnimals("Fish", fishNames, 5, 300);
            animals.AddRange(fish);
            var bird = AnimalFactory.GenerateAnimals("Bird", birdNames, 5, 300);
            animals.AddRange(bird);
            var mammal = AnimalFactory.GenerateAnimals("Mammal", mammalNames, 5, 300);
            animals.AddRange(mammal);
            var insect = AnimalFactory.GenerateAnimals("Insect", insectNames, 5, 300);
            animals.AddRange(insect);
            var reptile = AnimalFactory.GenerateAnimals("Reptile", reptileNames, 5, 300);
            animals.AddRange(reptile);
            var amphibian = AnimalFactory.GenerateAnimals("Amphibian", amphibianNames, 5, 300);
            animals.AddRange(amphibian);

            //Assert
            Assert.IsTrue(animals.Count == 30);
        }
        [TestMethod]
        public void AnimalFactory_GenerateRandomAnimals_CheckWeight()
        {
            //Assign
            var fishNames = AnimalNames.Fishes;
            var birdNames = AnimalNames.Birds;
            var mammalNames = AnimalNames.Mammals;
            var insectNames = AnimalNames.Insects;
            var reptileNames = AnimalNames.Reptiles;
            var amphibianNames = AnimalNames.Amphibians;
            List<Animal> animals = new List<Animal>();

            //Act
            var fish = AnimalFactory.GenerateAnimals("Fish", fishNames, 5, 300);
            animals.AddRange(fish);
            var bird = AnimalFactory.GenerateAnimals("Bird", birdNames, 5, 300);
            animals.AddRange(bird);
            var mammal = AnimalFactory.GenerateAnimals("Mammal", mammalNames, 5, 300);
            animals.AddRange(mammal);
            var insect = AnimalFactory.GenerateAnimals("insect", insectNames, 5, 300);
            animals.AddRange(insect);
            var reptile = AnimalFactory.GenerateAnimals("Reptile", reptileNames, 5, 300);
            animals.AddRange(reptile);
            var amphibian = AnimalFactory.GenerateAnimals("Amphibian", amphibianNames, 5, 300);
            animals.AddRange(amphibian);

            //Assert
            foreach (var animal in animals)
            {
                Assert.IsTrue(animal.Weight <= 300);
            }
         
        }
        [TestMethod]
        public void AnimalFactory_GenerateRandomAnimals_CheckAnimalType()
        {
            //Assign
            var fishNames = AnimalNames.Fishes;
            var birdNames = AnimalNames.Birds;
            var mammalNames = AnimalNames.Mammals;
            var insectNames = AnimalNames.Insects;
            var reptileNames = AnimalNames.Reptiles;
            var amphibianNames = AnimalNames.Amphibians;


            //Act
            var fish = AnimalFactory.GenerateAnimals("Fish", fishNames, 5, 300);
            var bird = AnimalFactory.GenerateAnimals("Bird", birdNames, 5, 300);
            var mammal = AnimalFactory.GenerateAnimals("Mammal", mammalNames, 5, 300);
            var insect = AnimalFactory.GenerateAnimals("insect", insectNames, 5, 300);
            var reptile = AnimalFactory.GenerateAnimals("Reptile", reptileNames, 5, 300);
            var amphibian = AnimalFactory.GenerateAnimals("Amphibian", amphibianNames, 5, 300);

            //Assert
            foreach (var animal in fish)
            {
                Assert.IsTrue(animal is Fish);
            }
            foreach (var animal in bird)
            {
                Assert.IsTrue(animal is Bird);
            }
            foreach (var animal in mammal)
            {
                Assert.IsTrue(animal is Mammal);
            }
            foreach (var animal in insect)
            {
                Assert.IsTrue(animal is Insect);
            }
            foreach (var animal in reptile)
            {
                Assert.IsTrue(animal is Reptile);
            }
            foreach (var animal in amphibian)
            {
                Assert.IsTrue(animal is Amphibian);
            }

        }
    }
}
