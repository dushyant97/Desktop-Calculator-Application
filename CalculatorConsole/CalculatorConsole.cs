using CalculatorLibrary;
using System;

namespace CalculatorConsole
{
    public class CalculatorConsole
    {
        public static void Main(string[] args)
        {
            new CalculatorConsole()
                .Start();            
        }

        /// <summary>
        /// Starter method
        /// </summary>
        public void Start()
        {
            bool flag = false;

            do
            {
                string output = "";
                int operation = Menu();

                //Conditional statement for handling type of operation
                if (operation >= 1 && operation <= 4)
                {
                    output = BinaryOperation(operation);
                }
                else if (operation >= 5 && operation <= 11)
                {
                    output = UnaryOperation(operation);
                }

                //Conditional statement for handling output and exit menu
                if (output != "")
                {
                    Console.Clear();
                    Console.WriteLine("The result is " + output);
                    Console.WriteLine("Try Again ? Press 1 for Yes or any other number for No");
                    flag = (Console.ReadLine() == "1");
                }
            } while (flag);
        }

        #region Private Methods

        /// <summary>
        /// Method for displaying menu options and returns the selected operation
        /// </summary>
        /// <returns></returns>
        private int Menu()
        {
            int selection;

            Console.Clear();
            Console.WriteLine("Enter the operation to be performed");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. NOT");
            Console.WriteLine("6. SquareRoot");
            Console.WriteLine("7. Increment");
            Console.WriteLine("8. Decrement");
            Console.WriteLine("9. Sine");
            Console.WriteLine("10. Cos");
            Console.WriteLine("11. Tan");
            Console.WriteLine("12. Exit");

            try
            {
                selection = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Raised: " + e.Message);
                Console.ReadKey();
                selection = 0;
            }
            return selection;
        }

        /// <summary>
        /// Method for handling binary operations
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns> 
        private string BinaryOperation(int choice)
        {
            double result, first_num, second_num;
            Console.Clear();

            try
            {
                Console.WriteLine("Enter the first number");
                first_num = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number");
                second_num = Convert.ToDouble(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid Format provided: Format Exception Raised");
                result = Double.NaN;
                return result.ToString();
            }

            //Conditional switch statement for binary operations
            switch (choice)
            {
                case 1:
                    {
                        result = Operations.Add(first_num, second_num);
                        break;
                    }
                case 2:
                    {
                        result = Operations.Subtract(first_num, second_num);
                        break;
                    }
                case 3:
                    {
                        result = Operations.Multiply(first_num, second_num);
                        break;
                    }
                case 4:
                    {
                        result = Operations.Divide(first_num, second_num);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong input please try again");
                        result = Double.NaN;
                        break;
                    }
            }
            return result.ToString();
        }

        /// <summary>
        /// Method for handling Unary Operations
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        private string UnaryOperation(int choice)
        {
            double result, num;

            Console.Clear();
            try
            {
                Console.WriteLine("Enter the first number");
                num = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Format provided: Format Exception Raised");
                result = Double.NaN;
                return result.ToString();
            }

            //Conditional switch statement for unary operations
            switch (choice)
            {
                case 5:
                    {
                        result = Operations.PlusMinus(num);
                        break;
                    }
                case 6:
                    {
                        result = Operations.SquareRoot(num);
                        break;
                    }
                case 7:
                    {
                        result = Operations.Increment(num);
                        break;
                    }
                case 8:
                    {
                        result = Operations.Decrement(num);
                        break;
                    }
                case 9:
                    {
                        result = Operations.Sin(num);
                        break;
                    }
                case 10:
                    {
                        result = Operations.Cos(num);
                        break;
                    }
                case 11: 
                    {
                        result = Operations.Tan(num);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong input please try again");
                        result = Double.NaN;
                        break;
                    }
            }
            return result.ToString();
        }

        #endregion
    }
}
