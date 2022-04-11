using System;

namespace ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeOfReceiptInMinutes = 10;
            int peopleInQueue;
            int minutesInHour = 60;

            Console.WriteLine("Введите кол-во людей в очереди");
            peopleInQueue = Convert.ToInt32(Console.ReadLine());

            int timeInQueue = timeOfReceiptInMinutes * peopleInQueue;
            int hoursSpentInLine = timeInQueue / minutesInHour;
            int minutesSpentInLine = timeInQueue % minutesInHour;

            Console.WriteLine("Вы проведете в очереди "+ hoursSpentInLine + " часа и " + minutesSpentInLine + " минут");

        }
    }
}
