using System;

class Program
{
    static void Main()
    {
        string message = "The quick brown fox jumps over the lazy dog.";
        string message2 = "The lazy dog sat next to the quick brown fox.";

        
        int i = 0;
        do
        {
            Console.WriteLine("Choose between a fox and a dog.");
            string reply = Console.ReadLine();
            i++;
            if (reply.Contains("fox"))
            {
                Console.WriteLine($"Thank you for choosing Fox Ltd, our motto is \"{message}\".");
            }
            else if (reply.Contains("dog"))
            {
                Console.WriteLine($"Thank you for Choosing Dog&CO ltd, our motto is \"{message2}\".");
            }
            else
            {
                Console.WriteLine("Unfortunately, your response is not within the set parameters. Please contact the administrator for more inquiries.");
            }
        } while (i < 5);
        Console.WriteLine("HEHEHEHE!!!I must thank you for successfully wasting approximatly 10 seconds of your life going through my loops, hope ubaki ni hiyo ujinga!Im out");
    }
}
