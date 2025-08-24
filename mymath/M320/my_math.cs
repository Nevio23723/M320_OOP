using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace M320
{
    internal class my_math
    {
        static internal int Add(int a, int b)
        {
            return a + b;
        }

        static internal int Calc_ggt(int a, int b)
        {

            while (b != 0)
            {
                int z = a % b;
                a = b;
                b = z;

            }
            return a;
        }

        static internal int Calc_ggt_r(int a, int b)
        {
            if (b == 0)
                return a;
            else return Calc_ggt(b, a%b);
        }

        static internal int Calc_kgv(int a, int b)
        {

            if (a == 0 | b == 0)
            {
                return 0;
            }

            int ggt = Calc_ggt(a, b);
            return (a * b) / ggt;
        }

        static internal int ReadInt()
        {
            int value;
            while (true)
            {
                Console.Write("Bitte eine positive ganze Zahl eingeben: ");
                if (int.TryParse(Console.ReadLine(), out value) && value > 0)
                    return value;

                Console.WriteLine("Ungültige Eingabe! Zahl muss > 0 sein.");
            }
        }

        static internal string ShowResult(string type, int a, int b, int result)
        {
            return $"{type} von {a} und {b} ist {result}";
        }


    }
}

