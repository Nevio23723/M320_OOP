using System.Runtime.InteropServices;
using M320;

namespace M320
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            string type = "kgV";
            Calculate calculate = new Calculate();
            calculate.addieren(a, b);
            calculate.groessterGemeinsamerTeiler(a, b);
            calculate.ggT_rekursiv(a, b);
            calculate.kleinstesGemeinsamesVielfach(a, b);
            calculate.zahlEinlesen(b);
            calculate.ShowResult(type, a, b);
        }
    }




}







