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
        public string Name { get; set; }
        protected float CurrentWeight { get; set; }
        protected float MaxCarrierWeight { get; set; }

        public Wagon(string name, float currentWeight, float maxCarrierWeight)
        {
            this.Name = name;
            this.CurrentWeight = currentWeight;
            this.MaxCarrierWeight = maxCarrierWeight;
        }
    }
}
