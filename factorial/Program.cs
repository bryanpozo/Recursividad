using System;

namespace factorial
{
    class Program
    {
        public static long factorial(int n)
        {
            if (n == 1)
                return 1;

            return n * factorial(n - 1);
            
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese el numero: ");
            n = Convert.ToInt32(System.Console.ReadLine());

            Console.WriteLine("Su factorial es: {0}",+factorial(n));
            Console.ReadKey();
        }
    }
}
