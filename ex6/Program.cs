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

            int rowCount = pictures / picturesInRowCount;
            picturesAmountLeft = pictures % picturesInRowCount; 

            Console.WriteLine(rowCount + " рядов из картинок по 3 шт, кол-во оставщихся картинок: "+ picturesAmountLeft);
        }
    }
}
