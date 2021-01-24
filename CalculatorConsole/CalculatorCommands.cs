using Grapecity.Internship.Assignments.CalculatorLibrary;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System;

namespace Grapecity.Internship.Assignments.CalculatorConsole
{
    
    public class CreateCommand
    {
        public static Dictionary<int, Type> Command_dict = new Dictionary<int, Type>();

        ResourceManager rm = new ResourceManager("CalculatorConsole.CreateCommand", Assembly.GetExecutingAssembly());

        #region Constructor

        /// <summary>
        /// This method created a HashMap of various classes implementing the Interface for Binary Operation
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public CreateCommand()
        {
            Command_dict.Clear();
                  
            // Exception Handling for Adding keys to the dictionary
            try
            {
                Command_dict.Add(1, Type.GetType(rm.GetString("1")));
                Command_dict.Add(2, Type.GetType(rm.GetString("2")));
                Command_dict.Add(3, Type.GetType(rm.GetString("3")));
                Command_dict.Add(4, Type.GetType(rm.GetString("4")));
                Command_dict.Add(5, Type.GetType(rm.GetString("5")));
                Command_dict.Add(6, Type.GetType(rm.GetString("6")));
                Command_dict.Add(7, Type.GetType(rm.GetString("7")));
                Command_dict.Add(8, Type.GetType(rm.GetString("8")));
                Command_dict.Add(9, Type.GetType(rm.GetString("9")));
                Command_dict.Add(10, Type.GetType(rm.GetString("10")));
                Command_dict.Add(11, Type.GetType(rm.GetString("11")));

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            
        }

        #endregion
    }

    #region Interfaces

    /// <summary>
    /// Interface for Binary Command
    /// </summary>
    public interface IBinaryCommand
    {
        double Calculate();
    }

    /// <summary>
    /// Interface for Unary Command
    /// </summary>
    public interface IUnaryCommand
    {
        double Calculate();
    }
    #endregion

    #region Binary Operation Classes
    public class AddCalculation : IBinaryCommand
    {
        private readonly double _num1, _num2;

        public AddCalculation(double a, double b)
        {
            _num1 = a;
            _num2 = b;
        }

        public double Calculate()
        {
            return ArithmaticOperations.Add(_num1, _num2);
        }
    }

    public class SubtractCalculation : IBinaryCommand
    {
        private readonly double _num1, _num2;

        public SubtractCalculation(double a, double b)
        {
            _num1 = a;
            _num2 = b;
        }

        public double Calculate()
        {
            return ArithmaticOperations.Subtract(_num1, _num2);
        }
    }

    public class MultiplicationCalculation : IBinaryCommand
    {
        private readonly double _num1, _num2;

        public MultiplicationCalculation(double a, double b)
        {
            _num1 = a;
            _num2 = b;
        }

        public double Calculate()
        {
            return ArithmaticOperations.Multiply(_num1, _num2);
        }
    }

    public class DivisonCalculation : IBinaryCommand
    {
        private readonly double _num1, _num2;

        public DivisonCalculation(double a, double b)
        {
            _num1 = a;
            _num2 = b;
        }

        public double Calculate()
        {
            return ArithmaticOperations.Divide(_num1, _num2);
        }
    }
    #endregion

    #region Unary Operation Classes

    public class PlusMinus : IUnaryCommand
    {
        private readonly double _num;

        public PlusMinus(double a)
        {
            _num = a;
        }

        public double Calculate()
        {
            return ArithmaticOperations.PlusMinus(_num);
        }
    }

    public class SquareRootCalculation : IUnaryCommand
    {
        private readonly double _num;

        public SquareRootCalculation(double a)
        {
            _num = a;
        }

        public double Calculate()
        {
            return ArithmaticOperations.SquareRoot(_num);
        }
    }

    public class IncrementCalculation : IUnaryCommand
    {
        private readonly double _num;

        public IncrementCalculation(double a)
        {
            _num = a;
        }

        public double Calculate()
        {
            return ScientificOperations.Increment(_num);
        }
    }

    public class DecrementCalculation : IUnaryCommand
    {
        private readonly double _num;

        public DecrementCalculation(double a)
        {
            _num = a;
        }

        public double Calculate()
        {
            return ScientificOperations.Decrement(_num);
        }
    }

    public class SineCalculation : IUnaryCommand
    {
        private readonly double _degree;

        public SineCalculation(double a)
        {
            _degree = a;
        }

        public double Calculate()
        {
            return ScientificOperations.Sin(_degree);
        }
    }

    public class CosineCalculation : IUnaryCommand
    {
        private readonly double _degree;

        public CosineCalculation(double a)
        {
            _degree = a;
        }

        public double Calculate()
        {
            return ScientificOperations.Cos(_degree);
        }
    }

    public class TangentCalculation : IUnaryCommand
    {
        private readonly double _degree;

        public TangentCalculation(double a)
        {
            _degree = a;
        }

        public double Calculate()
        {
            return ScientificOperations.Tan(_degree);
        }
    }
    #endregion
}