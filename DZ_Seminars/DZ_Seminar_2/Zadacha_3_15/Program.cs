// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//            6 -> да
//            7 -> да
//            1 -> нет
Console.WriteLine("Является ли день недели выходным?");
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine($"{number} -> нет");
        break;

    case 2:
        Console.WriteLine($"{number} -> нет");
        break;

    case 3:
        Console.WriteLine($"{number} -> нет");
        break;

    case 4:
        Console.WriteLine($"{number} -> нет");
        break;

    case 5:
        Console.WriteLine($"{number} -> нет");
        break;

    case 6:
        Console.WriteLine($"{number} -> да");
        break;

    case 7:
        Console.WriteLine($"{number} -> да");
        break;

    default:
        Console.WriteLine("Такого дня недели не существует!");
        break;
}