using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;

namespace Grapecity.Internship.Assignments.CalculatorConsole
{
    public class CalculatorConsole
    {
        #region Resources
        ResourceManager rm = new ResourceManager("CalculatorConsole.CommandLine", Assembly.GetExecutingAssembly());
        #endregion

        
        public static void Main(string[] args)
        {
            new CalculatorConsole()
                .Start();
        }

        #region Private Methods

        /// <summary>
        /// Starter method
        /// </summary>
        private void Start()
        {
            bool flag = false;
            
            do
            {
                string output = "";
                int choice = Menu();

                //Conditional statement for handling type of operation
                if( (choice >= 1) && (choice <= int.Parse(rm.GetString("OperationCount"))) )
                {
                    output = Operation(choice);
                }

                //Conditional statement for handling output and exit menu
                if (output != "")
                {
                    Console.Clear();
                    Console.WriteLine("The result is " + output);
                    Console.WriteLine(rm.GetString("RetryOperation"));
                    flag = (Console.ReadLine() == "1");
                } 
            } while (flag);
        }

        /// <summary>
        /// Method for displaying menu options and returns the selected operation
        /// </summary>
        /// <returns></returns>
        private int Menu()
        {
            int selection;

            Console.Clear();
            Console.WriteLine(rm.GetString("EnterOperations"));
            Console.WriteLine(rm.GetString("MenuOption_1"));
            Console.WriteLine(rm.GetString("MenuOption_2"));
            Console.WriteLine(rm.GetString("MenuOption_3"));
            Console.WriteLine(rm.GetString("MenuOption_4"));
            Console.WriteLine(rm.GetString("MenuOption_5"));
            Console.WriteLine(rm.GetString("MenuOption_6"));
            Console.WriteLine(rm.GetString("MenuOption_7"));
            Console.WriteLine(rm.GetString("MenuOption_8"));
            Console.WriteLine(rm.GetString("MenuOption_9"));
            Console.WriteLine(rm.GetString("MenuOption_10"));
            Console.WriteLine(rm.GetString("MenuOption_11"));
            Console.WriteLine(rm.GetString("MenuOption_12"));

            try
            {
                selection = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                selection = 0;
            }
            return selection;
        }

        /// <summary>
        /// This method handles IO operation according to operation type i.e. Unary or Binary and calls appropriate method and returns output
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        private string Operation(int choice)
        {
            double result;
                                    
            Console.Clear();
            new CreateCommand();

            //Conditional Statement for determining type of operation
            if (rm.GetString(choice.ToString()) == "Binary")
            {
                double first_num, second_num;
                try
                {
                    Console.WriteLine("Enter the first number");
                    first_num = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the second number");
                    second_num = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    result = double.NaN;
                    return result.ToString();
                }

                //Exception Handling for Invalid Key
                try
                {
                    //var interface_name = type.IBinaryCommand;
                    
                    var objType = CreateCommand.Command_dict[choice];
                    var obj = Activator.CreateInstance(objType, first_num, second_num) as IBinaryCommand;
                    result = obj.Calculate();
                }
                catch (KeyNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();

                    result = double.NaN;
                }
                return result.ToString();

            }
            //Conditional Statement for determining type of operation
            else if (rm.GetString(choice.ToString()) == "Unary")
            {
                double num;

                try
                {
                    Console.WriteLine("Enter the first number");
                    num = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    result = double.NaN;
                    return result.ToString();
                }

                //Exception Handling for Invalid Key
                try
                {
                    var objType = CreateCommand.Command_dict[choice];
                    var obj = Activator.CreateInstance(objType, num) as IUnaryCommand;
                    result = obj.Calculate();
                }
                catch (KeyNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();

                    result = double.NaN;
                }

                return result.ToString();
            }

            //if operation is neither unary nor binary, it returns NaN
            return (double.NaN).ToString();
        }
        #endregion
    }
}
