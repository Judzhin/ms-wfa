using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitFlags
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowAllBits();
            Console.ReadKey();
        }

        static void ShowAllBits()
        {
            for (int i = 1; i < 32; i++)
                Console.WriteLine("{0} - {1}", i, (MyBit)i);
        }
    }

    [Flags]
    enum MyBit
    {
        V1 = 1,
        V2 = 2,
        V3 = 4,
        V4 = 8,
        V5 = 16
    }
}
