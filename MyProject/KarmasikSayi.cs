using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class KarmasikSayi
    {
        private double reel;
        private double sanal;

        public KarmasikSayi(double reel, double sanal)
        {
            this.reel = reel;
            this.sanal = sanal;
        }

        public KarmasikSayi():this(0,0)
        {
        }

        public static KarmasikSayi operator + (KarmasikSayi ks1, KarmasikSayi ks2)
        {
            return new KarmasikSayi((ks1.reel + ks2.reel), (ks1.sanal + ks2.sanal));
        }

        public static KarmasikSayi operator + (KarmasikSayi ks, double dbl)
        {
            return new KarmasikSayi((ks.reel + dbl), ks.sanal);
        }

        public static bool operator == (KarmasikSayi ks1, KarmasikSayi ks2)
        {
            return ((ks1.reel == ks2.reel) && (ks1.sanal == ks2.sanal)) ? true : false;
        }

        public static bool operator != (KarmasikSayi ks1, KarmasikSayi ks2)
        {
            return ((ks1.reel == ks2.reel) && (ks1.sanal == ks2.sanal)) ? false : true;
        }

        public static KarmasikSayi operator - (KarmasikSayi ks1, KarmasikSayi ks2)
        {
            return new KarmasikSayi((ks1.reel - ks2.reel), (ks1.sanal - ks2.sanal));
        }

        public static KarmasikSayi operator - (KarmasikSayi ks, double dbl)
        {
            return new KarmasikSayi((ks.reel - dbl), ks.sanal);
        }

        public static KarmasikSayi operator - (KarmasikSayi ks)
        {
            return new KarmasikSayi(-ks.reel, -ks.sanal);
        }

        public static KarmasikSayi operator * (KarmasikSayi ks1, KarmasikSayi ks2)
        {
            return new KarmasikSayi((ks1.reel * ks2.reel) - (ks1.sanal * ks2.sanal), (ks1.reel * ks2.sanal) + (ks1.sanal * ks2.reel));
        }

        public string KarmasikSayiString()
        {
            if (sanal < 0)
            {
                return reel + " + (" + sanal + ")i";
            }
            else
            {
                return reel + " + " + sanal + "i";
            }
        }
    }
}
