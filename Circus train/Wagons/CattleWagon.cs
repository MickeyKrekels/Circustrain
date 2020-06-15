using Circus_train.Animals;
using Circus_train.Base.Wagon;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Circus_train.Wagons
{
    public class CattleWagon : Wagon
    {
        private List<Animal> Animals;
        public ReadOnlyCollection<Animal> AllAnimals
        {
            get { return new ReadOnlyCollection<Animal>(Animals); }
        }

        public int MaxWeightScore { get; set; }

        public CattleWagon(string name, float currentWeight, float maxCarrierWeight, int maxWeightScore = 10) : base(name, currentWeight, maxCarrierWeight)
        {
            Animals = new List<Animal>();
            this.MaxWeightScore = maxWeightScore;
        }
 
        public bool AddAnimal(Animal animal)
        {
            //check if animal can be added 
            if ((CurrentWeight + animal.Weight) > MaxCarrierWeight ||
               (CalculateTotalWeightScores() + animal.WeightScore()) > MaxWeightScore)
                return false;

            if (animal.AnimalDiet == Enums.AnimalDiet.Carnivores
               && !CheckRoomForCarnivore(animal))
                return false;

            if (!CheckRoomForNonCarnivores(animal))
                return false;

            //increase total weight
            CurrentWeight += animal.Weight;
            Animals.Add(animal);
            return true;
        }

        private int CalculateTotalWeightScores()
        {
            int result = 0;

            foreach (var animal in Animals)
            {
                result += animal.WeightScore();
            }
            return result;

        }

        private bool CheckRoomForCarnivore(Animal animal)
        {           
            var Carnivores = Animals.Where(x => x.AnimalDiet == Enums.AnimalDiet.Carnivores).ToList();
            bool IsAnyHerbivoreSmaller = Animals.Any(x => x.Weight <= animal.Weight);

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
            var Carnivores = Animals.Where(x => x.AnimalDiet == Enums.AnimalDiet.Carnivores).ToList();
            bool isCarnivoreBigger = Animals.Any(x => x.Weight >= animal.Weight && x.AnimalDiet == Enums.AnimalDiet.Carnivores);

            if (Carnivores == null)
                return true;

            if (isCarnivoreBigger)
                return false;

            return true;


        }

    }
}
