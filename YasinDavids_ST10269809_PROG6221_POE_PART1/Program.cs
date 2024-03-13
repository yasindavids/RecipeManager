namespace YasinDavids_ST10269809_PROG6221_POE_PART1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Recipe Manager!");
            IngredientData ingredient = new IngredientData();
            RecipeData step = new RecipeData();
            RecipeDisplay recipe = new RecipeDisplay();

            ingredient.add("Rice", 2, "cup");
            ingredient.display(0);
            

            recipe.display(0);

        }
    }
}
