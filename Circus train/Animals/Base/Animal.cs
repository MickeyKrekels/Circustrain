using Circus_train.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_train.Animals
{
    public class Animal
    {
        public string name;
        public float weight;
        public AnimalDiet animalDiet;

        public Animal(string name, float weight, AnimalDiet animalDiet)
        {
            this.name = name;
            this.weight = weight;
            this.animalDiet = animalDiet;
        }

        public int WeightScore()
        {
            int result = 0;

            if (weight <= 10)
            {
                result = 1;
            }
            if (weight > 10 && weight < 150)
            {
                result = 3;
            }
            if (weight >= 150)
            {
                result = 5;
            }


            return result;
        }
    }

}