/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2     */
int [] GetRandomArray(nint size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange+1);
    }
    return array;
}
const int size = 12;
int[] massive = GetRandomArray (size, 100, 1000);

int evenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] % 2 == 0) count ++;
    }
    return count;
}

Console.WriteLine((string.Join(", ", massive )) + " -> " + $"{evenNum(arr: massive)}");