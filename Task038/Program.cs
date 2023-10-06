// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] RandomArray(int min, int max, int length)
{
    double[] arr = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.NextDouble() * (min - max) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F2}, ");
        else Console.Write($"{arr[i]:F2}");
    }

    Console.Write("]");
}

double FindMax(double[] arr)
{
    double maxNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNumber) maxNumber = arr[i];
    }
    return maxNumber;
}

double FindMin(double[] arr)
{
    double minNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNumber) minNumber = arr[i];
    }
    return minNumber;
}

double[] array = RandomArray(50,100,5);
PrintArray(array);
double result = FindMax(array) - FindMin(array);
Console.Write($" => {FindMax(array):F2} - {FindMin(array):F2} = {result:F2}");