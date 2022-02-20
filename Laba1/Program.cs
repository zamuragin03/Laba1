using System;
using static System.Math;

namespace Laba1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(new string('—', 20) + "Вариант 7" + new string('—', 20));

            #region 1 уровень
            Console.WriteLine(new string('—', 20) + "1 уровень" + new string('—', 20));

            Console.WriteLine(new string('—', 20) + "7 задание" + new string('—', 20));
            Console.WriteLine("6!=" + Fact(6));
            Console.WriteLine(new string('—', 20) + "8 задание" + new string('—', 20));
            Console.WriteLine(SummFact());
            Console.WriteLine(new string('—', 20) + "9 задание" + new string('—', 20));
            Console.WriteLine(Summ());
            #endregion
            #region 2 уровень
            Console.WriteLine(new string('—', 20) + "2 уровень" + new string('—', 20));
            Console.WriteLine(new string('—', 20) + "7 задание" + new string('—', 20));
            double[] x = Sportsmen();
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('—', 20) + "8 задание" + new string('—', 20));
            Console.WriteLine(Banker() + " месяцев");
            Console.WriteLine(new string('—', 20) + "9 задание" + new string('—', 20));
            Console.WriteLine($"{Cutter()} раз");
            #endregion

            #region 3 уровень
            Console.WriteLine(new string('—', 20) + "3 уровень" + new string('—', 20));
            for (double a = 0.1; a < 1; a += 0.05)
            {
                Console.WriteLine($" S: {Sum(a):F} \t f(x): {f(a):f} \t a:{a:f}");
            }
            #endregion

        }


        public static int Fact(int x)
        {
            if (x == 0)
                return 1;
            return x * Fact(x - 1);

        }

        public static double[] Sportsmen()
        {
            int x = 10;
            double sum1 = 0;
            for (int i = 1; i <= 7; i++)
            {
                sum1 += x * Pow(1.1, i - 1);
            }

            double sum2 = 10;
            int days = 1;
            while (sum2 <= 100)
            {
                sum2 += x * Pow(1.1, days - 1);
                days++;
            }

            int days1 = 1;
            double sum3 = 0;
            while (sum3 <= 20)
            {
                days1++;
                sum3 = 10 * Pow(1.1, days1 - 1);
            }

            double[] arr = {sum1, days, days1};
            return arr;
        }

        public static double f(double x)
            => (Exp(x) + Exp(-x)) / 2;

        public static double Sum(double x, int i)
            => Pow(x, 2 * i) / Fact(2 * i);

        public static double Sum(double x)
        {
            double epsilon = 0.0001;
            double S = 0;
            for (int j = 1;; j++)
            {
                if (Sum(x, j) < epsilon)
                    break;
                S += Sum(x, j);
            }

            return S;
        }

        public static int SummFact()
        {
            int sum = 0;
            for (int i = 1; i <= 6; i++)
            {
                sum += Fact(i);
            }

            return sum;
        }

        public static double Summ()
        {
            double sum = 0;
            for (int i = 0; i <= 6; i++)
            {
                sum += Pow(-1, i) * Pow(5, i) / Fact(i);
            }

            return sum;
        }

        public static int Banker()
        {
            double Summa = 10000;
            int Months = 0;
            while (Summa<20000)
            {
                Months++;
                Summa *= 1.08;

            }
            return Months;
        }

        public static int Cutter()
        {
            double Da = Pow(10, -10);
            double l = 0.1;
            int count = 0;
            while (l>Da)
            {
                count++;
                l = 0.1 / Pow(2, count);
            }

            return count;
        }
    }
}
