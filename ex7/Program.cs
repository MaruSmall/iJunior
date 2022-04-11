using System;

namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystalPerson;
            int crystalPrice=10;
            int crystalCount=7;

            Console.WriteLine("Предлагаем купить " + crystalCount + " кристаллов по цене " + crystalPrice + " золота за 1 кристалл");
            Console.WriteLine("Введите кол-во золота, который конвертируются в кристаллы");
            Console.Write("Золото= ");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кол-во кристаллов, которое хотите приобрести= ");
            crystalPerson = Convert.ToInt32(Console.ReadLine());

            if(crystalPerson > crystalCount)
            {
                Console.WriteLine("у нас нет столько кристаллов");
            }

            else
            {
                crystalCount -= crystalPerson;
                gold = gold - crystalPrice * crystalPerson;
                Console.WriteLine("Осталось кристаллов=" + crystalCount + ". Остаток золота=" + gold);
            }
         
        }
    }
}
