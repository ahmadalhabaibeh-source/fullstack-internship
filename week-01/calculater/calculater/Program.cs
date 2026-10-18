using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculater
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Hello to the calculator!");

            try
            {
                Console.WriteLine("Enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the operation (+, -, *, /):");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (operation)
                {
                    case '+':
                        Console.WriteLine($"Result: {num1 + num2}");
                        break;
                    case '-':
                        Console.WriteLine($"Result: {num1 - num2}");
                        break;
                    case '*':
                        Console.WriteLine($"Result: {num1 * num2}");
                        break;
                    case '/':
                        if (num2 != 0)
                            Console.WriteLine($"Result: {num1 / num2}");
                        else
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        break;
                    default:
                        Console.WriteLine("Error: Invalid operation.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: You entered letters! Please enter numbers only.");
            }
    }
}
