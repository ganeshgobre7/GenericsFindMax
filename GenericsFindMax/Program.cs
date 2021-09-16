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

            float flotMax = FindMaxNumber.FloatMaxNumber(100.10f, 200.20f, 300.30f);
            Console.WriteLine("Maximum Float Number is :" + flotMax);

            string stringMax = FindMaxNumber.StringMaxNumber("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum String Number is :" + stringMax);
        }
    }   
}
