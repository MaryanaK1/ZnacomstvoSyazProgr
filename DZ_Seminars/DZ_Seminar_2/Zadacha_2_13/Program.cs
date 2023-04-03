// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//            645 -> 5
//            78 -> третьей цифры нет
//            32679 -> 6
int num = 0;
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) { num = number * (-1); }
else num = number;

if (num < 100)
{
    Console.WriteLine($"Третьей цифры в числе {number} нет ");
}
else
{
    while (num > 999)
    {
        num = num / 10;
    }
    Console.WriteLine($"Третья цифра числа {number} это {num % 10} ");
}
