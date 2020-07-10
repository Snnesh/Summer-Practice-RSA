using System;

namespace Summer_practice_RSA
{
    class Program
    {
        static void Main(string[] args)
        {

            static double nod(double e, double fi)
            {
                if (e == fi)
                    return e;
                else
                    if (e > fi)
                    return nod(e - fi, fi);
                else
                    return nod(fi - e, e);
            }

            int nad(int n)
            {
                for (int i = 2; i <= n / 2; i++) if ((n % i) == 0) return 0;
                return 1;
            }

            {
                Console.WriteLine("Введите числа p q:");
                int p = int.Parse(Console.ReadLine());
                int q = int.Parse(Console.ReadLine());
                double n = p * q;
                Console.WriteLine("Значение n:" + n.ToString());
                double fi = (p - 1) * (q - 1);
                Console.WriteLine("Значение fi:" + fi.ToString());
                int g = 0;
                int l = 0;
                double e = 0;
                for (int i = 0; i < fi; i++)
                {
                    l++;
                    if (nad(l) == 1)
                        if (l < fi)
                            if (nod(l, fi) == 1)
                            { g++; e = l; }
                }
                Console.WriteLine("Всего значений e:" + g);
                Console.WriteLine("Пусть значение e = " + e);
                double d = 0;
                int b = 0;
                while (b < 5)
                {
                    if ((d * e) % n == 1)
                    {
                        b++;
                        Console.WriteLine("Одно из 5 значений d:" + d);
                        d++;
                    }

                    else d++;
                }

                Console.WriteLine("Один из открытых ключей: {" + e + "," + n + "}");
                Console.WriteLine("Один из закрытых ключей: {" + d + "," + n + "}");
                Console.ReadKey();

            }
        }
    }
}
