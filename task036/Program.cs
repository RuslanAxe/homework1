// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int [] collection)
{
    Random random = new Random();
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = random.Next(-100,100);
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{(array[position])}" + ",");
        position++;
    }
}
int [] array = new int [10];
FillArray(array);
PrintArray(array);

int GetSumOfOdd(int[] array)
{
int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
return sum;
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {GetSumOfOdd(array)}");