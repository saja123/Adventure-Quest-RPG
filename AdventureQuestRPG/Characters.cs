using AdventureQuestRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace AdventureQuestRPG
{
    public class Characters : IBattleStates
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        public void CheckExperiencePoints(int Ex)
        {
            ExperiencePoints += Ex;
            if (ExperiencePoints >= Level)
            {
                CheckLevelUp();

            }
        }
        public void CheckLevelUp()
        {
            if (ExperiencePoints >= 30)
            {
                Level = 3;
                Health += 15;
                Defense += 15;
                AttackPower += 5;
                Console.WriteLine($"Congratulations! {Name} !");

            }
            else if (ExperiencePoints >= 20)
            {
                Level = 2;
                Health += 10;
                Defense += 10;
                AttackPower += 5;
                Console.WriteLine($"Congratulations! {Name} leveled up to Level 3!");
            }
            else if (ExperiencePoints >= 10)
            {
                Level = 1;
                Health += 5;
                Defense += 5;
                AttackPower += 5;
                Console.WriteLine($"Congratulations! {Name} leveled up to level 2!");
            }
        }
    }
    // Player Class //
    public class Player : Characters
    {
        public int OregenalHealth { get; set; }
        public Inventory Inventory { get; set; }


        //Constructor 
        public Player()
        {
            OregenalHealth = Health;
            Name = "Hero";
            Health = 100;
            Defense = 20;
            AttackPower = 30;
            OregenalHealth = 100;
            Inventory = new Inventory();
        }
        public void DesblayInfo()
        {
            Console.WriteLine($"Player Name: {Name} , Health: {Health} , Defense: {Defense}, ExperiencePoints: {ExperiencePoints}");
        }
    }

    // Monster abstract Class //
    public abstract class Monster : Characters
    {
        protected Monster(string name, int health, int defense, int attackPower)
        {
            Name = name;
            Health = health;
            Defense = defense;
            AttackPower = attackPower;
        }
        public void DesblayInfo()
        {
            Console.WriteLine($"Monster Name: {Name} , Health: {Health} , Defense: {Defense}");
        }
    }
    // Dragon Class //
    public class Dragon : Monster
    {
        public Dragon() : base("Dragon", 100, 10, 30) { }

        public void DesblayInfo()
        {
            Console.WriteLine($"Monster Name: {Name} , Health: {Health}  , Defense: {Defense}");
        }

    }
    // Falcon Class //
    public class Falcon : Monster
    {
        public Falcon() : base("Falcon", 75, 10, 25) { }
        public void DesblayInfo()
        {
            Console.WriteLine($"Monster Name: {Name} , Health: {Health}  , Defense: {Defense}");
        }
    }

    public class BossMonster : Monster          // BossMonster 
    {
        public BossMonster() : base("Boss Monster", 150, 20, 30) { }
        public void DesblayInfo()
        {
            Console.WriteLine($"Monster Name: {Name} , Health: {Health}  , Defense: {Defense}");
        }
    }
}


