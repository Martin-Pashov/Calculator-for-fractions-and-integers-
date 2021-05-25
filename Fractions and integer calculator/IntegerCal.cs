using System;
using System.Linq;

namespace Fractions_and_integer_calculator
{
    class IntegerCal
    {
        public void Run()
        {
            // We declare our varaiables
            string[] allowedOperators = new string[4] { "+", "-", "*", "/" };
            string type;
            int num1;
            int num2;
            int answer;


            //We get the operator type
            Console.WriteLine("What type of calculation do you want to perform (+, -, * or /)?");
            type = GetType(allowedOperators);


            //We get the first number
            Console.WriteLine("Write the first number.");
            num1 = GetNum();


            //We get the second number
            Console.WriteLine("Write the second number.");
            num2 = GetNum();


            //The calculation getting run.
            answer = Calculate(num1, num2, type);

            Console.WriteLine($"The answer is: {answer }");
        }


        private string GetType(string[] allowedOperators)
        {
            //We get the operator
            string type = Console.ReadLine();

            //Check if valid operator is selected
            while (!allowedOperators.Contains(type))
            {
                Console.WriteLine("Choose a valid operator type!");
                type = Console.ReadLine();
            }

            return type;
        }


        private int GetNum()
        {
            int num;
            //Checking if the parse was succesfull
            //Returns as a boolean
            bool parseCheck = Int32.TryParse(Console.ReadLine(), out num);

            //As long as boolean in fase, it keeps looping the input
            while (!parseCheck)
            {
                Console.WriteLine("\r\n" + "Try again! This time with an actual number...");
                parseCheck = int.TryParse(Console.ReadLine(), out num);
            }

            return num;
        }


        private int Calculate(int num1, int num2, string type)
        {
            //We deeclare our varaiables
            int result;

            //Check operator type
            if (type == "+")
            {
                result = num1 + num2;
                return result;
            }

            else if (type == "-")
            {
                result = num1 - num2;
                return result;
            }

            else if (type == "*")
            {
                result = num1 * num2;
                return result;
            }

            else
            {
                result = num1 / num2;
                return result;
            }
        }
    }

}
