using System;

namespace SeeSharpLearning
{
    class Program
    {
        public delegate void delmethod();

        public class P
        {
            public static void hello()
            {
                Console.WriteLine("Hello");
            }

            public static void show()
            {
                Console.WriteLine("Show");
            }

            public  void print()
            {
                Console.WriteLine("Print");
            }
        }

        static void Main(string[] args)
        {
            //static metoda en način
           delmethod d1 = P.hello;

            //static metoda drug način
            delmethod d2 = new delmethod(P.show);

            //metoda ni static
            P obj = new P();
            delmethod d3 = obj.print;

            d1();
            d2();
            d3();
            Console.ReadLine();
        }
    }
}
