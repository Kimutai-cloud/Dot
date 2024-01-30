bool exit = false;

while (!exit)
{
    Random dice = new Random();


    int roll1 = dice.Next(1, 7);
    int roll2 = dice.Next(1, 7);
    int roll3 = dice.Next(1, 7);

    int total = roll1 + roll2 + roll3;

    Console.WriteLine($"Dice roll come to:{roll1} + {roll2} + {roll3} = {total}");

    if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
    {
        if ((roll1 == roll2) && (roll2 == roll3))
        {
            total += 6;
            Console.WriteLine($"Congratz!! You have rolled a triple + 6 to your score!! Your new total is : {total}");

        }
        else
        {
            total += 3;
            Console.WriteLine($"Congratz!! You have rolled a double + 3 to your score!! Your new total is : {total}");
        }
        
    }
    
    if (total >= 15)
    {
        Console.WriteLine("Congratz!! You win");
    }
    else
    {
        Console.WriteLine("Congratz!! You Lose");
    }

    if (!exit)
    {
        Console.WriteLine("Do you want to retry? (yes/no)");
        string retry = Console.ReadLine().ToLower();

        if (retry != "yes")
        {
            exit = true;
            Console.WriteLine("Exiting... Thank you and come back soon");
        }
    }
}