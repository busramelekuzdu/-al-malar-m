using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınan kelimenin sesli harflerini bulma 
            Console.WriteLine("Bir kelime giriniz");
            string word = Console.ReadLine();
            char[] vowelLetters = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };        
            byte sayac = 0;
            byte sayac2 = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (vowelLetters.Contains(word[i]))//bir dizede başka bir dizenin var olup olmadığını kontrol etmek için kullanılan bir metottur.
                {
                    sayac++;
                }
                else
                {
                    sayac2++;
                }
            }
            Console.WriteLine("kelimedeki sesli harf sayısı" + sayac);       
            Console.WriteLine("kelimedeki sessiz harf sayısı" + sayac2);
            Console.ReadLine();
        }
    }
}
