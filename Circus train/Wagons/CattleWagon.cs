using Circus_train.Animals;
using Circus_train.Base.Wagon;
using System.Collections.Generic;
using System.Linq;

namespace Circus_train.Wagons
{
    public class CattleWagon : Wagon
    {
        public List<Animal> animals;
        public int weightScore;

        public CattleWagon(string name, float currentWeight, float maxCarrierWeight, int weightScore = 10) : base(name, currentWeight, maxCarrierWeight)
        {
            animals = new List<Animal>();
            this.weightScore = weightScore;
        }

        public bool AddAnimal(Animal animal)
        {
            //check if animal can be added 
            if ((currentWeight + animal.weight) > maxCarrierWeight ||
               (CalculateTotalWeightScores() + animal.WeightScore()) > 10)
                return false;

            if (animal.animalDiet == Enums.AnimalDiet.Carnivores
               && !CheckRoomForCarnivore(animal))
                return false;

            if (!CheckRoomForNonCarnivores(animal))
                return false;

            //increase total weight
            currentWeight += animal.weight;
            animals.Add(animal);
            return true;
        }

        private int CalculateTotalWeightScores()
        {
            int result = 0;

            foreach (var animal in animals)
            {
                result += animal.WeightScore();
            }
            return result;

        }

        private bool CheckRoomForCarnivore(Animal animal)
        {           
            var Carnivores = animals.Where(x => x.animalDiet == Enums.AnimalDiet.Carnivores).ToList();
            bool IsAnyHerbivoreSmaller = animals.Any(x => x.weight <= animal.weight);

            //if there is no Carnivore in the wagon there is room
            if (Carnivores == null)
                return true;
            //if there is more already 1 Carnivore there is no room
            if (Carnivores.Count >= 1)
                return false;
            //if any of the Herbivore is smaller there is no room
            if (IsAnyHerbivoreSmaller)
                return false;

            //there is room for the Carnivore
            return true;
        }

        private bool CheckRoomForNonCarnivores(Animal animal)
        {
            var Carnivores = animals.Where(x => x.animalDiet == Enums.AnimalDiet.Herbivores).ToList();
            bool isCarnivoreBigger = animals.Any(x => x.weight >= animal.weight && x.animalDiet == Enums.AnimalDiet.Carnivores);
            if (Carnivores == null)
                return true;

            if (isCarnivoreBigger)
                return false;

            return true;


        }

    }
}
