using Grapecity.Internship.Assignments.CalculatorLibrary;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System;

namespace Grapecity.Internship.Assignments.CalculatorWinForm.Controls
{

    public class CreateCommand
    {
        public static Dictionary<string, Type> Command_dict = new Dictionary<string, Type>();

        ResourceManager rm = new ResourceManager("WindowsFormsApp.ButtonEventResource", Assembly.GetExecutingAssembly());

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
                Command_dict.Add("Sq.Rt.", Type.GetType(rm.GetString("Sq. Rt.")));
                Command_dict.Add("Log x", Type.GetType(rm.GetString("Log x")));
                Command_dict.Add("Ln x", Type.GetType(rm.GetString("Ln x")));
                Command_dict.Add("1/x", Type.GetType(rm.GetString("1/x")));
                Command_dict.Add("!", Type.GetType(rm.GetString("!")));
                Command_dict.Add("+/-", Type.GetType(rm.GetString("+/-")));
                Command_dict.Add("Sin", Type.GetType(rm.GetString("Sin")));
                Command_dict.Add("Cos", Type.GetType(rm.GetString("Cos")));
                Command_dict.Add("Tan", Type.GetType(rm.GetString("Tan")));
            }
            catch (Exception e)
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

    public class LogCalculation : IUnaryCommand
    {
        private readonly double value;

        public LogCalculation(double a)
        {
            value = a;
        }

        public double Calculate()
        {
            return ScientificOperations.Log10(value);
        }
    }

    public class LnCalculation : IUnaryCommand
    {
        private readonly double value;

        public LnCalculation(double a)
        {
            value = a;
        }

        public double Calculate()
        {
            return ScientificOperations.Ln(value);
        }
    }

    public class InverseCalulation : IUnaryCommand
    {
        private readonly double value;

        public InverseCalulation(double a)
        {
            value = a;
        }

        public double Calculate()
        {
            return ScientificOperations.Inverse(value);
        }
    }

    public class FactorialCaluclation : IUnaryCommand
    {
        private readonly double value;

        public FactorialCaluclation(double a)
        {
            value = a;
        }

        public double Calculate()
        {
            return Convert.ToDouble(ScientificOperations.Factorial(Convert.ToInt32(value)));
        }
    }

    #endregion
}