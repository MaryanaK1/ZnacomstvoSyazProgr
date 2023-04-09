// Напишите программу, кот. на вход принимает число (А) и выдает сумму чисел от 1 до А.
// 7->28
// 4->10
// 8->36

Console.WriteLine("Введте число А: "); 
int inputInt = GetIntInput();
int sum = sumFrom1toA(inputInt);
Console.WriteLine(sum);

int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int sumFrom1toA(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum +=i;  // sum = sum + i
    }
    return sum;
}