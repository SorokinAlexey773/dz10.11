// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}| ");
        if (i == array.Length - 1) Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
double DifMaxMinNumbers(double[] array)
{
    double max = array[0];
    double min = array[0];
    double result = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    return result = max - min;
}
double [] arr = CreateArrayRndDouble(6, 1 , 10);
PrintArray(arr);
double difMaxMinNumbers = DifMaxMinNumbers(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {difMaxMinNumbers}");