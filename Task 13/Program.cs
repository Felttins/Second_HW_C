// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int N = Prompt("");

int Prompt(string message)
{
    Console.Write("Введите число - ");
    int N= int.Parse(Console.ReadLine()!);
    return N;
}

Operation(N);

void Operation(int number)
{
    if (number > -100 && number < 100)
    {
        Console.WriteLine("Данное число не имеет третью цифру");
    }
    else
    {
        while (number > 1000 || number < -1000)
        {
            number = number/10;
        }
            Console.WriteLine(Math.Abs(number%10));
    }
}