using System;

namespace ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = 10;
            int queue;

            Console.WriteLine("Введите кол-во людей в очереди");
            queue=Convert.ToInt32(Console.ReadLine());

            int timeInQueue = time * queue;

            int hour = timeInQueue / 60;
            int minute = timeInQueue % 60;

            Console.WriteLine("Вы проведете в очереди "+hour+" часа и " +minute+" минут");

        }
    }
}
