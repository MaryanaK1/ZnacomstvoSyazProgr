/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
int number;
int count = 0;
string answer;
string answerStop = "stop";
while (true)
{
    Console.Write("Введите число или словo stop : ");
    answer = Console.ReadLine();
    if (answer == answerStop)
    {
        break;
    }
    number = Convert.ToInt32(answer);
    if (number > 0) count++;
}
Console.WriteLine(count);