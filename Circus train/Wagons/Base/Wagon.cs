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
        public string Name { get; protected set; }
        public float CurrentWeight { get; protected set; }
        public float MaxCarrierWeight { get; protected set; }

        public Wagon(string name, float currentWeight, float maxCarrierWeight)
        {
            this.Name = name;
            this.CurrentWeight = currentWeight;
            this.MaxCarrierWeight = maxCarrierWeight;
        }
    }
}
