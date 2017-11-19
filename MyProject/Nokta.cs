using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Nokta
    {
        private int x;
        private int y;

        // orijin (0,0) noktasini olusturur
        public Nokta()
        {
            SetX(0);
            SetY(0);
        }

        // orijin (x,y) noktasini olusturur
        public Nokta(int x, int y)
        {
            SetX(x);
            SetY(y);
        }

        // mevcut objenin verilen koordinatlara olan uzakligini bulur
        public double Uzaklik(int x, int y)
        {
            return Math.Sqrt(((GetX() - x) * (GetX() - x)) + ((GetY() - y) * (GetY() - y)));
        }

        // mevcut objenin bu noktaya olan uzakligini bulur
        public double Uzaklik(Nokta nokta)
        {
            return this.Uzaklik(nokta.GetX(), nokta.GetY());
        }

        // nokta hakkinda metinsel olarak bilgi dondurur
        public string NoktaString()
        {
            return "Nokta(x:" + GetX() + ", y:" + GetY() + ")";
        }

        // getter x
        public int GetX()
        {
            return this.x;
        }

        // getter y
        public int GetY()
        {
            return this.y;
        }

        // setter x
        public void SetX(int x)
        {
            this.x = x;
        }

        // setter y
        public void SetY(int y)
        {
            this.y = y;
        }
    }
}
