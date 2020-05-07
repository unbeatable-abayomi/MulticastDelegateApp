using System;

namespace MulticastDelegateApp
{
    class Program
    {
        public delegate void Calculate(int num1, int num2);

         public static void Addition(int num1,int num2)
        {
            Console.WriteLine($" The addition for both numbers is { num1 + num2}");
        }
        public static void Multiplication(int num1, int num2)
        {
            Console.WriteLine($" The Multiplication for both numbers is { num1 * num2}");
        }
        static void Main(string[] args)
        { Console.WriteLine("Kindly enter two numbers");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kindly enter the second numbers");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            //using generic delegates
            Action<int, int> calculateAll = Addition;
            calculateAll += Multiplication;
            Console.WriteLine("=========Using generic delegates=============");
            calculateAll(numberOne, numberTwo);
            //using non-generic delegates
            Console.WriteLine("=========Using non generic delegates=============");
           Calculate calculate = Addition;
            calculate += Multiplication;
           calculate.Invoke(numberOne, numberTwo);

            



            
        }


    }
}
