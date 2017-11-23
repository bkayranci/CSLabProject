/**
 * @author Turkalp Burak KAYRANCIOGLU <bkayranci@gmail.com>
 * 150101011
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            * NOKTA DEMO
            */
            Console.WriteLine("\n======= NOKTA DEMO =======\n");

            Nokta n1 = new Nokta(0, 0);
            Nokta n2 = new Nokta();
            Nokta n3 = new Nokta(1, 0);

            Console.WriteLine("\n# ToString Demo\n");
            Console.WriteLine(n1.NoktaString());    // Nokta(0, 0)
            Console.WriteLine(n2.NoktaString());    // Nokta(0, 0)
            Console.WriteLine(n3.NoktaString());    // Nokta(1, 0)

            Console.WriteLine("\n# Uzaklik Demo\n");
            Console.WriteLine("n1 - n2 arasi uzaklik: " + n1.Uzaklik(n2));  // 0 olmasi gerekiyor
            Console.WriteLine("n1 - n3 arasi uzaklik: " + n1.Uzaklik(n3));  // 1 olmasi gerekiyor

            /**
             * UCGEN DEMO
             */
            Console.WriteLine("\n======= UCGEN DEMO =======\n");

            Console.WriteLine("\n# Ucgen Olusturma Demo\n");
            Ucgen u1 = new Ucgen(n1, n2, n3);   // default noktalar ile olusur ve uyari verir
            Ucgen u2 = new Ucgen(0, 0, 0, 3, 4, 0); // 3, 4, 5 ucgeni olusturacak

            Console.WriteLine("\n# ToString Demo\n");
            Console.WriteLine(u1.UcgenString());    // ucgen bilgilerini yazar
            Console.WriteLine("\n");
            Console.WriteLine(u2.UcgenString());    // ucgen bilgilerini yazar

            Console.WriteLine("\n# Cevre Demo\n");
            Console.WriteLine(u2.CevreHesapla());   // u2 ucgenindeki bilgiler icindeki cevre ile ayni sonucu vermesi gerekiyor

            /**
             * KARE DEMO
             */
            Console.WriteLine("\n======= KARE DEMO =======\n");
            Kare k1 = new Kare(0, 0, 3, 2); // default noktalar ile olusmasi gerekiyor
            Kare k2 = new Kare(new Nokta(0, 3), new Nokta(3, 0));

            Console.WriteLine("\n# ToString Demo\n");
            Console.WriteLine(k1.KareString());
            Console.WriteLine("\n");
            Console.WriteLine(k2.KareString());

            /**
             * KARMASIK SAYI DEMO
             */
            Console.WriteLine("\n======= KARMASIK SAYI DEMO =======\n");
            KarmasikSayi ks1 = new KarmasikSayi();  // 0 + 0i olarak olusturur
            KarmasikSayi ks2 = new KarmasikSayi(5, 7); // 5 + 7i olarak olusturur
            KarmasikSayi ks3 = new KarmasikSayi(-9, -12); // -9 + (-12)i olarak olusturur
            KarmasikSayi ks4 = new KarmasikSayi(5, 7);  // 5 + 7i olarak olusturur

            KarmasikSayi ks12temp = ks1 - ks2;  // -5 + (-7)i olmasi gerekiyor
            KarmasikSayi ks13temp = ks1 + ks3;  // -9 + (-12)i olmasi gerekiyor

            KarmasikSayi ks3dbl = ks3 + 16;  // 7 + (-12)i olmas gerekiyor 

            Console.WriteLine(ks12temp.KarmasikSayiString());
            Console.WriteLine(ks13temp.KarmasikSayiString());
            Console.WriteLine(ks3dbl.KarmasikSayiString());

            if (ks2 == ks4)
            {
                Console.WriteLine("{0} ile {1} birbirine esittir", ks2.KarmasikSayiString(), ks4.KarmasikSayiString());
            }

            /**
            * RECURSIVE FUNCTION DEMO
            */
            Console.WriteLine("\n======= RECURSIVE FUNCTION DEMO =======\n");

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

            if (RecursiveMetotX(arr, 5))
            {
                Console.WriteLine("5 bulundu");
            }

            if (RecursiveMetotX(arr, 88))
            {
                Console.WriteLine("YAZILMAYACAK");
            }

            if (RecursiveMetotY(arr, 5, arr.Length - 1))
            {
                Console.WriteLine("5 bulundu");
            }

            if (RecursiveMetotY(arr, 88, arr.Length - 1))
            {
                Console.WriteLine("YAZILMAYACAK");
            }

            Console.ReadLine(); // ctrl + f5 ile calistirilmadiginda console ciktisini gorebilmek icin ekledim.
        }

        static bool RecursiveMetotX(int[] array, int anahtar)
        {
            // Gelen dizinin uzunlugu 1 den büyükse recursive fonksiyona array ın son elemanını çıkarıp gönderir.
            //if (array.Length > 1 && RecursiveMetotX(array.Where(w => w != array.Last()).ToArray(), anahtar))
            // ile de son eleman haricindekileri alabiliyorum.
            if (array.Length > 1 && RecursiveMetotX(array.Take(array.Length - 1).ToArray(), anahtar))
            {
                return true;
            }
            else
            {
                /*
                 * Recursive fonksiyonda sondan çıkarıp recursive haline geldiğinde 
                 * son elemana bakmak baştan arama yapma anlamına gelir.
                 */
                return (array[array.Length - 1] == anahtar) ? true : false;
            }
        }

        /**
         * Ustteki recursive metodun son indisini arguman olarak vererek yaptim.
         * Ancak bastan baslayarak arama yapmasi icin son indis numarasini vererek baslattim.
         */
        static bool RecursiveMetotY(int[] array, int anahtar, int lastIndex)
        {
            if (lastIndex > 0 && RecursiveMetotY(array, anahtar, lastIndex - 1))
            {
                return true;
            }
            else
            {
                return array[lastIndex] == anahtar ? true : false;
            }
        }

        /**
         * Argüman olarak aldığı dizinin içinde verilen 2. argüman olan anahtarı arar ve bulduğunda true, bulamadıysa false döner.
         * 
         * Argüman olarak aldığı dizinin 0.boyut uzunluğunu alır.
         * Daha sonra bu uzunluk boyunca 0. indisten başlayarak son indise gelene kadar
         * olan elemanların değerleri ile 2.argüman olan anahtar ile eşitliğini kontrol eder.
         * Eşitliği yakaladığında true, yakalayamazsa false döner.
         */
        static bool MetotX(int[] array, int anahtar)
        {
            int i = 0, n = array.GetLength(0);

            for (i = 0; i < n; i++)
            {
                if (array[i] == anahtar)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
