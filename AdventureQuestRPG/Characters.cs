using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AdventureQuestRPG
{
    public class Characters
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public string Defense { get; set; }

        public Characters(string name, int health, string defense)
        {
            Name = name;
            Health = health;
            Defense = defense;
            AttackPower = AtttackPower();

        }
        public int AtttackPower()
        {
            Random random = new Random();
            return random.Next(0,50);
        }
    }
                                    // Player Class //
    public class Player : Characters
    {
        //Constructor 
        public Player(string name, int health,  string defense) :
            base(name, health, defense)
        {
            
        }
        public void DesblayInfo()
        {
            Console.WriteLine($"Player Name: {Name}, Health: {Health}, Defense: {Defense}");
        }
    }
                                // Monster abstract Class //
    public abstract class Monster : Characters
        {
            public Monster(string name, int health, string defense) :
                base(name, health, defense){}
        }
                                     // Dragon Class //
        public class Dragon : Monster
            {
            //Constructor 
        public Dragon(string name, int health,  string defense) :
          base(name, health,  defense){}           
        public void DesblayInfo()
        {
            Console.WriteLine($"Monster Name: {Name} , Health: {Health}  , Defense: {Defense}");
        }
    }

    public class Falcon : Monster 
    {
        public Falcon(string name, int health, string defense) :
            base(name, health, defense)
        {

        } 
        public void DesblayInfo()
        {
            Console.WriteLine($"Monster Name: {Name} , Health: {Health}  , Defense: {Defense}");
        }
    }


}

