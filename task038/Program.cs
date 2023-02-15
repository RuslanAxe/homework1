// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(int [] collection)
{
    Random random = new Random();
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = random.Next(100);
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{(array[position])}" + " ");
        position++;
    }
}
int [] array = new int [10];
FillArray(array);
PrintArray(array);

int DiffBetweenMaxMin(int[] array)
{
    int maxElement = array[0], minElement = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxElement)
        {
            maxElement = array[i];
        }
        if (array[i] < minElement)
        {
            minElement = array[i];
        }
    }      
    return maxElement - minElement;
}
Console.WriteLine($"Разницу между максимальным и минимальным элементов массива: {DiffBetweenMaxMin(array)}");