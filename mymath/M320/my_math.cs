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
    }
}

