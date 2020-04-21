using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circus_train.Enums;

namespace Circus_train.Animals
{
    public class Bird : Animal
    {
        public Bird(string name, float weight, AnimalDiet animalDiet) : base(name, weight, animalDiet)
        {
        }
    }
}
