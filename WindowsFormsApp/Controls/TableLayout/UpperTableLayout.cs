using System.Drawing;
using System.Windows.Forms;

namespace Grapecity.Internship.Assignments.CalculatorWinForm.Controls
{
    public class UpperTableLayout : TableLayoutPanel
    {

        #region Public Method Members
        public CalculatorTextBox OutputTextBox { get; private set; }
        public CalculatorMenuStrip MenuStrip { get; private set; }
        #endregion

        #region Constructor

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="name"></param>
        public UpperTableLayout(string name)
        {
            
            InitializeTableLayout(name);

            AddChildren();
        }

        #endregion

        #region Private Method Members

        /// <summary>
        /// Initialization and setup method
        /// </summary>
        /// <param name="name"></param>
        private void InitializeTableLayout(string name)
        {
            Name = name;

            Dock = DockStyle.Fill;
            
            Size = new Size(334, 80);
            Location = new Point(0, 0);

            ColumnCount = 1;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            RowCount = 2;
            RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            TabIndex = 0;

            SuspendLayout();
            ResumeLayout(false);
        }

        /// <summary>
        /// Adding the children of TableLayout
        /// </summary>
        private void AddChildren()
        {
            MenuStrip = new CalculatorMenuStrip("MenuStrip");
            OutputTextBox = new CalculatorTextBox("TextBox");

            Controls.Add(MenuStrip, 0, 0);
            Controls.Add(OutputTextBox, 0, 1);
        }

        #endregion
    }
}
