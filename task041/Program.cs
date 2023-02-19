// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите массив чисел: ");
Console.WriteLine($"Количество положительных чисел в массиве: {FindPositive(Console.ReadLine())}");
int FindPositive(string str)
{    
    if (str == "" || str == null)
    {
        return -1;
    }
    else
    {
        int count = 0;
        double[] numbers = str.Split(' ', ',', '.', ':', ';').Select(double.Parse).ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                count++;
            }
        }
        return count;
    }
}