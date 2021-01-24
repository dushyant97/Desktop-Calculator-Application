using System.Windows.Forms;
using System.Drawing;

namespace Grapecity.Internship.Assignments.CalculatorWinForm.Controls
{
    public class CalculatorForm : Form
    {
        #region Private Field Members

        private CalculatorSplitContainer _splitContainer;

        #endregion

        #region Constructor

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public CalculatorForm()
        {
            InitializeForm("CalculatorForm", "Calculator");

            AddChildren();
        }

        #endregion

        #region Private Method Members

        /// <summary>
        /// Initialization and setup method
        /// </summary>
        /// <param name="name"></param>
        /// <param name="text"></param>
        private void InitializeForm(string name, string text)
        {
            Name = name;
            Text = text;

            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            StartPosition = FormStartPosition.CenterScreen;

            ClientSize = new Size(334, 411);
            MaximumSize = new Size(544, 700);
            MinimumSize = new Size(350, 450);
            MaximizeBox = false;

            ShowIcon = false;

            SuspendLayout();
            ResumeLayout(false);

        }

        /// <summary>
        /// Adding the children of WinForm
        /// </summary>
        private void AddChildren()
        {
            _splitContainer = new CalculatorSplitContainer("CalculatorSplitContainer");

            Controls.Add(_splitContainer);
        }

        #endregion
    }
}
