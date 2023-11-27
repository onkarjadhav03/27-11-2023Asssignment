using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Asignment21
{
    public delegate int ArithmaticOperations(int num1, int num2);
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int n2 = int.Parse(Console.ReadLine());

            Calculations c = new Calculations();

            ArithmaticOperations obj = new ArithmaticOperations(c.Add);
           

            Console.WriteLine("enter your choice 1.Add 2.sub 3.Mul 4.Div");
              int ch = int.Parse(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("Addition result:" + obj(n1, n2));
            }
            else if (ch == 2)
            {
                obj += new ArithmaticOperations(c.Sub);
                Console.WriteLine("Subtraction result:" + obj(n1, n2));
            }
            else if (ch == 3)
            {
                obj += new ArithmaticOperations(c.Mul);
                Console.WriteLine("Multiplication result:" + obj(n1, n2));
            }
            else if (ch == 4)
            {
                obj += new ArithmaticOperations(c.Div);
                Console.WriteLine("Division result:" + obj(n1, n2));
            }
        }
    }
}
