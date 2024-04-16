using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YasinDavids_ST10269809_PROG6221_POE_PART1
{
    internal class IngredientData
    {
        // Lists to store ingredient data
        public List<string> nameIngredient = new List<string>();
        public List<int> amtIngredient = new List<int>();
        public List<string> unitIngredient = new List<string>();

        // Method takes in ingredient parameters and saves it in memory to lists
        public void add(string name, int amount, string unit)
        {
            //Adds method argument to lists          
            nameIngredient.Add(name);
            amtIngredient.Add(amount);
            unitIngredient.Add(unit);
        }

        
    }
}
