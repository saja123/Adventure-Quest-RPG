using AdventureQuestRPG;

namespace AdventureQuestRPGTests
{
    public class UnitTest1
    {
        [Fact]
        public void PlayerAttacks()
        {
            //Arreng
            Player player = new Player("Hero", 100, "Sword");
            Dragon dragon = new Dragon("Dragon", 100, "Scales");

            //Act
            BattleSystem battleSystem = new BattleSystem();
            battleSystem.Attack(player,dragon);

            //Assert
            Assert.True(dragon.Health < 100);

        }
        [Fact]
        public void EnemyAttack()
        {
            //Arreng
            Player player = new Player("Hero", 100, "Sword");
            Dragon dragon = new Dragon("Dragon", 100, "Scales");
            
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
            Player player = new Player("Hero", 100, "Sword");
            Dragon dragon = new Dragon("Dragon", 100, "Scales");

            //Act
            BattleSystem battleSystem = new BattleSystem();
            battleSystem.Attack(player, dragon);

            //Assert
            Assert.True(player.Health > 0 || dragon.Health >0);
        }

        [Fact]
        public void TestBossMonster()
        {
            //Arreng
            Player player = new Player();
            Monster boosMonster = new Eagle();

            //Act
            BattleSystem.StartBattel(boosMonster, player);

            //Assert
            Assert.True(boosMonster.Health == 0 || player.Health == 0);
        }

        [Fact]
        public void TestMoveToLocation()
        {
            //Arrang
            List<string> locations = new List<string> { "WadiRumDesert", "DeadSea", "AjlounForest", "Petra", "MountNebo" };// Location List
            string choos = "DeadSea";

            //Act
            while (!locations.Contains(choos, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("invalid input");
            }

            //Assert
            Assert.True(choos == "DeadSea");

        }

    }
}