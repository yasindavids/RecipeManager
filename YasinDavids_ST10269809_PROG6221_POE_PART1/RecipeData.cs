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
        public List<int> stepNum = new List<int>();
        public List<string> stepDescrip = new List<string>();

        //Method takes in step parameters saves it in memory to lists
        public void add(string descrip)
        {
            stepDescrip.Add(descrip);
        }


    }
}
