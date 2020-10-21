using System;
using System.Runtime.InteropServices;

//exprot LD_LIBRARY_PATH=$LD_LIBRARY_PATH:$PWD
namespace callcpp
{
    class Program
    {
		[DllImport ("libtest.so", EntryPoint="sum")]
        static extern int sum(int a, int b);

		[DllImport ("libtest.so", EntryPoint="minus")]
        static extern int minus(int a, int b);

        static void Main(string[] args)
        {
			int x = sum(88, 42);
		 	Console.WriteLine("88 + 42 = {0}", x);

			x = minus(88, 42);
    		Console.WriteLine("88 - 42 = {0}", x);

            Console.WriteLine("Hello World!");
        }
    }
}
