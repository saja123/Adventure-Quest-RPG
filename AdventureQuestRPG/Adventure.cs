using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public class Adventure
    {
        public static void Game(Player player)
        {
            Random random = new Random();                                  // Random Monster List
            Monster[] monsters = { new Falcon(), new Dragon(), new BossMonster() };
            int index = random.Next(monsters.Length);
            Monster monster = monsters[index];
            BattleSystem battleSystem = new BattleSystem(); 


            List<string> locations = new List<string>                       // Location List
        {
            "Wadi Rum Desert", "Dead Sea", "Ajloun Forest", "Petra", "Mount Nebo"
        };

            List<string> actions = new List<string>()                      // Action List
        {
            "ChooseLocation", "Attack"
        };
            player.DesblayInfo();
            monster.DesblayInfo();

            Console.WriteLine("\nChoose the Location you want to fight there\n");
            Console.WriteLine("- Dead Sea\n- Wadi Rum Desert\n- Ajloun Forest\n- Petra\n- Mount Nebo");
            Console.Write("Answer Here: ");
            string? chosenLocation = Console.ReadLine();

            while (!locations.Contains(chosenLocation, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("You entered an invalid input. Please choose a valid location:");
                Console.Write("Answer Here: ");
                chosenLocation = Console.ReadLine();
            }
            Console.WriteLine($"Welcome to {chosenLocation}, Play Started");
            battleSystem.StartBattel(monster, player);

            Console.WriteLine($"ExperiencePoints : {player.ExperiencePoints}");

        }
    }
}
