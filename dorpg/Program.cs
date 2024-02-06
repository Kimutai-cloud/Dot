Console.WriteLine("Welcome to Alverdale, please enter you player name:");
string playerName = Console.ReadLine();






Random rand = new Random();
int playerAttackPoints, monsterAttackPoints;
int playerHP = 10, monsterHP = 10;
do
{
    playerAttackPoints = rand.Next(1, 11);
    
    monsterHP = monsterHP - playerAttackPoints;
    if (monsterHP < 0)
    {
        monsterHP = 0;
    }
    Console.WriteLine($"PLayer {playerName} attacked, Monster was damaged and lost {playerAttackPoints} health and now has {monsterHP} health.");
    if( monsterHP <= 0)
    {
        Console.WriteLine("The Monster has been slain!!");
        break;
    }

    monsterAttackPoints = rand.Next(0, 10);
    playerHP = playerHP - monsterAttackPoints;
    if(playerHP < 0)
    {
        playerHP = 0;
    }
    Console.WriteLine($"The Monster attacked, Player {playerName} was damaged and lost {monsterAttackPoints} health and now has {playerHP} health.");
    if ( playerHP <= 0)
    {
        Console.WriteLine($"Player {playerName} have been defeated");
        break;
    }
}while( monsterHP > 0 && playerHP > 0 );