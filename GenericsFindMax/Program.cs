 using System;

namespace GenericsFindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Programs");
            int intMax = FindMaxNumber.MaxNumber<int>(100, 200, 300);
            Console.WriteLine("Maximum Integer Number is :" + intMax);
            float floatMax = FindMaxNumber.MaxNumber<float>(100.10f, 200.20f, 300.30f);
            Console.WriteLine("Maximum Float Number is :" + floatMax);
            string stringMax = FindMaxNumber.MaxNumber<string>("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum String Number is :" + stringMax);
        }
    }   
}
