﻿Console.WriteLine("Welcome to Alverdale, please enter you Player name:");
string playerName = Console.ReadLine();






Random rand = new Random();
string choice;
int playerAttackPoints, monsterAttackPoints, lvlCaps;
int playerHP = 10, monsterHP = 10, playerLvl = 0, monsterLvl = 0, playerExp = 0;

do
{
    do
    {
        playerAttackPoints = rand.Next(1, 11);

        monsterHP = monsterHP - playerAttackPoints;
        if (monsterHP < 0)
        {
            monsterHP = 0;
        }
        Console.WriteLine($"PLayer {playerName} attacked, Monster was damaged and lost {playerAttackPoints} health and now has {monsterHP} health.");
        if (monsterHP <= 0)
        {
            Console.WriteLine("The Monster has been slain!!");
            playerExp += 10;
            if (playerExp >= 20)
            {
                playerLvl = 1;
                Console.WriteLine($"Congratulations Player {playerName}, you have leveled up to level {playerLvl}!");
            }
            break;
        }

        monsterAttackPoints = rand.Next(0, 10);
        playerHP = playerHP - monsterAttackPoints;
        if (playerHP < 0)
        {
            playerHP = 0;
        }
        Console.WriteLine($"The Monster attacked, Player {playerName} was damaged and lost {monsterAttackPoints} health and now has {playerHP} health.");
        if (playerHP <= 0)
        {
            Console.WriteLine($"Player {playerName} have been defeated");
            break;
        }
    } while (monsterHP > 0 && playerHP > 0);
    monsterHP = 10;
    playerHP = 10;
    Console.WriteLine("Do you want to play again(play) on proceed(proceed)?");
    choice = Console.ReadLine().Trim().ToLower();
} while (choice == "play");
