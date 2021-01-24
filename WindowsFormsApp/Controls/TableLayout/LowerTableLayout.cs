using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Grapecity.Internship.Assignments.CalculatorWinForm.Controls
{
    public class LowerTableLayout : TableLayoutPanel
    {
        #region Public Members

        public Dictionary<string, CalculatorButton> btnDictionary = new Dictionary<string, CalculatorButton>();

        #endregion

        #region Constructor

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="name"></param>
        public LowerTableLayout(string name)
        {
            InitializeLowerTableLayout(name);

            AddChildren();

            InitializeButton();
        }

        #endregion

        #region Private Method Members

        /// <summary>
        /// Initialization and setup method
        /// </summary>
        /// <param name="name"></param>
        private void InitializeLowerTableLayout(string name)
        {
            Name = name;
            
            Dock = DockStyle.Fill;

            Location = new Point(0, 0);
            Size = new Size(334, 327);
            Margin = new Padding(6);

            ColumnCount = 4;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                      
            RowCount = 7;
            RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            
            TabIndex = 0;

            SuspendLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        /// <summary>
        /// Adding the children of TableLayout
        /// </summary>
        private void AddChildren()
        {
            btnDictionary.Add("zeroNumber", new CalculatorButton("0", "Zero"));
            btnDictionary.Add("oneNumber", new CalculatorButton("1", "One"));
            btnDictionary.Add("twoNumber", new CalculatorButton("2", "Two"));
            btnDictionary.Add("threeNumber", new CalculatorButton("3", "Three"));
            btnDictionary.Add("fourNumber", new CalculatorButton("4", "Four"));
            btnDictionary.Add("fiveNuber", new CalculatorButton("5", "Five"));
            btnDictionary.Add("sixNumber", new CalculatorButton("6", "Six"));
            btnDictionary.Add("sevenNumber", new CalculatorButton("7", "Seven"));
            btnDictionary.Add("eightNumber", new CalculatorButton("8", "Eight"));
            btnDictionary.Add("nineNumber", new CalculatorButton("9", "Nine"));
            btnDictionary.Add("decimalButton", new CalculatorButton(".", "Decimal"));
            btnDictionary.Add("equalsButton", new CalculatorButton("=", "Equal"));
            btnDictionary.Add("inverseSign", new CalculatorButton("+/-", "Plus/Minus"));
            btnDictionary.Add("plusButton", new CalculatorButton("+", "Plus"));
            btnDictionary.Add("minusButton", new CalculatorButton("-", "Minus"));
            btnDictionary.Add("multiplyButton", new CalculatorButton("*", "Multiply"));
            btnDictionary.Add("divideButton", new CalculatorButton("/", "Divide"));
            btnDictionary.Add("squareRoot", new CalculatorButton("Sq.Rt.", "SquareRoot"));
            btnDictionary.Add("log10", new CalculatorButton("Log x", "Log10"));
            btnDictionary.Add("lnOperation", new CalculatorButton("Ln x", "Ln"));
            btnDictionary.Add("inverseOperation", new CalculatorButton("1/x", "Inverse"));
            btnDictionary.Add("sinButton", new CalculatorButton("Sin", "Sine"));
            btnDictionary.Add("cosButton", new CalculatorButton("Cos", "Cos"));
            btnDictionary.Add("tanButton", new CalculatorButton("Tan", "Tan"));
            btnDictionary.Add("factorialOperation", new CalculatorButton("!", "Factorial"));
            btnDictionary.Add("backspaceButton", new CalculatorButton("<-", "Backspace"));
            btnDictionary.Add("clearEntry", new CalculatorButton("CE", "ClearEntry"));
            btnDictionary.Add("clearButton", new CalculatorButton("C", "Clear"));
            

            Controls.Add(btnDictionary["zeroNumber"], 1, 6);
            Controls.Add(btnDictionary["oneNumber"], 0, 5);
            Controls.Add(btnDictionary["twoNumber"], 1, 5);
            Controls.Add(btnDictionary["threeNumber"], 2, 5);
            Controls.Add(btnDictionary["fourNumber"], 0, 4);
            Controls.Add(btnDictionary["fiveNuber"], 1, 4);
            Controls.Add(btnDictionary["sixNumber"], 2, 4);
            Controls.Add(btnDictionary["sevenNumber"], 0, 3);
            Controls.Add(btnDictionary["eightNumber"], 1, 3);
            Controls.Add(btnDictionary["nineNumber"], 2, 3);
            Controls.Add(btnDictionary["decimalButton"], 2, 6);
            Controls.Add(btnDictionary["equalsButton"], 3, 6);
            Controls.Add(btnDictionary["inverseSign"], 0, 6);
            Controls.Add(btnDictionary["plusButton"], 3, 5);
            Controls.Add(btnDictionary["minusButton"], 3, 4);
            Controls.Add(btnDictionary["multiplyButton"], 3, 3);
            Controls.Add(btnDictionary["divideButton"], 3, 2);
            Controls.Add(btnDictionary["squareRoot"], 0, 2);
            Controls.Add(btnDictionary["log10"], 1, 2);
            Controls.Add(btnDictionary["lnOperation"], 2, 2);
            Controls.Add(btnDictionary["inverseOperation"], 3 ,1);
            Controls.Add(btnDictionary["sinButton"], 0, 1);
            Controls.Add(btnDictionary["cosButton"], 1, 1);
            Controls.Add(btnDictionary["tanButton"], 2, 1);
            Controls.Add(btnDictionary["factorialOperation"], 3, 0);
            Controls.Add(btnDictionary["backspaceButton"], 2, 0);
            Controls.Add(btnDictionary["clearEntry"], 0, 0);
            Controls.Add(btnDictionary["clearButton"], 1, 0);
        }

        /// <summary>
        /// Initializes the Buttons
        /// </summary>
        private void InitializeButton()
        {
            btnDictionary["zeroNumber"].TabIndex = 34;
            btnDictionary["zeroNumber"].Location = new Point(86, 279);

            btnDictionary["oneNumber"].TabIndex = 31;
            btnDictionary["oneNumber"].Location = new Point(3, 233);

            btnDictionary["twoNumber"].TabIndex = 27;
            btnDictionary["twoNumber"].Location = new Point(86, 233);

            btnDictionary["threeNumber"].TabIndex = 28;
            btnDictionary["threeNumber"].Location = new Point(169, 233);

            btnDictionary["fourNumber"].TabIndex = 6;
            btnDictionary["fourNumber"].Location = new Point(3, 187);

            btnDictionary["fiveNuber"].TabIndex = 23;
            btnDictionary["fiveNuber"].Location = new Point(86, 187);

            btnDictionary["sixNumber"].TabIndex = 24;
            btnDictionary["sixNumber"].Location = new Point(169, 187);

            btnDictionary["sevenNumber"].TabIndex = 19;
            btnDictionary["sevenNumber"].Location = new Point(3, 141);

            btnDictionary["eightNumber"].TabIndex = 20;
            btnDictionary["eightNumber"].Location = new Point(86, 141);

            btnDictionary["nineNumber"].TabIndex = 21;
            btnDictionary["nineNumber"].Location = new Point(169, 141);

            btnDictionary["decimalButton"].TabIndex = 33;
            btnDictionary["decimalButton"].Location = new Point(169, 279);

            btnDictionary["equalsButton"].TabIndex = 35;
            btnDictionary["equalsButton"].Location = new Point(252, 279);

            btnDictionary["inverseSign"].TabIndex = 32;
            btnDictionary["inverseSign"].Location = new Point(3, 279);

            btnDictionary["plusButton"].TabIndex = 29;
            btnDictionary["plusButton"].Location = new Point(252, 233);

            btnDictionary["minusButton"].TabIndex = 25;
            btnDictionary["minusButton"].Location = new Point(252, 187);

            btnDictionary["multiplyButton"].TabIndex = 22;
            btnDictionary["multiplyButton"].Location = new Point(252, 141);

            btnDictionary["divideButton"].TabIndex = 18;
            btnDictionary["divideButton"].Location = new Point(252, 95);

            btnDictionary["squareRoot"].TabIndex = 15;
            btnDictionary["squareRoot"].Location = new Point(3, 95);

            btnDictionary["log10"].TabIndex = 16;
            btnDictionary["log10"].Location = new Point(86, 95);

            btnDictionary["lnOperation"].TabIndex = 17;
            btnDictionary["lnOperation"].Location = new Point(169, 95);

            btnDictionary["inverseOperation"].TabIndex = 14;
            btnDictionary["inverseOperation"].Location = new Point(252, 49);

            btnDictionary["sinButton"].TabIndex = 11;
            btnDictionary["sinButton"].Location = new Point(3, 49);

            btnDictionary["cosButton"].TabIndex = 12;
            btnDictionary["cosButton"].Location = new Point(86, 49);

            btnDictionary["tanButton"].TabIndex = 13;
            btnDictionary["tanButton"].Location = new Point(169, 49);

            btnDictionary["factorialOperation"].TabIndex = 10;
            btnDictionary["factorialOperation"].Location = new Point(252, 3);

            btnDictionary["backspaceButton"].TabIndex = 9;
            btnDictionary["backspaceButton"].Location = new Point(169, 3);

            btnDictionary["clearEntry"].TabIndex = 7;
            btnDictionary["clearEntry"].Location = new Point(3, 3);

            btnDictionary["clearButton"].TabIndex= 8;
            btnDictionary["clearButton"].Location = new Point(86, 3); 
    }

        #endregion
    }
}
