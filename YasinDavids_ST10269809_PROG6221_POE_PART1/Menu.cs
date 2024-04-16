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
        AddRecipe add = new AddRecipe();

        //Prints menu
        public void print()
        {
            Console.WriteLine("Press: \n1) Add Recipe \n2) View Recipe");
        }

        // ----------------------------------------------------------------------------------------------------------//

        //Selects option from menu
        public void choose()
        {

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
                            add.addIngredients();
                            add.addSteps();
                            add.createRecipe(name);
                            break;

                        case 2:
                            Console.WriteLine("2 chosen");
                            break;
                    }
                    // Exceptions
                }
                else
                {
                    Console.WriteLine("Number not in range");
                }
            }
            catch { Console.WriteLine("Not a number"); }
        }
    }
}
