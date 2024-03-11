using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YasinDavids_ST10269809_PROG6221_POE_PART1
{
    internal class IngredientData
    {
        // Lists to store ingredient data
        List<string> nameIngredient = new List<string>();
        List<int> amtIngredient = new List<int>();
        List<string> unitIngredient = new List<string>();

        // Method takes in ingredient parameters and saves it in memory to lists
        public void add(string name, int amount, string unit)
        {
            //Adds method argument to lists          
                nameIngredient.Add(name);
                amtIngredient.Add(amount);
                unitIngredient.Add(unit);         
        }

        // Method takes in int and prints corresponding list elements
        public void display(int i)
        {
            //Prints lists if index is in range
            try
            {
                Console.Write(nameIngredient[i] + ", ");
                Console.Write(amtIngredient[i] + ", ");
                Console.WriteLine(unitIngredient[i]);
            } catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: list issue");
            }
        }
    }
}
