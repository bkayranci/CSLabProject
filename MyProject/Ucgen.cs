using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Ucgen
    {
        Nokta p1;
        Nokta p2;
        Nokta p3;

        // verilen uc nokta koordinati ile ucgen olusturulabiliyorsa ucgen olustur, olusturulamazsa default noktalar verilir
        public Ucgen(int p1x, int p1y, int p2x, int p2y, int p3x, int p3y):this(new Nokta(p1x, p1y), new Nokta(p2x, p2y), new Nokta(p3x, p3y))
        {
        }

        // verilen uc nokta ile ucgen olusturulabiliyorsa ucgen olusturur, olusturulamazsa default noktalar verilir
        public Ucgen(Nokta p1, Nokta p2, Nokta p3)
        {
            if (UcgenKontrol(p1, p2, p3))
            {
                this.p1 = p1;
                this.p2 = p2;
                this.p3 = p3;
            }
            else
            {
                this.p1 = new Nokta(0, 0);
                this.p2 = new Nokta(0, 1);
                this.p3 = new Nokta(1, 0);

                Console.WriteLine("Ucgen default noktalar ile olusturuldu.");
                this.ToString();
            }
        }

        // kenarlar esitse 'eskenar', iki kenar esit digeri farkli ise 'ikizkenar', hepsi farkli ise 'cesitkenar' ucgen yazar
        public string UcgenTipi()
        {
            if (p1.Uzaklik(p2) == p2.Uzaklik(p3) && p2.Uzaklik(p3) == p3.Uzaklik(p1) && p3.Uzaklik(p1) == p1.Uzaklik(p2))
            {
                return "eskenar";
            }
            else if (p1.Uzaklik(p2) == p2.Uzaklik(p3) || p2.Uzaklik(p3) == p3.Uzaklik(p1) || p3.Uzaklik(p1) == p1.Uzaklik(p2))
            {
                return "ikizkenar";
            }
            else if (p1.Uzaklik(p2) != p2.Uzaklik(p3) && p2.Uzaklik(p3) != p3.Uzaklik(p1) && p3.Uzaklik(p1) != p1.Uzaklik(p2))
            {
                return "cesitkenar";
            }

            return null;
        }

        // ucgenin cevresini hesaplar
        public double CevreHesapla()
        {
            return p1.Uzaklik(p2) + p2.Uzaklik(p3) + p3.Uzaklik(p1);
        }

        // verilen noktalar ile ucgen olusturulup olusturulamayacagini kontrol eder
        public bool UcgenKontrol(Nokta p1, Nokta p2, Nokta p3)
        {
            double uz1 = p1.Uzaklik(p2);
            double uz2 = p2.Uzaklik(p3);
            double uz3 = p3.Uzaklik(p1);

            return ((uz3 < uz1 + uz2) && (uz2 < uz1 + uz3) && (uz1 < uz2 + uz3)) ? true : false;
        }

        // ucgen hakkinda metinsel bilgi dondurur
        public string UcgenString()
        {
            return "Ucgen Noktaları: " + p1.NoktaString() + " " + p2.NoktaString() + " " + p3.NoktaString() + "\nÇevre: " + CevreHesapla();
        }

        // getter p1
        public Nokta GetP1()
        {
            return this.p1;
        }

        // getter p2
        public Nokta GetP2()
        {
            return this.p2;
        }

        // getter p3
        public Nokta GetP3()
        {
            return this.p3;
        }

        // setter p1
        public void SetP1(Nokta p1) => this.p1 = p1;

        //setter p2
        public void SetP2(Nokta p2) => this.p2 = p2;

        //setter p3
        public void SetP3(Nokta p3) => this.p3 = p3;
    }
}
