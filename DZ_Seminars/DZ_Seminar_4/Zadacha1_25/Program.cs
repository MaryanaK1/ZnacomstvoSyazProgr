// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//              3, 5 -> 243 (3⁵)
//              2, 4 -> 16
int ReadNumber(string massage)
{
    Console.WriteLine(massage);
    return Convert.ToInt32(Console.ReadLine());
}

int Degree(int a, int b)
{
    int num = a;
    for (int i = 1; i < b; i++)
    {
        num = num * a;
    }
    return num;

}
int numberA = ReadNumber("Введите число A: ");
int numberB = ReadNumber("Введите число В: ");
if (numberA == 0 || numberB < 0)
{
    Console.WriteLine("Введено неверное число");
}
else
{
    if (numberB == 0)
    {
        Console.WriteLine("1");
    }
    else
    {
        int numAB = Degree(numberA, numberB);
        Console.WriteLine(numAB);
    }
}