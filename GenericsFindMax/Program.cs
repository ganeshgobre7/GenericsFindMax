 using System;

namespace GenericsFindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Programs");
            int intMax = FindMaxNumber.IntMaxNumber(100, 200, 300);
            Console.WriteLine("Maximum Integer Number is :" + intMax);
        }
    }
}
