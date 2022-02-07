using System;

namespace Laba1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(new string('—', 20) + "Вариант 7" + new string('—', 20));

            Console.WriteLine(new string('—', 20) + "1 задание" + new string('—', 20));
            Console.WriteLine(Fact(6));
            Console.WriteLine(new string('—', 20) + "2 задание" + new string('—', 20));
            double[] x = Sportsmen();
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('—', 20) + "3 задание" + new string('—', 20));
            for (double a = 0.1; a < 1; a += 0.05)
            {
                Console.WriteLine($" S: {Sum(a):F} \t f(x): {f(a):f} \t a:{a:f}");
            }
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
                sum1 += x * Math.Pow(1.1, i - 1);
            }

            double sum2 = 10;
            int days = 1;
            while (sum2 <= 100)
            {
                sum2 += x * Math.Pow(1.1, days - 1);
                days++;
            }

            int days1 = 1;
            double sum3 = 0;
            while (sum3 <= 20)
            {
                days1++;
                sum3 = 10 * Math.Pow(1.1, days1 - 1);
            }

            double[] arr = { sum1, days, days1 };
            return arr;
        }

        public static double f(double x)
            => (Math.Exp(x) + Math.Exp(-x)) / 2;

        public static double Sum(double x, int i)
            => Math.Pow(x, 2 * i) / Fact(2 * i);

        public static double Sum(double x)
        {
            double epsilon = 0.0001;
            double S = 0;
            for (int j = 1; ; j++)
            {
                if (Sum(x, j) < epsilon)
                    break;
                S += Sum(x, j);
            }
            return S;
        }
    }
}
