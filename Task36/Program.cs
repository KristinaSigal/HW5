// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = CreateRndArray(8, -99, 100);
PrintArray(array);

int[] CreateRndArray(int size, int min, int max)
{
    int[] arr1 = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = rnd.Next(min, max + 1);
    }
    return arr1;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

int SumOddElement(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] % 2 == 1) sum++;
    }
    return sum;
}

Console.WriteLine($"Cумма элементов массива, стоящих на нечётных позициях -> {SumOddElement(array)}");