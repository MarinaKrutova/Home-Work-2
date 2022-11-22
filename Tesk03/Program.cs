/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является 
ли этот день выходным.
*/

void DayOfTheWeek(int number)
{
    if (number > 5)
    {
        Console.WriteLine("Этот день недели является выходным");
    }
    else
    {
        Console.WriteLine("Этот день недели не является выходным");
    }
}


    
int number = new int();
Console.Write("Введите Ваше число от 1 до 7: ");
number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
  Console.WriteLine("Такого дня недели не существует");  
}
else
{
DayOfTheWeek(number);
}
