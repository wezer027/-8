/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
int N = 4;
int M = 4;
int[,] array = new int[N, M];

int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
int k = 1;
int i = 0;
int j = 0;

while (k <= N * M)
{
    array[i, j] = k;
    if (i == Ibeg && j < M - Jfin - 1)
        ++j;
    else if (j == M - Jfin - 1 && i < N - Ifin - 1)
        ++i;
    else if (i == N - Ifin - 1 && j > Jbeg)
        --j;
    else
        --i;

    if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != M - Jfin - 1))
    {
        ++Ibeg;
        ++Ifin;
        ++Jbeg;
        ++Jfin;
    }
    ++k;
}


Console.WriteLine();
for (int row = 0; row < array.GetLength(0); row++)
{
    for (int col = 0; col < array.GetLength(1); col++)
    {
        Console.Write($"{array[row, col],3}");
    }
    Console.WriteLine();
}