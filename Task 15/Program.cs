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
    if (number > 0 && number < 6)
    {
        Console.WriteLine("Сегодня рабочий день!");
    }
    else if(number > 5 && number < 8)
    {
        Console.WriteLine("Сегодня ВЫХОДНОЙ");
    }
    else
    {
       Console.WriteLine("А Вы уверены что такой день существует?");
    }
}