namespace M320
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int summe = my_math.Add(a, b);
            Console.WriteLine($"Summe von {a} und {b} = {summe}");
        }
    }



    internal class Program1
    {
            static void Main(string[] args)
            {
                int a = 2;
                int b = 3;

                int ggt = my_math.Calc_ggt(a, b);
                Console.WriteLine($"Der ggT von {a} und {b} ist: {ggt}");
            }
        }
    }



   

