using System;

namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 30;
            Console.WriteLine("Переменные до обмена местами n1=" + n1 + ", n2=" + n2);
            int help = 0;
            help = n1;
            n1 = n2;
            n2 = help;
            Console.WriteLine("Переменные после обмена местами n1=" + n1 + ", n2=" + n2);
        }
    }
}
