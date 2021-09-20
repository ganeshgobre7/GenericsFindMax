 using System;

namespace GenericsFindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Programs");
            Console.WriteLine("Maximum value in Interger,Float,String");
            new FindMaxNumber<int>(100, 200, 300).MaxNumber();
            new FindMaxNumber<float>(100.10f, 200.20f, 300.30f).MaxNumber();
            new FindMaxNumber<string>("Apple", "Peach", "Banana").MaxNumber();
        }
    }   
}
