using Circus_train.Animals;
using Circus_train.Animals.Base;
using Circus_train.Enums;
using Circus_train.Factory;
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

            int AnimalAmount = (int)AnimalCount.Value;
            totalAnimals = AnimalFactory.GenerateRandomAnimals(AnimalAmount);

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

        private void BuildWagonTree()
        {
            if (totalAnimals == null || totalAnimals.Count == 0)
            {
                MessageBox.Show("there are no animals to fill the wagons with!");
                return;
            }

            totalWagons = WagonFactory.GenerateFilledWagons(totalAnimals);

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

        private void GenerateAnimalsBtn_Click(object sender, EventArgs e)
        {
            BuildAnimalTree();
        }

        private void GenerateTrainBtn_Click(object sender, EventArgs e)
        {
            BuildWagonTree();
        }
    }
}
