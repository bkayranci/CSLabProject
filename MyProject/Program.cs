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
            //if (MetotX(new int[] { 3, 5, 4}, 7))
            //{
            //    Console.WriteLine("true");
            //}

            //if (RecursiveMetotX(new int[] { 7, 5, 4}, 7))
            //{
            //    Console.WriteLine("TRUE");
            //}

            //nokta nokta1 = new nokta(0, 3);
            //nokta nokta2 = new nokta(4, 0);
            //console.writeline(nokta1.uzaklik(nokta2));

            //Ucgen ucgen = new Ucgen(0, 0, 0, 1, 0, 2);
            //Console.WriteLine(ucgen.UcgenString());

            //Kare kare = new Kare(0,5,5,0);
            //Console.WriteLine(kare.KareString());

            //KarmasikSayi karmasikSayi1 = new KarmasikSayi(3, 4);
            //KarmasikSayi karmasikSayi2 = new KarmasikSayi(43, 4);
            //Console.WriteLine(karmasikSayi1 != karmasikSayi2);

        }

        static bool RecursiveMetotX(int[] array, int anahtar)
        {
            // Gelen dizinin uzunlugu 1 den büyükse recursive fonksiyona array ın son elemanını çıkarıp gönderir.
            //if (array.Length > 1 && RecursiveMetotX(array.Where(w => w != array.Last()).ToArray(), anahtar))
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
