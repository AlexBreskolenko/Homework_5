/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Clear();

//Метод создания массива 
int[] CreateArray(int size)
{
    return new int[size];
}

//Метод заполнения массива
void FillRandomArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
}

//Метод для вывода количества четных чисел
int ReturnSumEvenNumber(int[] arr)
{
    int result = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            result++;
        }
    }

    return result;
}

//Метод для вывода результата
void PrintResult(int result)
{
    Console.WriteLine($"Количество чётных чисел в массиве равно {result}.");
}

//Метод печати массива
void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}



Console.Write("На сколько элементов вы хотите создать массив : ");
int size = int.Parse(Console.ReadLine());

int[] array = CreateArray(size);

FillRandomArray(array);

PrintArray(array);
Console.WriteLine();

int result = ReturnSumEvenNumber(array);

PrintResult(result);
