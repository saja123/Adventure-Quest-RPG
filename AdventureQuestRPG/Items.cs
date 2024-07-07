using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public abstract class Items
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class Potions : Items
    {
        public int HealthDrop { get; set; }
    }

    public class Armor : Items
    {
        public int DefenseDrop { get; set; }
    }
    public class Weapons : Items
    {
        public int AttackPower { get; set; }
    }
}
