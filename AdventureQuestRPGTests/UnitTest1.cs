using AdventureQuestRPG;

namespace AdventureQuestRPGTests
{
    public class UnitTest1
    {
        [Fact]
        public void PlayerAttacks()
        {
            //Arreng
            Player player = new Player("Abood", 100, "Sword");
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
            Player player = new Player("Abood", 100, "Sword");
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
            Player player = new Player("Abood", 100, "Sword");
            Dragon dragon = new Dragon("Dragon", 100, "Scales");

            //Act
            BattleSystem battleSystem = new BattleSystem();
            battleSystem.Attack(player, dragon);

            //Assert
            Assert.True(player.Health > 0 || dragon.Health >0);
        }

        

    }
}