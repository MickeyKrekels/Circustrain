using Circus_train.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_train.Base.Wagon
{
    public class Wagon
    {
        public readonly string name;
        protected float currentWeight;
        protected float maxCarrierWeight;

        public Wagon(string name, float currentWeight, float maxCarrierWeight)
        {
            this.name = name;
            this.currentWeight = currentWeight;
            this.maxCarrierWeight = maxCarrierWeight;
        }
    }
}
