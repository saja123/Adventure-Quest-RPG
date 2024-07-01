# AdventureQuestRPG

## Overview
AdventureQuestRPG is a simple console-based role-playing game where players engage in battles with various monsters. The game features a player character and different types of monsters, managed by a battle system that handles turn-based combat.

## Program Structure
### Main Program
The entry point of the game is the Program class, where the game initializes and starts. The Main method performs the following actions:

Creates instances of the player and monsters.
Displays their information.
Initiates battles using the BattleSystem class.
Includes error handling to catch and display exceptions.

## Player and Monster Classes
### Characters Class:

The base class for all characters in the game, including the player and monsters.
Defines common properties: Name, Health, AttackPower, and Defense.
Attack power is randomly generated when an instance is created.

### Player Class:

Inherits from the Characters class and represents the player.
Includes a method to display player information.

### Monster Class:

An abstract class inheriting from the Characters class.
Serves as a base for specific types of monsters.

### Dragon Class:

Inherits from the Monster class and represents a dragon.
Includes a method to display the dragon's information.

### Falcon Class:

Inherits from the Monster class and represents a falcon.
Includes a method to display the falcon's information.
Battle System
The BattleSystem class manages the combat between the player and monsters, featuring the following methods:

### StartBattle Method:

Manages turn-based combat between the player and the enemy.
Continues until either the player's or the enemy's health drops to zero.
Handles both the player's and the enemy's turns, displaying appropriate messages for each turn and the outcome of the battle.
### Attack Method:

Calculates and applies damage from the attacker to the target.
Updates the target's health and displays the result of the attack.
### CalculateDamage Method:

Returns the attack power of the attacker, determining the damage dealt.
Error Handling
The game includes error handling in the main program and the battle system to catch and display any exceptions that occur during execution.

## Console Output
The game uses console output to:

Display information about the characters.
Indicate turns in the battle.
Show the damage dealt.
Announce the outcome of the battle.
Different console colors are used to differentiate various types of messages, such as turns, attacks, and outcomes, enhancing the gameplay experience.

## Example Image [Link](https://github.com/Abed1313/Adventure-Quest-RPG/blob/AdventureQuest-part1/assest/lap6.2.PNG)
