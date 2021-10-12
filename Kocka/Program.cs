using System;

namespace Kocka
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
        
        public static void Main(string[] args)
        {
            int a = ReadNum();

            Console.Out.WriteLine("Kocka felszine = " + Math.Pow(a,2) * 6);
            Console.Out.WriteLine("Kocka terfogata = " + Math.Pow(a,3));
        }
    }
}