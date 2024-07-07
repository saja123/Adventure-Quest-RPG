using AdventureQuestRPG;

namespace AdventureQuestRPGTests
{
    public class UnitTest1
    {
        [Fact]
        public void PlayerAttacks()
        {
            //Arreng
            Player player = new Player();
            Dragon dragon = new Dragon();
            //Act
            BattleSystem battle = new BattleSystem();
            battle.Attack(player, dragon);

            //Assert
            Assert.True(dragon.Health < 100);

        }
        [Fact]
        public void EnemyAttack()
        {
            //Arreng
            Player player = new Player();
            Dragon dragon = new Dragon();
            
            //Act
            BattleSystem battleSystem = new BattleSystem();
            battleSystem.Attack(dragon, player);
            
            //Assert
            Assert.True(player.Health < 100);
        }

        [Fact]
        public void WinnerHasHhealthGreaterThanZero()
        {
            //Arreng
            Player player = new Player();
            Dragon dragon = new Dragon();
            BattleSystem battleSystem = new BattleSystem();

            //Act
            battleSystem.Attack(player, dragon);

            //Assert
            Assert.True(player.Health > 0 || dragon.Health >0);
        }

        [Fact]
        public void TestBossMonster()
        {
            //Arreng
            Player player = new Player();
            Monster boosMonster = new BossMonster();
            BattleSystem battle = new BattleSystem();

            //Act
            battle.StartBattel(boosMonster, player);

            //Assert
            Assert.True(boosMonster.Health == 0 || player.Health == 0);
        }

        [Fact]
        public void TestMoveToLocation()
        {
            //Arrang
            List<string> locations = new List<string> { "Wadi Rum Desert", "Dead Sea", "Ajloun Forest", "Petra", "Mount Nebo" };// Location List
            string choos = "Dead Sea";

            //Act
            while (!locations.Contains(choos, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("invalid input");
            }

            //Assert
            Assert.True(choos == "Dead Sea");

        }

    }
}