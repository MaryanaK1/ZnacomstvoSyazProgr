/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
              [3, 7, 23, 12] -> 19
              [-4, -6, 89, 6] -> 0           */
int [] GetRandomArray(nint size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange+1);
    }
    return array;
}

const int size = 10;
const int leftRange = -5;
const int rightRange = 5;
int[] massive = GetRandomArray (size, leftRange, rightRange);  // int[] massive = GetRandomArray (10, -5, 5);
//Console.WriteLine(string.Join(", ", massive));

int sumNotEven(int[] array)
{
    int sum = 0;   //сумма элементов, стоящих на нечётных позициях
    for (int i = 0; i < massive.Length; i++)
    {
        if (i % 2 != 0 )  
        {
            sum += massive[i];    
        }
    }
    return sum;
}
Console.WriteLine((string.Join(", ", massive )) + " -> " + $"{sumNotEven(array: massive)}");