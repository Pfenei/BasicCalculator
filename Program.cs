using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number:");
            string firstNum = Console.ReadLine();
            int num1 = Convert.ToInt32(firstNum);
            Console.WriteLine("Enter the operator ( +, -, *, /, %) :");
            string op = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            string secondNum = Console.ReadLine();
            int num2 = Convert.ToInt32(secondNum);

            int result = 0;
           
            if (op == "+")
            {
                result = num1 + num2;
            }
            else if (op == "-")
            {
                result = num1 - num2;
            }
            else if (op == "*")
            {
                result = num1 * num2;
            }
            else if (op == "/")
            {
                result = num1 / num2;
            }
            else if (op == "%")
            {
                result = num1 % num2;   
            }
            Console.WriteLine("The result is:" + result);
            Console.WriteLine("Calculation finished. Press any key to exit.");
            Console.ReadLine();
        }
    }
}
