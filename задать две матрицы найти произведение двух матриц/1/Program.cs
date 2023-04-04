/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
int a = new Random().Next(2, 5);
int b = new Random().Next(2, 5);

int[,] array = new int[a, b];
int[,] array2 = new int[b, a];
int[,] resultarray = new int[a, a];


//Создание массива #1
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j],3}");
    }
    Console.WriteLine();
}
Console.WriteLine();
//Создание массива #2
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = new Random().Next(0, 10);
        Console.Write($"{array2[i, j],3}");
    }
    Console.WriteLine();
}

//Произведение массивов
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        for (int k = 0; k < array2.GetLength(0); k++)
        {
            resultarray[i, j] += array[i, k] * array2[k, j];
        }
    }
}

Console.WriteLine();

//Произведение массивов
for (int i = 0; i < resultarray.GetLength(0); i++)
{
    for (int j = 0; j < resultarray.GetLength(1); j++)
    {
        Console.Write($"{resultarray[i, j],5}");
    }
    Console.WriteLine();
}