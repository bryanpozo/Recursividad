using System;

namespace Sumatoria
{
    class Program
    {
        static int sumatoria(int n)
        {
            if (n == 1)
                return 1;

            else
            {
                return n + sumatoria(n - 1);
            }
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingresar la cantidad a sumar:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("La sumatoria es:" + sumatoria(n));
            Console.ReadLine();
        }
    }
}
