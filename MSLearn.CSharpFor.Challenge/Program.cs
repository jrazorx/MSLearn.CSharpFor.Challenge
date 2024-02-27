for (int i = 1; i <= 100; i++)
{
    bool isFizz = i % 3 == 0 ? true : false;
    bool isBuzz = i % 5 == 0 ? true : false;

    Console.Write(i);

    if (isFizz && isBuzz)
        Console.WriteLine(" - FizzBuzz");
    else if (isFizz)
        Console.WriteLine(" - Fizz");
    else if (isBuzz)
        Console.WriteLine(" - Buzz");
    else
        Console.WriteLine();
}