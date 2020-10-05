using System;

namespace cmd
{
    class Program
    {

        //static int mcd(int a, int b)
        //{
        //    if (b == 0) return a;
        //    return mcd(b, a % b);
        //}

        static int mcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }

            else
            {
                Console.WriteLine("todavia no. {0}/ {1} el resto de {2}", a, b, a % b);
                return mcd(b, a % b);
            }
        }
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Ingresar numero 1: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar numero 2: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("MCD: " + mcd(a,b));
            Console.ReadKey();

        }
    }
}
