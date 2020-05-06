using System;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {

        public static int firstNumber = 3;
        public static int secondNumber = 3;


        static void Main(string[] args)
        {
            int result = firstNumber + secondNumber;
            PrintStatement(result);
        }

        static void PrintStatement(int result)
        {   
            Console.WriteLine("The Result:" + result);
        }
    }
}
