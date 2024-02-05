Random random  = new Random();
int flip = random.Next(2);
int flips;
int numberedFlips;

Console.WriteLine("\t\t!!Coin Flip Game!!\nPlease enter your name:");
string playerName = Console.ReadLine();
string playerChoice;


Console.WriteLine($"Welcome {playerName}, do you want to play the normal flip(normal) or bulk flip(bulk)?");
string gameChoice = Console.ReadLine().Trim().ToLower();

if (gameChoice == "normal")
{
    do
    {
        Console.WriteLine("If you want to flip a coin enter (Flip) if not enter (Exit).");
        playerChoice = Console.ReadLine().Trim().ToLower();
        if (playerChoice == "flip")
        {
            flips = random.Next(2);
            if (flips == 0)
            {
                Console.WriteLine("Heads");
            }
            else if (flips == 1)
            {
                Console.WriteLine("Tails");
            }
        }
    } while (playerChoice == "flip");
    Console.WriteLine("Thank you and see you soon!!");
}
else
{
    Console.WriteLine("How many flips do you want?.");
    numberedFlips = int.Parse(Console.ReadLine().Trim());
    do
    {
        

        Console.WriteLine("If you are ready to bulk flip a coin enter (Flip) if not enter (Exit).");
        playerChoice = Console.ReadLine().Trim().ToLower();
        for(int i = 0; i <= numberedFlips; i++)
        {
            if (playerChoice == "flip")
            {
                flips = random.Next(2);
                if (flips == 0)
                {
                    Console.WriteLine("Heads");
                }
                else if (flips == 1)
                {
                    Console.WriteLine("Tails");
                }
            }
        }
        
    } while (playerChoice == "flip");
    Console.WriteLine("Thank you and see you soon!!");
}


 
