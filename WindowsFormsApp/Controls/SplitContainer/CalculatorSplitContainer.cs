using Grapecity.Internship.Assignments.CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Grapecity.Internship.Assignments.CalculatorWinForm.Controls
{
    public class CalculatorSplitContainer : SplitContainer
    {
        #region Private Field Members

        // Private Fields for performing calculation
        private double value = 0;
        private string operation = "";
        private bool operator_pressed = false;
        private string clipboard = "";

        private UpperTableLayout _uppertablelayout;
        private LowerTableLayout _lowertablelayout;

        #endregion

        #region Constructor

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="name"></param>
        public CalculatorSplitContainer(string name)
        {
            InitializeSplitContainer(name);

            BeginInit();

            AddChildren();

            EndInit();
        }

        #endregion

        #region Private Method Members

        /// <summary>
        /// Initialization and setup method
        /// </summary>
        /// <param name="name"></param>
        private void InitializeSplitContainer(string name)
        {
            Name = name;

            Dock = DockStyle.Fill;
            FixedPanel = FixedPanel.Panel1;

            IsSplitterFixed = true;

            Location = new System.Drawing.Point(0, 0);
            Margin = new Padding(6);

            Orientation = Orientation.Horizontal;

            Size = new System.Drawing.Size(334, 411);
            SplitterDistance = 80;
            TabIndex = 24;

            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            SuspendLayout();

            Panel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            ResumeLayout(false);
        }
        
        /// <summary>
        /// This method adds controls to the split container
        /// </summary>
        private void AddChildren()
        {
            _uppertablelayout = new UpperTableLayout("UpperTableLayout");
            _lowertablelayout = new LowerTableLayout("LowerTableLayout");

            Panel1.Controls.Add(_uppertablelayout);
            Panel2.Controls.Add(_lowertablelayout);

            AddMenuHandler();
            AddButtonHandler();
        }

        /// <summary>
        /// This method is used to add Event Handler for all the buttons in the calculator
        /// </summary>
        private void AddButtonHandler()
        {
            // Adding Event Handler for Button
            foreach (var itr in _lowertablelayout.btnDictionary)
            {
                if (In(itr.Key, "zeroNumber", "oneNumber", "twoNumber", "threeNumber", "fourNumber", "fiveNuber", "sixNumber", "sevenNumber"
                    , "eightNumber", "nineNumber", "decimalButton"))
                {
                    itr.Value.Click += new EventHandler(NumberClick);
                }
                else if (In(itr.Key, "inverseSign", "squareRoot", "log10", "lnOperation", "inverseOperation", "sinButton", "cosButton", "tanButton"
                        , "factorialOperation", "backspaceButton", "clearButton", "clearEntry"))
                {
                    itr.Value.Click += new EventHandler(UnaryOperator_Click);
                }
                else if (In(itr.Key, "plusButton", "minusButton", "multiplyButton", "divideButton"))
                {
                    itr.Value.Click += new EventHandler(BinaryOperator_CLick);
                }
                else if (itr.Key == "equalsButton")
                {
                    itr.Value.Click += new EventHandler(EqualsOperation);
                }
            }
        }

        /// <summary>
        /// This method is used add Event Handler for all MenuStrip in the calculator
        /// </summary>
        private void AddMenuHandler()
        {
            _uppertablelayout.MenuStrip.CopyItem.Click += new EventHandler(MenuOperation);
            _uppertablelayout.MenuStrip.PasteItem.Click += new EventHandler(MenuOperation);
            _uppertablelayout.MenuStrip.HelpMenu.Click += new EventHandler(MenuOperation);
            _uppertablelayout.MenuStrip.Exitmenu.Click += new EventHandler(MenuOperation);
        }

        /// <summary>
        /// This method is used to make comparison with a series of string and returns true if it matches the source string
        /// </summary>
        /// <param name="source"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        private bool In(string source, params string[] list)
        {
            if (null == source) throw new ArgumentNullException("source");
            return list.Contains(source);
        }

        #endregion

        #region Event Handlers
        private void NumberClick(object sender, EventArgs e)
        {
            if (_uppertablelayout.OutputTextBox.Text == "0" || operator_pressed)
            {
                _uppertablelayout.OutputTextBox.Clear();
            }
            operator_pressed = false;

            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if (!_uppertablelayout.OutputTextBox.Text.Contains("."))
                {
                    _uppertablelayout.OutputTextBox.Text = _uppertablelayout.OutputTextBox.Text + btn.Text;
                }
            }
            else
            {
                _uppertablelayout.OutputTextBox.Text = _uppertablelayout.OutputTextBox.Text + btn.Text;
            }
        }
        private void BinaryOperator_CLick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;           
            if (_uppertablelayout.OutputTextBox.Text == "")
            {
                _uppertablelayout.OutputTextBox.Text = "0";
            }

            if (value != 0)
            {
                //Performing Equal Button Click
                _lowertablelayout.btnDictionary["equalsButton"].PerformClick();
            }
            else
            {
                value = double.Parse(_uppertablelayout.OutputTextBox.Text);
                _uppertablelayout.OutputTextBox.Text = _uppertablelayout.OutputTextBox.Text + btn.Text;
            }
            operation = btn.Text;
            operator_pressed = true;
        }
        private void UnaryOperator_Click(object sender, EventArgs e)
        {
            if (_uppertablelayout.OutputTextBox.Text == "")
            {
                _uppertablelayout.OutputTextBox.Text = "0";
            }
            else
            {
                Button btn = (Button)sender;
                if (!In(btn.Text, "CE", "C", "<-"))
                {
                    CreateCommand x = new CreateCommand();
                    try
                    {
                        double output;
                        new CreateCommand();
                        var objType = CreateCommand.Command_dict[btn.Text];
                        var obj = Activator.CreateInstance(objType, double.Parse(_uppertablelayout.OutputTextBox.Text)) as IUnaryCommand;
                        output = obj.Calculate();
                        _uppertablelayout.OutputTextBox.Text = output.ToString();
                    }
                    catch (KeyNotFoundException) { }
                }
                else
                {
                    switch (btn.Text)
                    {
                        case "<-":
                            if (_uppertablelayout.OutputTextBox.Text.Length > 0)
                            {
                                int len = _uppertablelayout.OutputTextBox.Text.Length;
                                _uppertablelayout.OutputTextBox.Text = _uppertablelayout.OutputTextBox.Text.Substring(0, len - 1);
                            }
                            if (_uppertablelayout.OutputTextBox.Text == "")
                            {
                                _uppertablelayout.OutputTextBox.Text = "0";
                            }
                            break;

                        case "CE":
                            _uppertablelayout.OutputTextBox.Text = "0";
                            break;
                        case "C":
                            _uppertablelayout.OutputTextBox.Text = "0";
                            value = 0;
                            break;
                    }

                }
            }
        }
        private void EqualsOperation(object sender, EventArgs e)
        {
            if (operation == "+")
            {
                _uppertablelayout.OutputTextBox.Text = (ArithmaticOperations.Add(value, double.Parse(_uppertablelayout.OutputTextBox.Text))).ToString();
            }
            else if (operation == "-")
            {
                _uppertablelayout.OutputTextBox.Text = (ArithmaticOperations.Subtract(value, double.Parse(_uppertablelayout.OutputTextBox.Text))).ToString();
            }
            else if (operation == "*")
            {
                _uppertablelayout.OutputTextBox.Text = (ArithmaticOperations.Multiply(value, double.Parse(_uppertablelayout.OutputTextBox.Text))).ToString();
            }
            else if (operation == "/")
            {
                _uppertablelayout.OutputTextBox.Text = (ArithmaticOperations.Divide(value, double.Parse(_uppertablelayout.OutputTextBox.Text))).ToString();
            }
            operator_pressed = false;
            value = double.Parse(_uppertablelayout.OutputTextBox.Text);
            operation = "";
        }
        private void MenuOperation(object sender, EventArgs e)
        {
            ToolStripMenuItem obj = (ToolStripMenuItem)sender;
            if (obj.Text == "Copy")
            {
                clipboard = _uppertablelayout.OutputTextBox.Text;
            }
            else if (obj.Text == "Paste")
            {
                if (clipboard != "")
                {
                    _uppertablelayout.OutputTextBox.Text = clipboard;
                    clipboard = "";
                }
            }
            else if (obj.Text == "Exit")
            {
                Application.Exit();
            }
        }

        #endregion
    }
}
