// Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateRndArray(8, -99, 100);
PrintArray(array);

double[] CreateRndArray(int size, int min, int max)
{
    double[] arr1 = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = (double)rnd.Next(min, max + 1)  + Math.Round(rnd.NextDouble(), 1);
    }
    return arr1;
}

void PrintArray (double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

double MinMaxDif(double[] array)
{
    double min = double.MaxValue; //максимальное значение которое можно положить в тип
    double max = double.MinValue; //минимальное значение которое можно положить в тип
   
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }

    return max - min;;
}

Console.WriteLine($"Разница между максимальным и минимальным элементами массива -> {MinMaxDif(array)}");