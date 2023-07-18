using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace diziler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Foreach döngüsüne geçmeden önce kullanıcıdan kaç adet sayı gireceğini alıp girdiği sayıların toplamlarını ekrana yazdıran c# konsol uygulaması
            int[] array;//array = dizi
            Console.WriteLine();
            Console.WriteLine("Kaç adet sayı girmek istiyorsunuz?");
            int count = int.Parse(Console.ReadLine());//int.Parse(): Bu ifade, bir metni tam sayıya dönüştürmek için kullanılan C#'ın int veri türüne ait Parse() metodu çağrısını ifade eder. Kullanıcı tarafından girilen metin, int.Parse() metoduyla tam sayıya dönüştürülür.
            array = new int[count];//kullanıcıdan alınan metni tam sayıya dönüştürerek bir count adında bir değişkene atamış olursunuz. 
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{i + 1}. sayı: ");//girilen sayıları ifade eder
                array[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;//sum toplam anlamına gelir
            for (int i = 0; i < count; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Girdiğiniz sayıların toplamı: {0}", sum);
        }
    }
}






