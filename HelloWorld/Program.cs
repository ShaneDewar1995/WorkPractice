using System;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {

        public static int firstNumber = 1;
        public static int secondNumber = 3;

        static void Main(string[] args)
        {
            PrintStatement();
        }

        static void PrintStatement()
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine("Result:" + result);
        }
    }
}
