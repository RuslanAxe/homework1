int numberA, numberB, numberC;
System.Console.Write("Введите первое число: ");
while(!Int32.TryParse(Console.ReadLine(), out numberA))
{
    Console.Write("Ошибка! Введите цифру: ");
}
System.Console.Write("Введите второе число: ");
while(!Int32.TryParse(Console.ReadLine(), out numberB))
{
    Console.Write("Ошибка! Введите цифру: ");
}
System.Console.Write("Введите третье число: ");
while(!Int32.TryParse(Console.ReadLine(), out numberC))
{
    Console.Write("Ошибка! Введите цифру: ");
}
int max = numberA;
if(numberB > max)
{
    max = numberB;
}
if(numberC > max)
{
    max = numberC;
}
System.Console.WriteLine("Максимальное число равно: ");
System.Console.Write(max);