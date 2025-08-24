using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace M320
{
    public class Calculate
    {
        public void groessterGemeinsamerTeiler(int a, int b)
        {
            int ggt = my_math.Calc_ggt(a, b);
            Console.WriteLine($"Der ggT von {a} und {b} ist: {ggt}");
        }

        public void ggT_rekursiv(int a, int b)
        {
            int ggt = my_math.Calc_ggt_r(a, b);
            Console.WriteLine($"Der ggT von {a} und {b} wurde rekursiv berechnet und entspricht {ggt}");
        }
        public void addieren(int a, int b)
        {
            int summe = my_math.Add(a, b);
            Console.WriteLine($"Summe von {a} und {b} = {summe}");
        }
        public void kleinstesGemeinsamesVielfach(int a, int b)
        {
            int kgv = my_math.Calc_kgv(a, b);
            Console.WriteLine($"Der kgV von {a} und {b} ist: {kgv}");
        }

        public void zahlEinlesen(int b)
        {
            int zahl = my_math.ReadInt(); // Zahl mit deiner Methode einlesen
            Console.WriteLine($"Du hast {zahl} eingegeben.");
        }

        public void ShowResult(string type, int a, int b)
        {
            type = "ggT";
            int result = my_math.Calc_ggt(a, b);
            Console.WriteLine($"{type} von {a} und {b} ist {result}");
        }

    }
}

