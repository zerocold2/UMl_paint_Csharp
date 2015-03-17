namespace Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MouseHover = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.SizeCB = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ColorBT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearBT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillSquareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.drawRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.drawCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.SizeTB = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripStatusPenColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusBgColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 416);
            this.panel1.TabIndex = 0;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MouseHover,
            this.toolStripStatusPenColor,
            this.toolStripStatusBgColor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(700, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MouseHover
            // 
            this.MouseHover.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.MouseHover.Name = "MouseHover";
            this.MouseHover.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.SizeCB,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.ColorBT,
            this.toolStripSeparator2,
            this.ClearBT,
            this.toolStripSeparator4,
            this.toolStripLabel4,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.toolStripDropDownButton1,
            this.toolStripSeparator6,
            this.toolStripLabel5,
            this.SizeTB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(703, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "Pen Size";
            // 
            // SizeCB
            // 
            this.SizeCB.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.SizeCB.Name = "SizeCB";
            this.SizeCB.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "Pen Color";
            // 
            // ColorBT
            // 
            this.ColorBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorBT.Image = ((System.Drawing.Image)(resources.GetObject("ColorBT.Image")));
            this.ColorBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorBT.Name = "ColorBT";
            this.ColorBT.Size = new System.Drawing.Size(23, 22);
            this.ColorBT.Text = "toolStripButton1";
            this.ColorBT.Click += new System.EventHandler(this.ColorBT_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ClearBT
            // 
            this.ClearBT.Image = global::Paint.Properties.Resources._1_edgesu;
            this.ClearBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearBT.Name = "ClearBT";
            this.ClearBT.Size = new System.Drawing.Size(54, 22);
            this.ClearBT.Text = "Clear";
            this.ClearBT.Click += new System.EventHandler(this.ClearBT_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel4.Text = "BackColor : ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Paint.Properties.Resources.icon_ActionMacroNode_Color;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabel3.Text = "Shaps";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.squareToolStripMenuItem,
            this.fillSquareToolStripMenuItem,
            this.toolStripSeparator5,
            this.drawRectangleToolStripMenuItem,
            this.fillRectangleToolStripMenuItem,
            this.toolStripSeparator7,
            this.drawCircleToolStripMenuItem,
            this.fillCircleToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.squareToolStripMenuItem.Image = global::Paint.Properties.Resources.rectangle_32;
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.squareToolStripMenuItem.Text = "Draw Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.squareToolStripMenuItem_Click);
            // 
            // fillSquareToolStripMenuItem
            // 
            this.fillSquareToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.fillSquareToolStripMenuItem.Image = global::Paint.Properties.Resources.Masonry_Unit_Masonry_Glass_Block_Square_Stack_transparency;
            this.fillSquareToolStripMenuItem.Name = "fillSquareToolStripMenuItem";
            this.fillSquareToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.fillSquareToolStripMenuItem.Text = "Fill Square";
            this.fillSquareToolStripMenuItem.Click += new System.EventHandler(this.fillSquareToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStripSeparator5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(153, 6);
            this.toolStripSeparator5.Click += new System.EventHandler(this.toolStripSeparator5_Click);
            // 
            // drawRectangleToolStripMenuItem
            // 
            this.drawRectangleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.drawRectangleToolStripMenuItem.Image = global::Paint.Properties.Resources.rectangle_32;
            this.drawRectangleToolStripMenuItem.Name = "drawRectangleToolStripMenuItem";
            this.drawRectangleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.drawRectangleToolStripMenuItem.Text = "Draw Rectangle";
            this.drawRectangleToolStripMenuItem.Click += new System.EventHandler(this.drawRectangleToolStripMenuItem_Click);
            // 
            // fillRectangleToolStripMenuItem
            // 
            this.fillRectangleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.fillRectangleToolStripMenuItem.Image = global::Paint.Properties.Resources.Masonry_Unit_Masonry_Glass_Block_Square_Stack_transparency;
            this.fillRectangleToolStripMenuItem.Name = "fillRectangleToolStripMenuItem";
            this.fillRectangleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.fillRectangleToolStripMenuItem.Text = "Fill Rectangle";
            this.fillRectangleToolStripMenuItem.Click += new System.EventHandler(this.fillRectangleToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(153, 6);
            // 
            // drawCircleToolStripMenuItem
            // 
            this.drawCircleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.drawCircleToolStripMenuItem.Image = global::Paint.Properties.Resources.dials_circle_line;
            this.drawCircleToolStripMenuItem.Name = "drawCircleToolStripMenuItem";
            this.drawCircleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.drawCircleToolStripMenuItem.Text = "Draw Circle";
            this.drawCircleToolStripMenuItem.Click += new System.EventHandler(this.drawCircleToolStripMenuItem_Click);
            // 
            // fillCircleToolStripMenuItem
            // 
            this.fillCircleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.fillCircleToolStripMenuItem.Image = global::Paint.Properties.Resources.hard_circle;
            this.fillCircleToolStripMenuItem.Name = "fillCircleToolStripMenuItem";
            this.fillCircleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.fillCircleToolStripMenuItem.Text = "Fill Circle";
            this.fillCircleToolStripMenuItem.Click += new System.EventHandler(this.fillCircleToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel5.Text = "Shaps Size :  ";
            // 
            // SizeTB
            // 
            this.SizeTB.Name = "SizeTB";
            this.SizeTB.Size = new System.Drawing.Size(40, 25);
            // 
            // toolStripStatusPenColor
            // 
            this.toolStripStatusPenColor.Name = "toolStripStatusPenColor";
            this.toolStripStatusPenColor.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusBgColor
            // 
            this.toolStripStatusBgColor.Name = "toolStripStatusBgColor";
            this.toolStripStatusBgColor.Size = new System.Drawing.Size(110, 17);
            this.toolStripStatusBgColor.Text = "BackGround Color  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 444);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint by .::ZC::.";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox SizeCB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton ColorBT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MouseHover;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ClearBT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillSquareToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox SizeTB;
        private System.Windows.Forms.ToolStripMenuItem drawRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem drawCircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillCircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusPenColor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusBgColor;
    }
}

