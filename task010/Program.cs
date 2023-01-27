// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

double number;
System.Console.Write("Введите трёхзначное число: ");
while(!double.TryParse(Console.ReadLine(), out number))
{
    System.Console.Write("Введено не число! Введите число: ");
}
number = Math.Abs(number);

if(((int)number / 100 > 0) && ((int)number / 1000 == 0))
{
SecondDigit(number);
}
System.Console.WriteLine(result);
else
{
System.Console.WriteLine("Не верный ввод числа!");
}

System.Console.WriteLine();    
static void SecondDigit(double number)
{ int result;
if(number > 99 && number < 1000)
    {
        number = (int)number / 10;
        result = (int)number % 10;
        System.Console.WriteLine($"Вторая цифра: {result}");
    }
else 
    {
        System.Console.WriteLine("Число не трёхзначное!!");
    }
}


