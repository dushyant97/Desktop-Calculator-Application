using System.Windows.Forms;
using System.Drawing;

namespace Grapecity.Internship.Assignments.CalculatorWinForm.Controls
{
    public class CalculatorMenuStrip : MenuStrip
    {
        #region Private Field Members

        private ToolStripMenuItem editMenu;

        #endregion

        #region Public Method Members

        public ToolStripMenuItem HelpMenu { get; private set; }
        public ToolStripMenuItem Exitmenu { get; private set; }
        public ToolStripMenuItem CopyItem { get; private set; }
        public ToolStripMenuItem PasteItem { get; private set; }

        #endregion

        #region Constructor
        
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="name"></param>
        public CalculatorMenuStrip(string name)
        {
            BeginInIt();

            InitializeMenuStrip(name);

            SuspendLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Private Method Members

        /// <summary>
        /// Initialization and setup method
        /// </summary>
        /// <param name="name"></param>
        private void InitializeMenuStrip(string name)
        {
            Name = name;

            Location = new Point(0, 0);
            Size = new Size(334, 20);
            
            TabIndex = 0;

            Items.AddRange(new ToolStripItem[] {
                editMenu,HelpMenu,Exitmenu
            });


            // editToolStripMenuItem

            editMenu.Name = "editToolStripMenuItem";
            editMenu.Text = "Edit";
            editMenu.Size = new Size(39, 16);

            editMenu.DropDownItems.AddRange(new ToolStripItem[] {
            CopyItem,PasteItem
            });
            
            // copyToolStripMenuItem

            CopyItem.Name = "copyToolStripMenuItem";
            CopyItem.Text = "Copy";
            CopyItem.Size = new Size(102, 22);

            // pasteToolStripMenuItem

            PasteItem.Name = "pasteToolStripMenuItem";
            PasteItem.Text = "Paste";
            PasteItem.Size = new Size(102, 22);


            // helpToolStripMenuItem

            HelpMenu.Name = "helpToolStripMenuItem";
            HelpMenu.Text = "Help";
            HelpMenu.Size = new Size(44, 16);

            // exitToolStripMenuItem

            Exitmenu.Name = "exitToolStripMenuItem";
            Exitmenu.Text = "Exit";
            Exitmenu.Size = new Size(38, 16);
        }

        /// <summary>
        /// Begin the base initialization
        /// </summary>
        private void BeginInIt()
        {
            editMenu = new ToolStripMenuItem();
            HelpMenu = new ToolStripMenuItem();
            Exitmenu = new ToolStripMenuItem();
            CopyItem = new ToolStripMenuItem();
            PasteItem = new ToolStripMenuItem();

        }

        #endregion
    }
}
