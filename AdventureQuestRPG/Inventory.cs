using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public class Inventory
    {
        public static void DropInventory(Player player)
        {
            try
            {
                Potions potions = new Potions();
                Armor armor = new Armor();
                Weapons weapons = new Weapons();

                Random random = new Random();                               // Random Items List
                string[] drop = { "Potions", "Armor", "Weapons" };
                int index = random.Next(drop.Length);
                string itemsDropped = drop[index];

                Console.ForegroundColor = ConsoleColor.Cyan;
                if (itemsDropped == "Potions" && player.Level < 3)
                {
                    Console.WriteLine($"Congratulations , You Win In This Level {itemsDropped} Do You Want Use It In Next Level Y/N");
                    Console.Write("Answer Here: ");
                    string response = Console.ReadLine().ToUpper();
                    if (response == "Y")
                    {
                        player.OregenalHealth += 5;
                        potions.Description = "Congratulations We Added +5 on your => ";
                        Console.WriteLine($"{potions.Description} {itemsDropped} !");
                    }

                }
                else if (itemsDropped == "Armor" && player.Level < 3)
                {
                    Console.WriteLine($"Congratulations , You Win In This Level {itemsDropped} Do You Want Use It In Next Level Y/N");
                    Console.Write("Answer Here: ");
                    string response = Console.ReadLine().ToUpper();
                    if (response == "Y")
                    {
                        player.Defense += 5;
                        armor.Description = "Congratulations We Added +5 on your => ";
                        Console.WriteLine($"{armor.Description} {itemsDropped}!");
                    }
                }
                else if (itemsDropped == "Weapon" && player.Level < 3)
                {
                    Console.WriteLine($"Congratulations , You Win In This Level {itemsDropped} Do You Want Use It In Next Level Y/N");
                    Console.Write("Answer Here: ");
                    string response = Console.ReadLine().ToUpper();
                    if (response == "Y")
                    {
                        player.AttackPower += 5;
                        weapons.Description = "Congratulations We Added +5 on your => ";
                        Console.WriteLine($"{weapons.Description} {itemsDropped}!");
                    }
                }
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
