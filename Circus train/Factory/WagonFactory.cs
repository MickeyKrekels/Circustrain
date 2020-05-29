using Circus_train.Animals;
using Circus_train.Wagons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_train.Factory
{
    public static class WagonFactory
    {
        public static List<CattleWagon> GenerateFilledWagons(List<Animal> animals)
        {
            var result = new List<CattleWagon>();

            int count = 0;
            CattleWagon currentWagon = new CattleWagon($"wagon_{count}", 0, 1000);
            result.Add(currentWagon);

            //orders animal list by weight
            var animalsDesc = animals.OrderBy(s => s.Weight).ToList();
            while (animalsDesc.Count != 0)
            {

                for (int i = 0; i < animalsDesc.Count; i++)
                {
                    Animal animal = animalsDesc[i];

                    if (currentWagon.AddAnimal(animal))
                    {
                        animalsDesc.Remove(animal);
                        //reset the index 
                        i = -1;
                    }
                }

                //if there are still animals add them to a new wagon 
                if (animalsDesc.Count > 0)
                {
                    count++;
                    currentWagon = new CattleWagon($"wagon_{count}", 0, 1000);
                    result.Add(currentWagon);
                }
            }

            return result;
        }

    }
}
