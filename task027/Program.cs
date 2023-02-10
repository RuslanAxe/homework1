/// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число и мы выведем сумму чисел от 1 до N: ");
Console.WriteLine("Введите число: ");
int.TryParse(Console.ReadLine(), out int n);
if (n < 1)
{
    Console.WriteLine("Число должно быть положительным");
    return;
}
int absNumber = Math.Abs(n);
int Number = n;

int SumDigits(int n)
{
    int temp;
    int sum = 0;
    while (absNumber > 0)
    {
    temp = absNumber % 10;
    absNumber /= 10;
    sum += temp;
    }
    return sum;
}

int result = SumDigits(n);
Console.WriteLine($"Результат: {result}");