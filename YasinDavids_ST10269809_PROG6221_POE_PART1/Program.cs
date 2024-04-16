namespace YasinDavids_ST10269809_PROG6221_POE_PART1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Recipe Manager!");
            //Instantiating menu class
            Menu menu = new Menu();

            // While loop to run indefinitely until user exits
            bool run = true;
            while (run)
            {
                // Calls choose method
                menu.choose();
            }


        }
    }
}
