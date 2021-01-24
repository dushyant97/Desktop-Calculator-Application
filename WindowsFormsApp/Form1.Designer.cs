namespace Grapecity.Internship.Assignments.CalculatorWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button7 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(3, 187);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(77, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumberClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(334, 411);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(334, 80);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 20);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 16);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 16);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 16);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 40);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.button43, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button46, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.button45, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.button44, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button42, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button41, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button40, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button39, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button38, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button37, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button36, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button35, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button34, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button33, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button32, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button31, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button30, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button29, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button28, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button27, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button26, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button25, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button24, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(252, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 45);
            this.button4.TabIndex = 35;
            this.button4.Text = "=";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.EqualsOperation);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(86, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 45);
            this.button3.TabIndex = 34;
            this.button3.Text = "0";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumberClick);
            // 
            // button43
            // 
            this.button43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button43.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button43.Location = new System.Drawing.Point(3, 233);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(77, 40);
            this.button43.TabIndex = 31;
            this.button43.Text = "1";
            this.toolTip1.SetToolTip(this.button43, "This button has a numeric Value of 1");
            this.button43.UseVisualStyleBackColor = true;
            this.button43.Click += new System.EventHandler(this.NumberClick);
            // 
            // button46
            // 
            this.button46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button46.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button46.Location = new System.Drawing.Point(252, 233);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(79, 40);
            this.button46.TabIndex = 29;
            this.button46.Text = "+";
            this.button46.UseVisualStyleBackColor = true;
            this.button46.Click += new System.EventHandler(this.BinaryOperator);
            // 
            // button45
            // 
            this.button45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button45.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button45.Location = new System.Drawing.Point(169, 233);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(77, 40);
            this.button45.TabIndex = 28;
            this.button45.Text = "3";
            this.button45.UseVisualStyleBackColor = true;
            this.button45.Click += new System.EventHandler(this.NumberClick);
            // 
            // button44
            // 
            this.button44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button44.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button44.Location = new System.Drawing.Point(86, 233);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(77, 40);
            this.button44.TabIndex = 27;
            this.button44.Text = "2";
            this.toolTip1.SetToolTip(this.button44, "This button has a numeric value of 2");
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.NumberClick);
            // 
            // button42
            // 
            this.button42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button42.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button42.Location = new System.Drawing.Point(252, 187);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(79, 40);
            this.button42.TabIndex = 25;
            this.button42.Text = "-";
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.BinaryOperator);
            // 
            // button41
            // 
            this.button41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button41.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button41.Location = new System.Drawing.Point(169, 187);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(77, 40);
            this.button41.TabIndex = 24;
            this.button41.Text = "6";
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.NumberClick);
            // 
            // button40
            // 
            this.button40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button40.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button40.Location = new System.Drawing.Point(86, 187);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(77, 40);
            this.button40.TabIndex = 23;
            this.button40.Text = "5";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.NumberClick);
            // 
            // button39
            // 
            this.button39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button39.Location = new System.Drawing.Point(252, 141);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(79, 40);
            this.button39.TabIndex = 22;
            this.button39.Text = "*";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.BinaryOperator);
            // 
            // button38
            // 
            this.button38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button38.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button38.Location = new System.Drawing.Point(169, 141);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(77, 40);
            this.button38.TabIndex = 21;
            this.button38.Text = "9";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.NumberClick);
            // 
            // button37
            // 
            this.button37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button37.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button37.Location = new System.Drawing.Point(86, 141);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(77, 40);
            this.button37.TabIndex = 20;
            this.button37.Text = "8";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.NumberClick);
            // 
            // button36
            // 
            this.button36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.Location = new System.Drawing.Point(3, 141);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(77, 40);
            this.button36.TabIndex = 19;
            this.button36.Text = "7";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.NumberClick);
            // 
            // button35
            // 
            this.button35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.Location = new System.Drawing.Point(252, 95);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(79, 40);
            this.button35.TabIndex = 18;
            this.button35.Text = "/";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.BinaryOperator);
            // 
            // button34
            // 
            this.button34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.Location = new System.Drawing.Point(169, 95);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(77, 40);
            this.button34.TabIndex = 17;
            this.button34.Text = "Ln x";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.UnaryOperator_Click);
            // 
            // button33
            // 
            this.button33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.Location = new System.Drawing.Point(86, 95);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(77, 40);
            this.button33.TabIndex = 16;
            this.button33.Text = "Log x";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.UnaryOperator_Click);
            // 
            // button32
            // 
            this.button32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.Location = new System.Drawing.Point(3, 95);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(77, 40);
            this.button32.TabIndex = 15;
            this.button32.Text = "Sq. Rt.";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.UnaryOperator_Click);
            // 
            // button31
            // 
            this.button31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.Location = new System.Drawing.Point(252, 49);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(79, 40);
            this.button31.TabIndex = 14;
            this.button31.Text = "1/x";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.UnaryOperator_Click);
            // 
            // button30
            // 
            this.button30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.Location = new System.Drawing.Point(169, 49);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(77, 40);
            this.button30.TabIndex = 13;
            this.button30.Text = "Tan";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.UnaryOperator_Click);
            // 
            // button29
            // 
            this.button29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.Location = new System.Drawing.Point(86, 49);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(77, 40);
            this.button29.TabIndex = 12;
            this.button29.Text = "Cos";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.UnaryOperator_Click);
            // 
            // button28
            // 
            this.button28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.Location = new System.Drawing.Point(3, 49);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(77, 40);
            this.button28.TabIndex = 11;
            this.button28.Text = "Sin";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.UnaryOperator_Click);
            // 
            // button27
            // 
            this.button27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(252, 3);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(79, 40);
            this.button27.TabIndex = 10;
            this.button27.Text = "!";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.UnaryOperator_Click);
            // 
            // button26
            // 
            this.button26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(169, 3);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(77, 40);
            this.button26.TabIndex = 9;
            this.button26.Text = "<-";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.UnaryOperator_Click);
            // 
            // button25
            // 
            this.button25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(86, 3);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(77, 40);
            this.button25.TabIndex = 8;
            this.button25.Text = "C";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // button24
            // 
            this.button24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(3, 3);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(77, 40);
            this.button24.TabIndex = 7;
            this.button24.Text = "CE";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.ButtonCE_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 45);
            this.button1.TabIndex = 32;
            this.button1.Text = "+/-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UnaryOperator_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(169, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 45);
            this.button2.TabIndex = 33;
            this.button2.Text = ".";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumberClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(544, 700);
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

