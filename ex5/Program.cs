﻿using System;

namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;
            Console.WriteLine("Переменные до обмена местами n1=" + number1 + ", n2=" + number2);
            int number3 = 0;
            number3 = number1;
            number1 = number2;
            number2 = number3;
            Console.WriteLine("Переменные после обмена местами n1=" + number1 + ", n2=" + number2);
        }
    }
}
