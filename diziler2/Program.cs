using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 62, 51, 84, -45, -82, 55, 94, -89, 26, -41, 55, 74 }; //dizi oluşturmak için köşeli parantez kullanılır.
            int toplam = 0;
            foreach (int sayi in sayilar)//foreach : dizi içindeki verileri sırasıyla değişkene atama işlemi yaparak dizi içindeki elemanların hepsini sırasıyla listeleme işlemi yapar.
            {
                toplam = toplam + sayi;
            }
            Console.WriteLine("dizideki sayıların toplamı = " + toplam);//console.writline ekrana yazma işlemini yapar
            Console.ReadLine();
        }
    }
}
