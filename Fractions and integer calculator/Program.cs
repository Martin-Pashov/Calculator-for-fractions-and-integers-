using System;
using System.Text.RegularExpressions;

namespace Fractions_and_integer_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            RunCalculator();
        }

        static void RunCalculator()
        {
            Console.WriteLine("What type of calculation do you want to perform? \r\nIf you want to calculate the sum of integers, type in 'integer' and 'fraction' if you want to calculate fractions. ");

            string type;
            string restartCheck;
            string typeOfCalculation = Console.ReadLine();
            bool isgGeaterThan;


            //If the input is "fraction" we use the 'Fraction class' where we do some things

            if (typeOfCalculation == "fraction")
            {
                Console.WriteLine("\r\n" + "You can use the following operators: ('+', '-', '*', '/', '<', '>', '<=', '>=', '==' and '!=')");
                Console.Write("Enter your fraction math problem here: ");

                Regex gerX = new Regex(@"(?:[1-9][0-9]*|0)\/[1-9][0-9]* ((!=)|(<=)|(>=)|(>)|(<)|(==)|(\+)|(\-)|(\/)|(\*)) (?:[1-9][0-9]*|0)\/[1-9][0-9]*");
                string input = Console.ReadLine();
                string[] newFraction;

                if (gerX.IsMatch(input))
                {
                    if (input.Contains('+'))
                    {
                        newFraction = input.Split('/', '+');

                        int num1 = int.Parse(newFraction[0]);
                        int num2 = int.Parse(newFraction[1]);

                        Fraction fraction1 = new Fraction(num1, num2);


                        int num3 = int.Parse(newFraction[2]);
                        int num4 = int.Parse(newFraction[3]);

                        Fraction fraction2 = new Fraction(num3, num4);

                        Console.WriteLine($"Your answer is: {fraction1 + fraction2}");
                    }



                    else if (input.Contains('-'))
                    {
                        newFraction = input.Split('/', '-');

                        int num1 = int.Parse(newFraction[0]);
                        int num2 = int.Parse(newFraction[1]);

                        Fraction fraction1 = new Fraction(num1, num2);


                        int num3 = int.Parse(newFraction[2]);
                        int num4 = int.Parse(newFraction[3]);

                        Fraction fraction2 = new Fraction(num3, num4);

                        Console.WriteLine($"Your answer is: {fraction1 - fraction2}");
                    }



                    else if (input.Contains('*'))
                    {
                        newFraction = input.Split('/', '*');

                        int num1 = int.Parse(newFraction[0]);
                        int num2 = int.Parse(newFraction[1]);

                        Fraction fraction1 = new Fraction(num1, num2);


                        int num3 = int.Parse(newFraction[2]);
                        int num4 = int.Parse(newFraction[3]);

                        Fraction fraction2 = new Fraction(num3, num4);

                        Console.WriteLine($"Your answer is: {fraction1 * fraction2}");
                    }



                    else if (input.Contains(" > "))
                    {
                        newFraction = input.Split('/', '>');

                        int num1 = int.Parse(newFraction[0]);
                        int num2 = int.Parse(newFraction[1]);

                        Fraction fraction1 = new Fraction(num1, num2);


                        int num3 = int.Parse(newFraction[2]);
                        int num4 = int.Parse(newFraction[3]);

                        Fraction fraction2 = new Fraction(num3, num4);


                        if (fraction1 > fraction2)
                        {
                            isgGeaterThan = true;
                            Console.WriteLine(isgGeaterThan);
                        }
                        else
                        {
                            isgGeaterThan = false;
                            Console.WriteLine(isgGeaterThan);
                        }
                    }



                    else if (input.Contains(" < "))
                    {
                        newFraction = input.Split('/', '<');

                        int num1 = int.Parse(newFraction[0]);
                        int num2 = int.Parse(newFraction[1]);

                        Fraction fraction1 = new Fraction(num1, num2);


                        int num3 = int.Parse(newFraction[2]);
                        int num4 = int.Parse(newFraction[3]);

                        Fraction fraction2 = new Fraction(num3, num4);


                        if (fraction1 < fraction2)
                        {
                            isgGeaterThan = true;
                            Console.WriteLine(isgGeaterThan);
                        }
                        else
                        {
                            isgGeaterThan = false;
                            Console.WriteLine(isgGeaterThan);
                        }
                    }



                    else if (input.Contains("<="))
                    {
                        newFraction = input.Split(new string[] { "/", "<=" }, StringSplitOptions.RemoveEmptyEntries);

                        int number1 = int.Parse(newFraction[0]);
                        int number2 = int.Parse(newFraction[1]);

                        Fraction drop1 = new Fraction(number1, number2);


                        int number3 = int.Parse(newFraction[2]);
                        int number4 = int.Parse(newFraction[3]);

                        Fraction drop2 = new Fraction(number3, number4);


                        if (drop1 <= drop2)
                        {
                            isgGeaterThan = true;
                            Console.WriteLine(isgGeaterThan);
                        }
                        else
                        {
                            isgGeaterThan = false;
                            Console.WriteLine(isgGeaterThan);
                        }
                    }



                    else if (input.Contains(">="))
                    {
                        newFraction = input.Split(new string[] { "/", ">=" }, StringSplitOptions.RemoveEmptyEntries);

                        int number1 = int.Parse(newFraction[0]);
                        int number2 = int.Parse(newFraction[1]);

                        Fraction drop1 = new Fraction(number1, number2);


                        int number3 = int.Parse(newFraction[2]);
                        int number4 = int.Parse(newFraction[3]);

                        Fraction drop2 = new Fraction(number3, number4);


                        if (drop1 >= drop2)
                        {
                            isgGeaterThan = true;
                            Console.WriteLine(isgGeaterThan);
                        }
                        else
                        {
                            isgGeaterThan = false;
                            Console.WriteLine(isgGeaterThan);
                        }
                    }



                    else if (input.Contains("=="))
                    {
                        newFraction = input.Split(new string[] { "/", "==" }, StringSplitOptions.RemoveEmptyEntries);

                        int number1 = int.Parse(newFraction[0]);
                        int number2 = int.Parse(newFraction[1]);

                        Fraction drop1 = new Fraction(number1, number2);


                        int number3 = int.Parse(newFraction[2]);
                        int number4 = int.Parse(newFraction[3]);

                        Fraction drop2 = new Fraction(number3, number4);


                        if (drop1 == drop2)
                        {
                            isgGeaterThan = true;
                            Console.WriteLine(isgGeaterThan);
                        }
                        else
                        {
                            isgGeaterThan = false;
                            Console.WriteLine(isgGeaterThan);
                        }
                    }



                    else if (input.Contains("!="))
                    {
                        newFraction = input.Split(new string[] { "/", "!=" }, StringSplitOptions.RemoveEmptyEntries);

                        int number1 = int.Parse(newFraction[0]);
                        int number2 = int.Parse(newFraction[1]);

                        Fraction drop1 = new Fraction(number1, number2);


                        int number3 = int.Parse(newFraction[2]);
                        int number4 = int.Parse(newFraction[3]);

                        Fraction drop2 = new Fraction(number3, number4);


                        if (drop1 != drop2)
                        {
                            isgGeaterThan = true;
                            Console.WriteLine(isgGeaterThan);
                        }
                        else
                        {
                            isgGeaterThan = false;
                            Console.WriteLine(isgGeaterThan);
                        }
                    }



                    else if (input.Contains(" / "))
                    {
                        newFraction = input.Split('/', '/');

                        int num1 = int.Parse(newFraction[0]);
                        int num2 = int.Parse(newFraction[1]);

                        Fraction fraction1 = new Fraction(num1, num2);


                        int num3 = int.Parse(newFraction[2]);
                        int num4 = int.Parse(newFraction[3]);

                        Fraction fraction2 = new Fraction(num3, num4);

                        Console.WriteLine($"Your answer is: {fraction1 / fraction2}");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid expression. Try again.");
                }
            }



            //If the input is "integer" or "int" we call the 'Int_Calculator' class, where some things are going to happen

            if (typeOfCalculation == "integer" || typeOfCalculation == "int")
            {
                Console.WriteLine();
                IntegerCal calculator = new IntegerCal();
                calculator.Run();
            }



            //Check if valid operator is selected
            else
            {
                while (typeOfCalculation != "integer" && typeOfCalculation != "fraction")
                {
                    Console.WriteLine("Choose a valid operator input!");
                    type = Console.ReadLine();
                }
            }



            Console.WriteLine("\r\n" + "Type 'continue' if you want to restart the aplication and 'exit' or 'end' to end it.");
            restartCheck = Console.ReadLine();


            //If the input isn't equal to "continue" or "exit" than the program says that you should choose a valid input

            while (restartCheck != "continue" || restartCheck != "exit" || restartCheck != "end")
            {
                //Check if the user wants to reatart the app

                if (restartCheck == "continue")
                {
                    Console.WriteLine("\r\n" + "~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~" + "\r\n");
                    RunCalculator();
                }

                else if (restartCheck == "exit" || restartCheck == "end")
                {
                    Console.WriteLine("\r\n" + "Bye bye! :)");
                    return;
                }

                else
                {
                    Console.WriteLine("Choose a valid input");
                    restartCheck = Console.ReadLine();
                }
            }
        }
    }
}