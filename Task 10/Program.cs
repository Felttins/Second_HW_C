// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int N = Prompt(" ");

int Prompt(string message)
{
    Console.Write("Введите трёхзначное число- ");
    int N= int.Parse(Console.ReadLine()!);
    return N;
}

Operation(N);

void Operation(int number)
{
    if (number >100 && number < 1000)
    {
        Console.WriteLine(number/10%10);
    }
    else
    {
        Console.WriteLine("Данное число не трёхзначно!");
    }
}