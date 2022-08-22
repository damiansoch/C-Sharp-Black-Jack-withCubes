// See https://aka.ms/new-console-template for more information

namespace Black_Jack_withCubes


{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome into the BlackJackCube game.");
            Console.WriteLine("Tell me your name.");
            string name = Console.ReadLine();
            while (name == "")
            {
                Console.WriteLine("Please, Tell me your name!");
                name = Console.ReadLine();


            }
            Player player = new Player(name);
        }
    }
}