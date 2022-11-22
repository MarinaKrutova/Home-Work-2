/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int GetRandomNumberInRang(int start, int end)
{
    return new Random().Next(start, end + 1);
}

void TheThirdDigitOfTheNumber(int number)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры в числе " + number + " нет");
    }
    else
    {
        int result = number % 10;
        Console.WriteLine("Третья цифра: "  + result);
    }
}

int number = GetRandomNumberInRang(0, 999);
Console.WriteLine("Случайное число: " + number);
TheThirdDigitOfTheNumber(number);
