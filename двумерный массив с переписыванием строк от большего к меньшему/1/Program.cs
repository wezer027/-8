/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] array = new int[new Random().Next(3, 6), new Random().Next(3, 6)];


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 100);
        Console.Write($"{array[i, j],3}");
    }
    Console.WriteLine();
}

List<List<int>> list = new List<List<int>>();

for (int i = 0; i < array.GetLength(0); i++)
{
    var dim = new List<int>();
    for (int j = 0; j < array.GetLength(1); j++)
        dim.Add(array[i, j]);
    dim.Sort();
    list.Add(dim);
}
Console.WriteLine();

foreach (var list2 in list)
{
    foreach (var item in list2)
        Console.Write($"{item,3} ");
    Console.WriteLine();
}