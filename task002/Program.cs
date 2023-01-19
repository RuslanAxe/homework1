int numberA, numberB;
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
if(numberA > numberB)
{
    System.Console.WriteLine($"min = {numberB}");
    System.Console.WriteLine($"max = {numberA}");
}
else if(numberB > numberA)
{
    System.Console.WriteLine($"min = {numberA}");
    System.Console.WriteLine($"max = {numberB}");
}
else
{
    System.Console.WriteLine("Числа равны");
}
