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

            int filledRowCount = pictures / picturesInRowCount;
            picturesAmountLeft = pictures % picturesInRowCount; 

            Console.WriteLine(filledRowCount + " рядов из картинок по "+picturesInRowCount+" шт, " +
                "кол-во оставщихся картинок: "+ picturesAmountLeft);
        }
    }
}
