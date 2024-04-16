using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YasinDavids_ST10269809_PROG6221_POE_PART1
{
    internal class RecipeDisplay
    {
        // Declarations
        IngredientData ingredient = new IngredientData();
        RecipeData step = new RecipeData();

        
        //method to display ingredients
        public void display(int i)
        {
            try
            {
                Console.WriteLine(ingredient.nameIngredient.Count);
                ingredient.display(i);
            } catch (ArgumentOutOfRangeException ex) { 
                Console.WriteLine(ex.Message);
            }
            
        }

    }
}
