using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YasinDavids_ST10269809_PROG6221_POE_PART1
{
    internal class AddRecipe
    {
        //Declarations
        IngredientData iData = new IngredientData();

        public void addIngredients()
        {
            int ingAmt = 0;
            //Boolean to test try catch loop
            bool conditionMet = false;

            while (!conditionMet)
            {
                // Takes input for amount of ingredients
                Console.WriteLine("How many ingredients are in the recipe?: ");
                try
                {
                    //Takes in amount of ingredients   
                    ingAmt = int.Parse(Console.ReadLine());
                    conditionMet = true;
                }
                catch (FormatException e)
                {
                    Console.Write(e.Message); Console.WriteLine("Please enter a valid number");
                }
            }
            // Lets user enter each ingredient
            for (int j = 0; j < ingAmt; j++)
            {
                //Inputs for iData 
                string name = "";
                int amount = 0;
                string unit = "";

                conditionMet = false;

                Console.WriteLine("-------------------------------------------------\n ", ingAmt, ") Please enter ingredient details: ");

                // Takes user input for ingredient name
                Console.WriteLine("Ingredient name:");
                while (!conditionMet)
                {
                    try
                    {
                        //stores input
                        name = Console.ReadLine();
                        //checks condition as true
                        conditionMet = true;
                    }
                    catch (Exception ex)
                    {
                        // Catch any other exceptions
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }

                // Takes user input for ingredient unit
                Console.WriteLine("Unit ingredient is measured in (ie cups/tblspn):");
                conditionMet = false;
                while (!conditionMet)
                {
                    try
                    {
                        //Stores input to variable
                        unit = Console.ReadLine();
                        //checks condition as true
                        conditionMet = true;
                    }
                    catch (Exception ex)
                    {
                        // Catch any other exceptions
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }

                conditionMet = false;
                Console.WriteLine("Amount of units of ingredient:");
                while (!conditionMet)
                {
                    try
                    {
                        // stores input
                        amount = int.Parse(Console.ReadLine());
                        conditionMet = true;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Please enter a VALID number");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                        Console.WriteLine("Please enter a VALID number");
                    }

                }

                // Adds ingredients to list
                iData.add(name, amount, unit);
            }
        }
    }
}
