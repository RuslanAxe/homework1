// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

double number;
System.Console.Write("Введите число трехзначное: ");
while(!double.TryParse(Console.ReadLine(), out number))
{
    System.Console.Write("Неправильный ввод данных! Введите число: ");
}
ThirdDigit(number);                    
System.Console.WriteLine();

static void ThirdDigit(double number)
{
int result;
number = Math.Abs(number);
if (number > 99)
    {
    while (number > 999)
        {
        number /= 10;
        }
    result = (int)number % 10;
    System.Console.WriteLine($"Третья цифра в числе: {result}");
    }
else
    {
    System.Console.WriteLine("Третьей цифры нет");
    }
}