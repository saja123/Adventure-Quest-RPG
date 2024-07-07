namespace AdventureQuestRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool playAgain = true;

                Player player = new Player();
                while (playAgain)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("");


                    if (player.Level <= 2)
                    {
                        Adventure.Game(player);
                        if (player.Level == 3)
                        {
                            Environment.Exit(0);
                        }
                        Console.WriteLine("Would you play again (Y/N)?");
                        Console.Write("Answer Here: ");

                        string response = Console.ReadLine().ToUpper();
                        if (response != "Y")
                        {
                            playAgain = false;
                            Environment.Exit(0);
                        }
                        else if (response == "Y")
                        {
                            player.Health = player.OregenalHealth;
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Match End, Come Back for a new Adventure");

            Console.ReadKey();
        }
    }
}
