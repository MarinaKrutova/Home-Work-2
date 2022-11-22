/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
int TheSecondDigitOfThreeDigitNumber(int number)
{
    return (number % 100) / 10;
}

int N = new int();
Console.Write("Введите трезначное число: ");
N = Convert.ToInt32(Console.ReadLine());
int result = TheSecondDigitOfThreeDigitNumber(N);
Console.WriteLine("Вторая цифра числа: " + result);