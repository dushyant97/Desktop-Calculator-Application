using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using System.Resources;


namespace Grapecity.Internship.Assignments.CalculatorWinForm.Controls
{
    public class CalculatorButton : Button
    {
        #region Private Field Members

        private ToolTip buttonToolTip;

        #endregion

        #region Resources

        ResourceManager rm = new ResourceManager("WindowsFormsApp.ButtonResources", Assembly.GetExecutingAssembly());

        #endregion

        #region Constructor

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="text"></param>
        /// <param name="name"></param>
        public CalculatorButton(string text, string name)
        {
            BeginInIt(name);

            InitializeButton(text, name);

            InitializeToolTip();
        }

        #endregion

        #region Private Method Members

        /// <summary>
        /// Initialization and setup method for Buttons
        /// </summary>
        /// <param name="text"></param>
        /// <param name="name"></param>
        private void InitializeButton(string text, string name)
        {
            Name = name;
            Text = text;

            Size = new Size(79, 40);

            Dock = DockStyle.Fill;

            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UseVisualStyleBackColor = true;

        }

        /// <summary>
        /// Initialization and setup method for ToolTip
        /// </summary>
        private void InitializeToolTip()
        {
            buttonToolTip.SetToolTip(this, rm.GetString(Name));
        }

        /// <summary>
        /// Begin the base initialization
        /// </summary>
        private void BeginInIt(string name)
        {
            buttonToolTip = new ToolTip();
        }

        #endregion
    }
}
