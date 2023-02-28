Console.Clear();
/*
1.Создать двухмерный массив.
2.Перемножить массив.
*/

int[,] array_1;
int[,] array_2;
int[,] arrResult;

//Метод создания массива
int[,] CreateArray(int size_1, int size_2)
{
    return new int[size_1, size_2];
}

//Метод вывода
void PrintArray(int[,] arr)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Рандомное заполнение 
void FillRandomArray(int[,] arr)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
        Console.WriteLine();
    }
}
//Метод перемножения массива
void MultiplicationArray(int[,] arr_1, int[,] arr_2, int[,] arrResult)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            arrResult[i, j] = arr_1[i, j] * arr_2[i, j];
        }
        Console.WriteLine();
    }
}

array_1 = CreateArray(2, 3);
FillRandomArray(array_1);

array_2 = CreateArray(3, 4);
FillRandomArray(array_2);

arrResult = CreateArray(4, 4);
MultiplicationArray(array_1, array_2, arrResult);

PrintArray(array_1);
Console.WriteLine();
PrintArray(array_2);
Console.WriteLine();
PrintArray(arrResult);


