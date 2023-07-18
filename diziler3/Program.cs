using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tanımlanan sayılar dizisi içerisindeki pozitif çift sayıları ekrana yazdıran c# konsol uygulaması
            int[] sayilar = { 51, 48, -55, -35, -74, 61, 52, 8, 12, 74, -65 };
            int toplam = 0;
            foreach (int sayi in sayilar) 
            {
                if (sayi % 2 == 0 && sayi >= 0)
                    Console.WriteLine(sayi);
            }
            Console.ReadLine();
        }
    }
}
