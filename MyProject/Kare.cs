using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Kare
    {
        Nokta sagAlt;
        Nokta solUst;

        enum Kenar
        {
            DUSEY,
            DIKEY
        }

        // verilen sag alt ve sol ust nokta koordinatlari ile kare olusturulabiliyorsa kare olusturur, olusturulamiyorsa default noktalarla olusturur
        public Kare(int p1x, int p1y, int p2x, int p2y)
        {
            if (KareKontrol(p1x, p1y, p2x, p2y))
            {
                if (p1x > p2x)
                {
                    this.sagAlt = new Nokta(p1x, p1y);
                    this.solUst = new Nokta(p2x, p2y);
                }
                else
                {
                    this.solUst = new Nokta(p1x, p1y);
                    this.sagAlt = new Nokta(p2x, p2y);
                }
            }
            else
            {
                this.sagAlt = new Nokta(1, 0);
                this.solUst = new Nokta(0, 1);
            }
        }

        // verilen sag alt ve sol ust noktalar ile kare olusturulabiliyorsa kare olusturur, olusturulamiyorsa default noktalarla olusturur
        public Kare(Nokta sagAlt, Nokta solUst):this(sagAlt.GetX(), sagAlt.GetY(), solUst.GetX(), solUst.GetY())
        {
        }

        // kare alanini hesaplar
        public double Alan()
        {
            return this.getKenarUzunlugu() * getKenarUzunlugu();
        }

        // kare cevresini hesaplar
        public double KareCevre()
        {
            return this.getKenarUzunlugu() * 4;
        }

        // verilen nokta koordinatlari ile kare olusturup olusturamadigini kontrol eder
        private bool KareKontrol(int p1x, int p1y, int p2x, int p2y)
        {
            double kenar1 = Math.Abs(p1x - p2x);
            double kenar2 = Math.Abs(p1y - p2y);

            return kenar1 == kenar2 ? true : false;
        }

        // verilen noktalar ile kare olusturup olusturamadigini kontrol eder
        private bool KareKontrol(Nokta p1, Nokta p2)
        {
            return KareKontrol(p1.GetX(), p1.GetY(), p2.GetX(), p2.GetY());
        }

        // kare ile ilgili metinsel bilgi dondurur
        public string KareString()
        {
            return "Kare Alanı: " + this.Alan() + "\nKare Cevresi: " + this.KareCevre() + "\nNoktalari: " + solUst.NoktaString() + " " + sagAlt.NoktaString();
        }

        // karenin default olarak dikey kenarini kullanarak kenar uzunlugunu hesaplar istege gore dusey kenar da kullanilabilir
        private double getKenarUzunlugu(Kenar kenar = Kenar.DIKEY)
        {
            if (kenar == Kenar.DUSEY)
                return Math.Abs(this.sagAlt.GetX() - this.solUst.GetX());
            return Math.Abs(this.sagAlt.GetY() - this.solUst.GetY());
        }

        // getter solUst
        public Nokta GetSolUst()
        {
            return this.solUst;
        }

        // getter salAlt
        public Nokta GetSagAlt()
        {
            return this.sagAlt;
        }

        // setter solUst
        public void SetSolUst(Nokta solUst) => this.solUst = solUst;

        // setter sagAlt
        public void SetSagAlt(Nokta sagAlt) => this.sagAlt = sagAlt;
    }
}
