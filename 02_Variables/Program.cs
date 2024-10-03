using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            double number ;
            number = 4.85;
            Console.WriteLine(number);

            Console.WriteLine("***** Fiyat Listesi *****");
            double applePrice, orangePrice, stramberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            stramberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("***** Elma Birim Fiyatı: "+applePrice+"TL");
            Console.WriteLine("***** Protakal Birim Fiyatı: "+orangePrice+"TL");
            Console.WriteLine("***** Çilek Birim Fiyatı: "+stramberryPrice+"TL");
            Console.WriteLine("***** Patates  Birim Fiyatı: "+potatoPrice+"TL");
            Console.WriteLine("***** Domates  Birim Fiyatı: "+tomatoPrice+"TL");

            Console.WriteLine();
            Console.WriteLine();

            double appleGram, orangeGram, strambGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram =2.650;
            strambGram = 0.750;
            potatoGram =4.850;
            tomatoGram = 3.745;










            #endregion

            Console.Read();

            

        }
    }
}
