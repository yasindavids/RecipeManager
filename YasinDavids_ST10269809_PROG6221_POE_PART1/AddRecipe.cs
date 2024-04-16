using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace YasinDavids_ST10269809_PROG6221_POE_PART1
{
    internal class AddRecipe
    {
        //Declarations
        IngredientData iData = new IngredientData();
        RecipeData rData = new RecipeData();
        //List of recipe names
        List<string> displayName = new List<string>();

        // Method stores inputs to lists in RecipeData
        public void addSteps()
        {
            int stepNum = 0;
            bool conditionMet = false;

            while (!conditionMet)
            {
                // Takes input for amount of ingredients
                Console.WriteLine("How many steps are in the recipe?: ");
                try
                {
                    //Takes in amount of ingredients   
                    stepNum = int.Parse(Console.ReadLine());
                    conditionMet = true;
                }
                catch (FormatException e)
                {
                    Console.Write(e.Message); Console.WriteLine("Please enter a valid number");
                }
            }

            for (int j = 0; j < stepNum; j++)
            {
                //Declarations
                int step = j + 1;
                string descrip = "";

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine($"Please enter details for step {step}\n");

                // Takes user input for step description
                Console.WriteLine("Step " + step + " Description:");
                // reset conditionMet
                conditionMet = false;

                while (!conditionMet)
                {
                    try
                    {
                        //stores input
                        descrip = Console.ReadLine();
                        //checks condition as true
                        conditionMet = true;
                    }
                    catch (Exception ex)
                    {
                        // Catch any other exceptions
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
                rData.add(descrip);
            }

        }
        // ----------------------------------------------------------------------------------------------------------//

        // Method stores inputs to lists in IngredientData
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

                // reset conditionMet
                conditionMet = false;

                Console.WriteLine("------------------------------------------------- ");
                Console.WriteLine("Please enter ingredient details\n");

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

                // reset conditionMet
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

                // reset conditionMet
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
                Console.WriteLine("------------------------------------------------- ");
            }

        }

        // ----------------------------------------------------------------------------------------------------------//

        // Method takes in int and prints corresponding list elements
        public void displayIngredients(int scale)
        {

            Console.WriteLine("-----------------------\n INGREDIENTS \n-----------------------");
            // Prints lists if index is in range
            for (int i = 0; i < iData.amtIngredient.Count; i++)
            {
                try
                {

                    Console.Write((iData.amtIngredient[i] * scale) + " ");
                    Console.WriteLine(iData.unitIngredient[i] + "s " + iData.nameIngredient[i] + "\n");

                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }

        // ----------------------------------------------------------------------------------------------------------//

        public void displayRecipe()
        {
            Console.WriteLine("-----------------------\n RECIPE \n-----------------------");
            //Prints lists if index is in range
            for (int i = 0; i < rData.stepDescrip.Count; i++)
            {
                try
                {
                    Console.Write(rData.stepNum[i] + ". ");
                    Console.WriteLine(rData.stepDescrip[i]);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }

    }
}
