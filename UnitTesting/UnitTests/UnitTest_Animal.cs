using System;
using Circus_train.Animals;
using Circus_train.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.UnitTests
{
    [TestClass]
    public class UnitTest_Animal
    {
        [TestMethod]
        public void Animal_CalculateWeightScore()
        {
            //Assign
            Animal animal1 = new Animal("TestAnimal_1", 1f, AnimalDiet.Herbivores);
            Animal animal2 = new Animal("TestAnimal_2", 100f,  AnimalDiet.Herbivores);
            Animal animal3 = new Animal("TestAnimal_3", 200f, AnimalDiet.Herbivores);

            //Act
            int animal1WeightScore = animal1.WeightScore();
            int animal2WeightScore = animal2.WeightScore();
            int animal3WeightScore = animal3.WeightScore();

            //Assert
            Assert.AreEqual(animal1WeightScore, 1);
            Assert.AreEqual(animal2WeightScore, 3);
            Assert.AreEqual(animal3WeightScore, 5);
        }
    }
}
