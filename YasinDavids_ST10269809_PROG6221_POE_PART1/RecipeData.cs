using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YasinDavids_ST10269809_PROG6221_POE_PART1
{
    internal class RecipeData
    {
        // Lists to store recipe data
        List<int> stepNum = new List<int>();
        List<string> stepDescrip = new List<string>();

        //Method takes in step parameters saves it in memory to lists
        public void add(int step, string descrip)
        {
            //Adds method argument to lists
            stepNum.Add(step);
            stepDescrip.Add(descrip);  
        }

        public void display(int i)
        {
            //Prints lists if index is in range
            try
            {
                Console.Write(stepNum[i] + ". ");
                Console.WriteLine(stepDescrip[i]);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
