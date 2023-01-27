// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Cubing cubing1 = new Cubing();
cubing1.SetNumber();
cubing1.GetResult();

class Cubing
{
    double Number { get; set; }

    public Cubing() { }
    public Cubing(double number)
    {
        Number = number;
    }
    
    public void GetResult()
    {        
        double i = 1;

        Console.Write($"Таблица кубов чисел от 1 до {Number}: ");

        while (i <= Number)
        {
            Console.Write($"{Math.Pow(i, 3)}");            
            if(i < Number)
            {
                Console.Write(", ");
            }
            i++;
        }
        //Number = number;
    }
     public Cubing SetNumber()
     {
        Cubing cubing = new Cubing();
        double number;
        Console.Write("Введите число: ");
        while(!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Ошибка! Введите натуральное число: ");
        }
        Number = number;
        return cubing;
     }
}