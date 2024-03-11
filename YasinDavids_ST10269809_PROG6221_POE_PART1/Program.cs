namespace YasinDavids_ST10269809_PROG6221_POE_PART1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Recipe Manager!");
            IngredientData data = new IngredientData();
            data.add("Rice", 2, "cup");
            data.display(0);
        }
    }
}
