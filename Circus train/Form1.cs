using Circus_train.Animals;
using Circus_train.Animals.Base;
using Circus_train.Enums;
using Circus_train.Wagons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Circus_train
{
    public partial class Form1 : Form
    {
        public List<Animal> totalAnimals;
        public List<CattleWagon> totalWagons;

        public Form1()
        {
            InitializeComponent();
        }


        private void BuildAnimalTree()
        {
            totalAnimals = GenerateRandomAnimals();

            treeView1.Nodes.Clear();

            treeView1.BeginUpdate();
            for (int i = 0; i < totalAnimals.Count; i++)
            {

                treeView1.Nodes.Add(totalAnimals[i].name);
                treeView1.Nodes[i].Nodes.Add("Name: " + totalAnimals[i].animalDiet.ToString());
                treeView1.Nodes[i].Nodes.Add("Type: " + totalAnimals[i].GetType().Name);
                treeView1.Nodes[i].Nodes.Add("Weight: " + totalAnimals[i].weight.ToString() + " KG");
                treeView1.Nodes[i].Nodes.Add("WeightScore: " + totalAnimals[i].WeightScore().ToString() + " Points");

            }
            treeView1.EndUpdate();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            BuildAnimalTree();
        }

        private void GenerateTrainBtn_Click(object sender, EventArgs e)
        {
            if (totalAnimals == null || totalAnimals.Count == 0)
            {
                MessageBox.Show("there are no animals to fill the wagons with!");
                return;
            }

            totalWagons = GenerateWagons(totalAnimals);

            treeView2.Nodes.Clear();

            treeView2.BeginUpdate();

            for (int i = 0; i < totalWagons.Count; i++)
            {
                treeView2.Nodes.Add(totalWagons[i].name);
                for (int j = 0; j < totalWagons[i].animals.Count; j++)
                {
                    Animal animal = totalWagons[i].animals[j];
                    treeView2.Nodes[i].Nodes.Add(animal.name);

                    treeView2.Nodes[i].Nodes[j].Nodes.Add("Weight: " + animal.weight.ToString() + " KG");
                    treeView2.Nodes[i].Nodes[j].Nodes.Add("Type: " + animal.animalDiet.ToString());
                    treeView2.Nodes[i].Nodes[j].Nodes.Add("WeightScore: " + animal.WeightScore().ToString() + " Points");
                }
            }
            treeView2.EndUpdate();
        }


        public List<Animal> GenerateRandomAnimals()
        {
            var result = new List<Animal>();

            Array values = Enum.GetValues(typeof(AnimalDiet));
            Random random = new Random();

            int maxAnimalAmount = 100;

            //Amphibians
            result.AddRange(GetAnimals(values,AnimalNames.Amphibians, maxAnimalAmount,180,0.01f));
            //Reptile
            result.AddRange(GetAnimals(values, AnimalNames.Reptiles, maxAnimalAmount,70));
            //Mammal
            result.AddRange(GetAnimals(values, AnimalNames.Mammals, maxAnimalAmount, 300));
            //Fish
            result.AddRange(GetAnimals(values, AnimalNames.Fishes, maxAnimalAmount, 300));
            //insect
            result.AddRange(GetAnimals(values, AnimalNames.Insects, maxAnimalAmount,100, 0.001f));
            //bird
            result.AddRange(GetAnimals(values, AnimalNames.Birds, maxAnimalAmount, 100));

            return result;
        }

        private  List<Animal> GetAnimals(Array values,string[] type, int maxAnimalAmount,int maxWeight,float weightScale = 1)
        {
            var result = new List<Animal>();
            Random random = new Random();
            for (int a = 0; a < random.Next(0, maxAnimalAmount); a++)
            {
                int index = random.Next(0, type.Length);
                string animalname = type[index];
                AnimalDiet randomAnimalDiet = (AnimalDiet)values.GetValue(random.Next(values.Length));

                Amphibian animal = new Amphibian(animalname, random.Next(1, maxWeight) * weightScale, randomAnimalDiet);
                result.Add(animal);
            }
            return result;
        }

        private List<CattleWagon> GenerateWagons(List<Animal> animals)
        {
            var result = new List<CattleWagon>();

            int count = 0;
            CattleWagon currentWagon = new CattleWagon($"wagon_{count}", 0, 1000);
            result.Add(currentWagon);
            //orders animal list by weight
            var animalsDesc = animals.OrderBy(s => s.weight).ToList();

            while (animalsDesc.Count != 0)
            {
                for (int i = 0; i < animalsDesc.Count; i++)
                {
                    Animal animal = animalsDesc[i];
                    if (!currentWagon.AddAnimal(animal))
                        continue;

                    animalsDesc.Remove(animal);
                }
                //if there are still animals add them to a new wagon 
                if (animalsDesc.Count != 0)
                {
                    count++;
                    currentWagon = new CattleWagon($"wagon_{count}", 0, 1000);
                    result.Add(currentWagon);
                }
            }

            return result;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
