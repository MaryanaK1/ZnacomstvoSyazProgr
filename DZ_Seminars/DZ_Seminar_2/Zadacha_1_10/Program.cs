// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//            456 -> 5
//            782 -> 8
//            918 -> 1
int num = 0;
Console.WriteLine("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) { num = number * (-1); }
else
    num = number;

if (num >= 100 && num <= 999)
{
    int firstDigit = num / 10;
    int thirdDigit = firstDigit % 10;
    num = thirdDigit;
    Console.WriteLine($"Вторая цифра числа {number} это {num} ");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
    Console.WriteLine("Введите трехзначное число");
}