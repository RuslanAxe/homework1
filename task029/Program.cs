// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]

void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random() .Next();
        index++;
    }

}
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{(coll[position])}" + ",");
        position++;
    }
}
int [] array = new int [4];
FillArray(array);
PrintArray(array);