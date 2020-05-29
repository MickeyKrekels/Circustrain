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
        public string Name { get; set; }
        public float Weight { get; set; }
        public AnimalDiet AnimalDiet { get; set; }

        public Animal(string name, float weight, AnimalDiet animalDiet)
        {
            this.Name = name;
            this.Weight = weight;
            this.AnimalDiet = animalDiet;
        }

        public int WeightScore()
        {
            int result = 0;

            if (Weight <= 10)
            {
                result = 1;
            }
            if (Weight > 10 && Weight < 150)
            {
                result = 3;
            }
            if (Weight >= 150)
            {
                result = 5;
            }


            return result;
        }
    }

}