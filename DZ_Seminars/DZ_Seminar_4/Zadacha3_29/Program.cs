/* Задача 29: Напишите программу, которая приниматет на вход длину массива, минимальное значение массива
 и максимальное значение массива, создаёт массив с заданными параметрами и выводит значения на экран

5, 1, 19 -> [1, 2, 5, 7, 19]
3, 1, 33 -> [6, 1, 33]     */

   
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Введите минимальное значение массива: ");
            int minValue = int.Parse(Console.ReadLine());

            Console.Write("Введите максимальное значение массива: ");
            int maxValue = int.Parse(Console.ReadLine());

            Random random = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }

            Console.WriteLine($"Сгенерированный массив: [{string.Join(", ", array)}]");
        }
    }