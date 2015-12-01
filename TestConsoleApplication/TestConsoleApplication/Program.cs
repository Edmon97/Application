using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsoleApplication
{
    class Roman
    {
        public void Crazy()
        {
            Console.WriteLine("Roman is Crazy.");
        }
    }
    class Math
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            int a = 100;
            int b = 50;
            Console.WriteLine("Add: " + math.Add(a, b));
            Console.WriteLine("Sub: " + math.Sub(a, b));

            Roman r = new Roman(); // test
            r.Crazy();
        }
    }
}
