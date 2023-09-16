using System.Diagnostics.Metrics;
using System.Globalization;

namespace Methods_Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(calculation());
            Console.ReadLine();
        }

        public static int calculation()
        {
            Console.Write("please enter first number: ");
            string number1 = Console.ReadLine();
            Console.Write("please enter second number : ");
            string number2 = Console.ReadLine();

            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);

            int result;
            return result = num1 + num2;


        }
    }
}