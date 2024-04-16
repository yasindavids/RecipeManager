using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            Console.WriteLine("\nPress: \n1) Add Recipe (Will clear any previously entered recipe) \n2) View Recipe\n3) Quit Program");

            // Declarations
            string inputString = Console.ReadLine();
            int input;

            //Matches an input to  a switch case corresponding to the menu
            try
            {
                input = int.Parse(inputString);

                if (input == 1 || input == 2 || input == 3)
                {
                    switch (input)
                    {
                        case 1:
                            // Clears out lists and lets user enter
                            recipe.erase();
                            Console.WriteLine("Enter name for recipe: ");
                            // Calls addIngredient and addSteps methods
                            recipe.addIngredients();
                            recipe.addSteps();
                            break;

                        case 2:
                            Console.WriteLine("Choose how you'd like to scale your recipe:");
                            Console.WriteLine("(0.5)\n(1)\n(2)\n(3)");
                            // Takes input to scale
                            
                            int scale = int.Parse(Console.ReadLine());
                            //Scales the ingredients according to user choice
                            if (scale == 0.5 || scale == 1|| scale ==2 || scale == 3)
                            {
                                recipe.displayIngredients(scale);
                                recipe.displayRecipe();
                                //gives option to reset scaling if not already 1
                                if (scale != 1)
                                {
                                    Console.WriteLine("\nDo you want to reset the scaling? Y for yes.");
                                    string input2 = Console.ReadLine();
                                    if (input2 == "Y" || input2 == "y")
                                    {
                                        recipe.displayIngredients(1);
                                        recipe.displayRecipe();
                                    }
                                }
                                //Exception
                            } else { Console.WriteLine("Invalid number"); }
                            break;
                        case 3:
                            // Exit the program
                            Environment.Exit(0);
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
