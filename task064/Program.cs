// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа которая выводит все натуральные числа от N до 1!");
            Console.Write("Введите число N: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Ваш ряд натуральных чисел: ");
            void NumberCounter(int num)
            {
                if (num < 0)
                {
                    Console.WriteLine("Введено не натуральное число!!!");
                    return;
                }
                if (num == 0)
                    return;
                Console.Write(num + " ");
                NumberCounter(num - 1);
            }
            NumberCounter(number);

        }
    }
}