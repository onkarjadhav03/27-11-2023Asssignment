using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Assignment21_part2
{
    public delegate T ArithmeticOperation<T>(T num1, T num2);
    internal class Program
    {
        static void Main()
        {
            Program calculator = new Program();

            while (true)
            {
                Console.WriteLine("Enter two numbers:");
                Console.WriteLine("Enter the first number: ");
                double num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                double num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.WriteLine("enter your choice");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 5)
                {
                    break;
                }

                ArithmeticOperation<double> operation = null;

                switch (choice)
                {
                    case 1:
                        operation = Add;
                        break;
                    case 2:
                        operation = Subtract;
                        break;
                    case 3:
                        operation = Multiply;
                        break;
                    case 4:
                        operation = Divide;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        continue;
                }

                double result = calculator.PerformOperation(operation, num1, num2);
                Console.WriteLine($"Result: {result}");
            }
        }

        

        private static double Add(double a, double b)
        {
            return a + b;
        }

        private static double Subtract(double a, double b)
        {
            return a - b;
        }

        private static double Multiply(double a, double b)
        {
            return a * b;
        }

        private static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero. Please enter a non-zero divisor.");
                return 0;
            }

            return a / b;
        }

        private T PerformOperation<T>(ArithmeticOperation<T> operation, T num1, T num2)
        {
            return operation(num1, num2);
        }
    }
}
