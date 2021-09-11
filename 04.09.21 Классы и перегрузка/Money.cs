using System;
using System.Collections.Generic;
using System.Text;

namespace _04._09._21_Классы_и_перегрузка
{
    class Money
    {
        private int rubles;
        private int kopeks;

        public int Rubles
        {
            get
            {
                return rubles;
            }

            set
            {
                rubles = value;
            }
        }

        public int Kopeks
        {
            get
            {
                return kopeks;
            }

            set
            {
                kopeks = value;
            }
        }

        public void AddKopeks(int k)
        {
            int summa = kopeks + k;
            int r = summa / 100;
            if (r > 0)
            {
                rubles += r;
                kopeks = summa - r * 100;
            }
            else
            {
                kopeks = summa;
            }
        }

        public string Print()
        {
            return (rubles > 0 ? rubles + " рублей " : string.Empty) + (kopeks > 0 ? kopeks + " копеек" : string.Empty);
        }

    }
}



