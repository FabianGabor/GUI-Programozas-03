using System;
using System.Linq;

namespace Lotto
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            
            int[] lottoszamok = new int[5];
            int maxLottoszam = 99;

            for (int i = 1; i < lottoszamok.Length; i++)
            {
                int sorsolt;
                do
                {
                    sorsolt = random.Next(maxLottoszam);
                } while (lottoszamok.Contains(sorsolt));

                lottoszamok[i] = sorsolt;
            }

            for (int i=0; i<lottoszamok.Length; i++)
                Console.Out.Write(lottoszamok[i] + " ");

        }
    }
}