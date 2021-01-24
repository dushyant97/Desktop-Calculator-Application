using System.Windows.Forms;
using Grapecity.Internship.Assignments.CalculatorLibrary;

namespace Grapecity.Internship.Assignments.CalculatorWinForm
{
    public partial class Form1 : Form
    {
        double value = 0;
        string clipboard = "";
        string operation = "";
        bool operator_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }
        private void ButtonCE_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void NumberClick(object sender, System.EventArgs e)
        {
            if(textBox1.Text == "0" || operator_pressed)
            {
                textBox1.Clear();
            }
            operator_pressed = false;

            Button btn = (Button)sender;
            if(btn.Text == ".")
            {
                if(!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + btn.Text;
            }
        }

        private void UnaryOperator_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
            {
                Button btn = (Button)sender;
                switch (btn.Text)
                {
                    case "Sq. Rt.":
                        textBox1.Text = (ArithmaticOperations.SquareRoot(double.Parse(textBox1.Text))).ToString();
                        break;

                    case "Log x":
                        textBox1.Text = (ScientificOperations.Log10(double.Parse(textBox1.Text))).ToString();
                        break;

                    case "Ln x":
                        textBox1.Text = (ScientificOperations.Ln(double.Parse(textBox1.Text))).ToString();
                        break;

                    case "1/x":
                        textBox1.Text = (ScientificOperations.Inverse(double.Parse(textBox1.Text))).ToString();
                        break;

                    case "!":
                        textBox1.Text = (ScientificOperations.Factorial(int.Parse(textBox1.Text))).ToString();
                        break;

                    case "+/-":
                        textBox1.Text = (ArithmaticOperations.PlusMinus(double.Parse(textBox1.Text))).ToString();
                        break;

                    case "Sin":
                        textBox1.Text = (ScientificOperations.Sin(double.Parse(textBox1.Text))).ToString();
                        break;

                    case "Cos":
                        textBox1.Text = (ScientificOperations.Cos(double.Parse(textBox1.Text))).ToString();
                        break;

                    case "Tan":
                        textBox1.Text = (ScientificOperations.Tan(double.Parse(textBox1.Text))).ToString();
                        break;

                    case "<-":
                        if (textBox1.Text.Length > 0)
                        {
                            int len = textBox1.Text.Length;
                            textBox1.Text = textBox1.Text.Substring(0, len - 1);
                        }
                        if (textBox1.Text == "")
                        {
                            textBox1.Text = "0";
                        }
                        break;
                }
            }
        }

        private void BinaryOperator(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            if(textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if(value != 0)
            {
                //Performing Equal Button Click
                button4.PerformClick(); 
            }
            else
            {
                value = double.Parse(textBox1.Text);
            }
            operation = btn.Text;
            operator_pressed = true;
        }

        private void EqualsOperation(object sender, System.EventArgs e)
        {
            if(operation == "+")
            {
                textBox1.Text = (ArithmaticOperations.Add(value, double.Parse(textBox1.Text))).ToString();
            }
            else if(operation == "-")
            {
                textBox1.Text = (ArithmaticOperations.Subtract(value, double.Parse(textBox1.Text))).ToString();
            }
            else if(operation == "*")
            {
                textBox1.Text = (ArithmaticOperations.Multiply(value, double.Parse(textBox1.Text))).ToString();
            }
            else if(operation == "/")
            {
                textBox1.Text = (ArithmaticOperations.Divide(value, double.Parse(textBox1.Text))).ToString();
            }
            operator_pressed = false;
            value = double.Parse(textBox1.Text);
            operation = "";
        }

        private void Menu_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem obj = (ToolStripMenuItem)sender;
            if (obj.Text == "Copy")
            {
                clipboard = textBox1.Text;
            }
            else if (obj.Text == "Paste")
            {
                if (clipboard != "")
                {
                    textBox1.Text = clipboard;
                    clipboard = "";
                }
            }
            else if (obj.Text == "Exit")
            {
                Application.Exit();
            }
        }
    }
}
