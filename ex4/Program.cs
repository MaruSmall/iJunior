using System;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя: ");
            string name= Console.ReadLine();
            Console.WriteLine("Ваш знак зодиака: ");
            string zodiacSign = Console.ReadLine();
            Console.WriteLine ($"Вас зовут "+ name +", вы по знаку зодиака - " + zodiacSign + " и вы проходите курс Романа Сакутина!");
        }
    }
}
