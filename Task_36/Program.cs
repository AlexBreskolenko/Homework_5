/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/

Console.Clear();

//Метод создания массива 
int[] CreateArray(int size)
{
    return new int[size];
}

//Заполнения массива рандомными числами в заданном диапазоне
void FillRandomArray(int[] arr, int minRange, int maxRange)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minRange, maxRange);
    }
}

//Метод для запросса на ввод числа
int ReturnNumber(string messange)
{
    Console.Write(messange);
    int returnNum = int.Parse(Console.ReadLine());

    return returnNum;
}

//Метод подсчета суммы элементов на нечетных позициях
int ReturnSumNumberOddPosition(int[] arr)
{
    int result = 0;

    for(int i = 1; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += arr[i];
        }
    }

    return result;
}

//Метод вывода массива
void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

//Метод вывода результатов
void ResultPrint(int result)
{
    Console.Write($"Cумма элементов, стоящих на нечётных позициях равна {result}");
}

Console.Write("Какой длинны вы хотите создать массив : ");
int size = int.Parse(Console.ReadLine());

int[] array = CreateArray(size);
int minRange = ReturnNumber("Какой минимальный диапазон в массиве : ");
int maxRange = ReturnNumber("Какой максимальный диапазон в массиве : ");
FillRandomArray(array, minRange, maxRange);

PrintArray(array);

Console.WriteLine();

int result = ReturnSumNumberOddPosition(array);
ResultPrint(result);