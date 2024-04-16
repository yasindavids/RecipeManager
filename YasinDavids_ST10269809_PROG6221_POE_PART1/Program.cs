namespace YasinDavids_ST10269809_PROG6221_POE_PART1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Recipe Manager!");
            //Instantiating menu class
            Menu menu = new Menu();
            IngredientData data = new IngredientData();
            RecipeDisplay blah = new RecipeDisplay();




            menu.print();
            menu.choose();

        }
    }
}
