// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите 2 числа и мы возведем первое первое в степень второго: ");
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= Math.Abs(n); i++)
    result *= a;
    return result;
}

int result = PowerFor(a, n);
Console.WriteLine($"{result}");
