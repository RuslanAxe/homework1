// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет (формат ввода произвольный, не обязательно через запятую)
int[,] array = new int[3, 4];
Random random = new Random();
int rowIndex;
int columnIndex;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 100);
        Console.Write(array[i, j] + " ");

    }
    Console.WriteLine();
}

Console.SetCursorPosition(0, 20);
Console.WriteLine("Введите число от 1 до 3 которое будет обозначать строку искомого элемента ");
rowIndex = Convert.ToInt32(Console.ReadLine()) + (-1);
Console.WriteLine("Введите число от 1 до 4 которое будет обозначать столбец искомого элемента ");
columnIndex = Convert.ToInt32(Console.ReadLine()) + (-1);
if (rowIndex >= 0 && rowIndex <= 2 || columnIndex >= 0 && columnIndex <= 3)
{
    Console.Write("Ваш элемент: ");
    Console.Write(array[rowIndex, columnIndex]);
}
else
{
    Console.WriteLine("Вы выбрали неверный диапозон");
}