/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] array = new int[3, 5];
int sum = 0;
int minrow = 0;
//Создание массива
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 100);
        Console.Write($"{array[i, j],3}");
    }
    Console.WriteLine();
}
//Сумма элементов первой строки
for (int j = 0; j < array.GetLength(1); j++)
    sum += array[0, j];


//Сумму каждой строки сравниваем с первой и находим наименьшую
for (int i = 0; i < array.GetLength(0); i++)
{
    int currentsum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        currentsum += array[i, j];
    }
    if (currentsum < sum)
    {
        sum = currentsum;
        minrow = i + 1;
    }
}
Console.Write($"номер строки с наименьшей суммой элементов: {minrow} строка");