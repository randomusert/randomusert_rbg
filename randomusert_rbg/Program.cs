namespace randomusert_rbg
{
    internal class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.WriteLine("randomusert's rbg based on console");
            Console.WriteLine("What will be your player name?");
            Console.WriteLine("Name:");
            currentPlayer.name = Console.ReadLine();
            Console.WriteLine("Welcome,"+ currentPlayer.name);
            Console.WriteLine("You were outside when atack came and well atacked the village!");
            Console.WriteLine("What thinked then?");

        }
    }
}