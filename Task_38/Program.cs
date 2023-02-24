/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/

Console.Clear();

//Метод нахождения минимума
double FindMin(double[] arr)
{

    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
        }
    }

    return min;
}

//Метод нахождения максимума
double FindMax(double[] arr)
{

    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
    }

    return max;
}

//Метод нахождения разницы между максимальным и минимальным элементом массива
double FindDiff(double min, double max)
{
    double result = max - min;

    return result;
}

//Метод вывода элементов массива
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

double[] array = new double[10] { 1.1, 5.6, 4.1, 2.7, 6.9, 9.3, 0.6, 2.3, 7.1, 3.4 };

PrintArray(array);

double minNumber = FindMin(array);
double maxNumber = FindMax(array);

double result = FindDiff(minNumber, maxNumber);

Console.WriteLine($"Разница между максимальным значение {maxNumber} и минимальным значением {minNumber} равна {result}.");

