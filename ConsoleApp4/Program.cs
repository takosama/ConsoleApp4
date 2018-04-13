using System;
using System.Runtime.Intrinsics.X86;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int ans = 0;
            for (int i = 0; i < 100; i++)
                ans += i;

            Console.WriteLine(ans);
        }
    }
}
