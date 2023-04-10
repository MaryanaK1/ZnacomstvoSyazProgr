/* Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементом массива.

              [3 7 22 2 78] -> 76                                    */
int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

const int size = 5;
const int leftRange = 0;
const int rightRange = 300;
int[] massive = GetRandomArray(size, leftRange, rightRange);

int resultNumber(int[] array)
{
    int min = array[0];
    int max = array[0];
    int result = 0;
    for(int i = 0; i < massive.Length; i++)
    {
        int temp = array[i];
        if (min > temp) 
        {
            min = temp;
        }
        else if (max < temp) 
        {
            max = temp;
        }
        result = max - min;  
    }
    Console.WriteLine($"max элемент массива = {max}");
    Console.WriteLine($"min элемент массива = {min}");
    return result;
}
Console.WriteLine((string.Join(", ", massive )) + " -> " + $"{resultNumber(array: massive)}");
