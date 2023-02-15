// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int [] collection)
{
    Random random = new Random();
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = random.Next(100,1000);
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

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine($"Количество чётных чисел в массиве: {CountEvenNumbers(array)}");