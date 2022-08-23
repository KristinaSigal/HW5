// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = CreateRndArray(8, 100, 1000);
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

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

int CountEvenElement(int[] array)
{
    int evenCount = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) evenCount++;
    }
    return evenCount;
}

Console.WriteLine($"Количество чётных чисел в массиве -> {CountEvenElement(array)}");