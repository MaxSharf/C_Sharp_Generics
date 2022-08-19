using System;

namespace C_Sharp_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1();


            Console.ReadKey(true);
        }

         static void Problem1()
        {
            int a = 3;
            int b = 4;

            Console.WriteLine($" a = { a }\t b = {b}");


        }


        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;

        }
    }
}
