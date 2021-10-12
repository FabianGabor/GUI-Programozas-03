using System;

namespace HaromszogKerulete
{
    internal class Program
    {
        static int ReadNum()
        {
            int a = 0;
            do
            {
                try
                {
                    Console.Out.Write("a = ");
                    a = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                }
            } while (a <= 0);

            return a;
        }

        static bool EgyenloSzaru(int a, int b, int c)
        {
            if (a == b || a == c || b == c) return true;
            return false;
        }

        static bool EgyenloOldalu(int a, int b, int c)
        {
            if (a == b && a == c && b == c) return true;
            return false;
        }

        public static void Main(string[] args)
        {
            // 3 bekért szám, ez a 3 szám a háromszög oldalai, kerületet számítani.
            int a, b, c;
            do
            {
                a = ReadNum();
                b = ReadNum();
                c = ReadNum();
            } while (a + b < c || a + c < b || b + c < a);

            Console.Out.WriteLine("a = " + a);
            Console.Out.WriteLine("b = " + b);
            Console.Out.WriteLine("c = " + c);

            Console.Out.WriteLine("Kerulet = " + (a + b + c));

            if (EgyenloSzaru(a, b, c)) Console.Out.WriteLine("Egyenlo szaru haromszog");
            if (EgyenloOldalu(a, b, c)) Console.Out.WriteLine("Egyenlo oldalu haromszog");

            Console.Out.WriteLine("a + b = " + (a + b));
            Console.Out.WriteLine("a - b = " + (a - b));
            Console.Out.WriteLine("a * b = " + (a * b));
            Console.Out.WriteLine("a : b = " + (a / b));
            Console.Out.WriteLine("a % b = " + (a % b));
            Console.Out.WriteLine("a / b = " + (a * 1.0 / b));
        }
    }
}