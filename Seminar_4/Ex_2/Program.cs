// Задача 26. Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
//            456-> 3
Console.WriteLine("Введите число А: ");
int inputNumber = GetInputNumber();
int amountOfDigits = CountDigits(inputNumber);
Console.WriteLine(amountOfDigits);

int GetInputNumber()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}
int CountDigits(int a)
{
    int digitsCounter = 0;
    while (a > 0)
    {
        a /= 10;
        digitsCounter++;
    }
    return digitsCounter;
}
