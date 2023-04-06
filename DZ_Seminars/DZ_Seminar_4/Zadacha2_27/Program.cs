/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

              452 -> 11
              82 -> 10
              9012 -> 12     */
int ReadNumber(string massage)
{
    Console.Write(massage);
    return Convert.ToInt32(Console.ReadLine());
}

void SumDigits(int num)
{
    int number = num;
    if (number < 0) { number = number * (-1); }
    else num = number;
    int sum = 0;
    int digit = 0;
    while (number > 0)
    {
        digit = number % 10;
        sum = sum + digit;
        number = number / 10;
    }
    Console.Write($"{num} -> {sum}");
}
int N = ReadNumber("Введите число: ");
SumDigits(N);
