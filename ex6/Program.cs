using System;

namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pictures = 52;
            int picturesInRowCount = 3;
            int picturesAmountLeft=0;
            while (pictures != 1)
            {
                if (pictures % picturesInRowCount == 0)
                {
                   pictures -= picturesInRowCount;
                   // Console.WriteLine("**");
                }
                else
                {
                    pictures -= picturesInRowCount;
                    picturesAmountLeft++;
                }
            }
            Console.WriteLine(picturesAmountLeft + " рядов из картинок по 3 шт, кол-во оставщихся картинок: "+ pictures);

            ///////////////////////////////////////////////////////////
            //while (pictures % countPictures == 1)
            //{
            //    if(pictures == 1)
            //    {
            //        break;
            //    }

            //    pictures -= countPictures;
            //   // Console.WriteLine("***");
            //}

        }
    }
}
