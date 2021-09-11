using System;

namespace _04._09._21_Классы_и_перегрузка
{
    class Program
    {
        static void Main(string[] args)
        {
           // Money m = new Money();
            while (true)
            {                
                Console.WriteLine("Введите копейки для добавления");
                string buf = Console.ReadLine();
                int n;
                if (int.TryParse(buf, out n))
                {
                    Money m = Add(n);
                    //m.AddKopeks(n);
                    Console.WriteLine(m.Print());
                } else
                {
                    Console.WriteLine("Ошибка ввода данных");
                }
            }
        }

        public static Money Add(int k)
        {
            Money m = new Money();
            m.AddKopeks(k);
            return m;
        }
    }
}
