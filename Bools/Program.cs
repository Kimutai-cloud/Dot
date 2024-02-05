Random random  = new Random();
int flip = random.Next(2);

Console.WriteLine("\t\t!!Coin Flip Game!!\nPlease enter your name:");
string playerName = Console.ReadLine();
string playerChoice;
int flips;
Console.WriteLine($"Welcome {playerName}");
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
        else if(flips == 1)
        {
            Console.WriteLine("Tails");
        }
    }
} while (playerChoice == "flip");
Console.WriteLine("Thank you and see you soon!!");

 
