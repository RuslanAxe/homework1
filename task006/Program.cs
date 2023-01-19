int number;
System.Console.Write("Введите целое число: ");
while(!Int32.TryParse(Console.ReadLine(), out number))
{
    System.Console.Write("Некорректное число! Введите целое число: ");
}
if(number % 2 == 0)
{
    System.Console.WriteLine("Чётное");
}
else
{
    System.Console.WriteLine("Нечётное");
}