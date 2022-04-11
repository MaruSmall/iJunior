using System;

namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pictures = 52;

            while (pictures != 1)
            {
                if (pictures % 3 == 0)
                {
                   pictures -= 3;
                    Console.WriteLine("**");
                }
                else
                {
                    pictures -= 3;
                    Console.WriteLine("***");

                }
            }
            ///////////////////////////////////////////////////////////
            while (pictures % 3 == 1)
            {
                if(pictures == 1)
                {
                    break;
                }

                pictures -= 3;
                Console.WriteLine("***");

            }

        }
    }
}
