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
        public int Sub(int a,int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Roman r = new Roman();
            r.Crazy();
        }
    }
}
