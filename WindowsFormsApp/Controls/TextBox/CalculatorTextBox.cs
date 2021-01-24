using System.Drawing;
using System.Windows.Forms;

namespace Grapecity.Internship.Assignments.CalculatorWinForm.Controls
{
    public class CalculatorTextBox : TextBox
    {
        #region Constructor

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="name"></param>
        public CalculatorTextBox(string name)
        {
            InitializeTextBox(name);
        }
        #endregion

        #region Private Method Members

        /// <summary>
        /// Initialization and setup method
        /// </summary>
        /// <param name="name"></param>
        public void InitializeTextBox(string name)
        {
            Name = name;
            Text = "0";
            TextAlign = HorizontalAlignment.Right;
            Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);

            Dock = DockStyle.Fill;
                       
            Location = new Point(3, 30);
            Size = new Size(328, 40);
            Margin = new Padding(3, 10, 3, 5);

            TabIndex = 1;   
        }

        #endregion
    }
}
