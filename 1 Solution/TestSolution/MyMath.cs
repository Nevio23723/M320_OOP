using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320
{
    internal class my_math
    {
        static internal int Calc_ggT(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return Calc_ggT(b, a % b);
            }
        }

        static internal int Calc_kgV(int a, int b)
        {
            if (b != 0)
            {
                return a % b;
            }
            else
            {
                return a;
            }
        }

        public static int ReadInt()
        {
            int zahl;
            while (true)
            {
                Console.Write("Bitte positive Zahl eingeben: ");
                if (int.TryParse(Console.ReadLine(), out zahl) && zahl > 0)
                {
                    return zahl;
                }
                Console.WriteLine("Ungültig! Zahl muss > 0 sein.");
            }
        }
    }
}
