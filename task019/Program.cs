// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// (НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. Используем операторы % и /).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Palyndrome palyndrome1 = new Palyndrome();
palyndrome1.SetPalyndrome();
palyndrome1.PrintResult();

class Palyndrome
{
    int Number { get; set; }
    public string? Name { get; set; }

    public Palyndrome() { }
    public Palyndrome(int number)
    {
        Number = number;
        Name = number.ToString();
    }
    public Palyndrome SetPalyndrome()
    {
        Palyndrome polyndrom = new Palyndrome();
        System.Console.Write("Введите целое пятизначное число: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || !(Math.Abs(number) > 9999) || !(Math.Abs(number) < 100000))
        {
            System.Console.Write("Ошибка! Введите целое пятизначное число: ");
        }
        Number = number;
        Name = number.ToString();
        return polyndrom;        
    }
    private bool IsPalyndrome()
    {
        int digit1 = Number / 10000;

        int digit2 = Number / 1000;
        digit2 = digit2 % 10;

        int digit4 = Number / 10;
        digit4 = digit4 % 10;

        int digit5 = Number % 10;

        if (digit1 == digit5 && digit2 == digit4)
        {
            return true;
        }
        else
            return false;
    }

    public void PrintResult()
    {
        System.Console.WriteLine("Проверка на палиндромность:");
        if(IsPalyndrome())
        {
            Console.WriteLine($"Да! {Name} является палиндромом!");
        }
        else
        {
            Console.WriteLine($"Нет! {Name} не является палиндромом!");
        }
    }
}