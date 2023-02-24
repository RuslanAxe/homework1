// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int[,] array = new int[3, 4];
Random random = new Random();
for (int i = 0; i < array.Length(0); i++)
{
    for (int j = 0; j < array.Length(1); j++)
    {
        array[i, j] = 1+ random * (10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}