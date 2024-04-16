using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YasinDavids_ST10269809_PROG6221_POE_PART1
{
    internal class Menu
    {
        //instantiate AddRecipe class
        AddRecipe recipe = new AddRecipe();
        IngredientData iData = new IngredientData();
        RecipeData rData = new RecipeData();

        //Prints and selects option from menu
        public void choose()
        {
            // Prints menu
            Console.WriteLine("Press: \n1) Add Recipe \n2) View Recipe");

            // Declarations
            string inputString = Console.ReadLine();
            int input;

            //Matches an input to  a switch case corresponding to the menu
            try
            {
                input = int.Parse(inputString);

                if (input == 1 || input == 2)
                {
                    switch (input)
                    {
                        case 1:

                            Console.WriteLine("Enter name for recipe: ");
                            string name = Console.ReadLine();
                            recipe.addIngredients();
                            recipe.addSteps();
                            break;

                        case 2:
                            Console.WriteLine("Choose how you'd like to scale your recipe:");
                            Console.WriteLine("(0.5)\n(1)\n(2)\n(3)");
                            // Takes input to scale
                            
                            int scale = int.Parse(Console.ReadLine());
                            if (scale == 0.5 || scale == 1|| scale ==2 || scale == 3)
                            {
                                recipe.displayIngredients(scale);
                            } else { Console.WriteLine("Invalid number"); }
                            

                            break;
                    }

                }
                // Exceptions
                else
                {
                    Console.WriteLine("Number not in range");
                }
            }
            catch { Console.WriteLine("Not a number"); }
        }
    }
}
