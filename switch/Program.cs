for (int i = 1; i <= 100; i++)
{
    bool isDivisibleBy3 = i % 3 == 0;
    bool isDivisibleBy5 = i % 5 == 0;

    if (isDivisibleBy3 && isDivisibleBy5)
    {
        Console.WriteLine(i + ": FizzBuzz");
    }
    else if (isDivisibleBy3)
    {
        Console.WriteLine(i + ": Fizz");
    }
    else if (isDivisibleBy5)
    {
        Console.WriteLine(i + ": Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

