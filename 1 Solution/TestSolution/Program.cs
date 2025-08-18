namespace M320

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 60;
            int ggT = my_math.Calc_ggT(a, b);
            int kgV = my_math.Calc_kgV(a, b);
            Console.WriteLine($"ggT von {a} und {b} = {ggT}");
            Console.WriteLine($"kgv von {a} und {b} = {kgV}");
        }
        static int ReadInt()
        {
            int zahl = 0;
            while (true)
            {
                Console.Write("Bitte geben Sie eine Positive Zahl ein.");
                if (int.TryParse(Console.ReadLine(), out zahl) && zahl > 0)
                {
                    return zahl;
                }
                Console.WriteLine("Ungültige Zahl.");
            }
        }
    }
}

