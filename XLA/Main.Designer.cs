namespace XLA
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToGrayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToBinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brighnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brighnessScrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastScrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Old = new System.Windows.Forms.PictureBox();
            this.New = new System.Windows.Forms.PictureBox();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Old)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.New)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.convertToolStripMenuItem,
            this.editToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rGBToRedToolStripMenuItem,
            this.rGBToGreenToolStripMenuItem,
            this.rGBToBlueToolStripMenuItem,
            this.rGBToGrayToolStripMenuItem1,
            this.grayToBinToolStripMenuItem1,
            this.invertToolStripMenuItem1});
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.convertToolStripMenuItem.Text = "Convert";
            // 
            // rGBToRedToolStripMenuItem
            // 
            this.rGBToRedToolStripMenuItem.Name = "rGBToRedToolStripMenuItem";
            this.rGBToRedToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rGBToRedToolStripMenuItem.Text = "RGB to Red";
            this.rGBToRedToolStripMenuItem.Click += new System.EventHandler(this.rGBToRedToolStripMenuItem_Click);
            // 
            // rGBToGreenToolStripMenuItem
            // 
            this.rGBToGreenToolStripMenuItem.Name = "rGBToGreenToolStripMenuItem";
            this.rGBToGreenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rGBToGreenToolStripMenuItem.Text = "RGB to Green";
            this.rGBToGreenToolStripMenuItem.Click += new System.EventHandler(this.rGBToGreenToolStripMenuItem_Click);
            // 
            // rGBToBlueToolStripMenuItem
            // 
            this.rGBToBlueToolStripMenuItem.Name = "rGBToBlueToolStripMenuItem";
            this.rGBToBlueToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rGBToBlueToolStripMenuItem.Text = "RGB to Blue";
            this.rGBToBlueToolStripMenuItem.Click += new System.EventHandler(this.rGBToBlueToolStripMenuItem_Click);
            // 
            // rGBToGrayToolStripMenuItem1
            // 
            this.rGBToGrayToolStripMenuItem1.Name = "rGBToGrayToolStripMenuItem1";
            this.rGBToGrayToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.rGBToGrayToolStripMenuItem1.Text = "RGB to Gray";
            this.rGBToGrayToolStripMenuItem1.Click += new System.EventHandler(this.rGBToGrayToolStripMenuItem1_Click);
            // 
            // grayToBinToolStripMenuItem1
            // 
            this.grayToBinToolStripMenuItem1.Name = "grayToBinToolStripMenuItem1";
            this.grayToBinToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.grayToBinToolStripMenuItem1.Text = "Gray to Bin";
            this.grayToBinToolStripMenuItem1.Click += new System.EventHandler(this.grayToBinToolStripMenuItem1_Click);
            // 
            // invertToolStripMenuItem1
            // 
            this.invertToolStripMenuItem1.Name = "invertToolStripMenuItem1";
            this.invertToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.invertToolStripMenuItem1.Text = "Invert";
            this.invertToolStripMenuItem1.Click += new System.EventHandler(this.invertToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adjustmentsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // adjustmentsToolStripMenuItem
            // 
            this.adjustmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brighnessToolStripMenuItem,
            this.contrastToolStripMenuItem,
            this.brighnessScrollToolStripMenuItem,
            this.contrastScrollToolStripMenuItem});
            this.adjustmentsToolStripMenuItem.Name = "adjustmentsToolStripMenuItem";
            this.adjustmentsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adjustmentsToolStripMenuItem.Text = "Adjustments";
            this.adjustmentsToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // brighnessToolStripMenuItem
            // 
            this.brighnessToolStripMenuItem.Name = "brighnessToolStripMenuItem";
            this.brighnessToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.brighnessToolStripMenuItem.Text = "Brighness";
            this.brighnessToolStripMenuItem.Click += new System.EventHandler(this.brighnessToolStripMenuItem_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.contrastToolStripMenuItem.Text = "Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
            // 
            // brighnessScrollToolStripMenuItem
            // 
            this.brighnessScrollToolStripMenuItem.Name = "brighnessScrollToolStripMenuItem";
            this.brighnessScrollToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.brighnessScrollToolStripMenuItem.Text = "BrighnessScroll";
            this.brighnessScrollToolStripMenuItem.Click += new System.EventHandler(this.brighnessScrollToolStripMenuItem_Click);
            // 
            // contrastScrollToolStripMenuItem
            // 
            this.contrastScrollToolStripMenuItem.Name = "contrastScrollToolStripMenuItem";
            this.contrastScrollToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.contrastScrollToolStripMenuItem.Text = "ContrastScroll";
            this.contrastScrollToolStripMenuItem.Click += new System.EventHandler(this.contrastScrollToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.filterToolStripMenuItem.Text = "Filter";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Old, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.New, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 437);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Old
            // 
            this.Old.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Old.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Old.Location = new System.Drawing.Point(3, 3);
            this.Old.Name = "Old";
            this.Old.Size = new System.Drawing.Size(437, 431);
            this.Old.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Old.TabIndex = 0;
            this.Old.TabStop = false;
            this.Old.Click += new System.EventHandler(this.Old_Click);
            // 
            // New
            // 
            this.New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.New.Dock = System.Windows.Forms.DockStyle.Fill;
            this.New.Location = new System.Drawing.Point(446, 3);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(437, 431);
            this.New.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.New.TabIndex = 0;
            this.New.TabStop = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // OpenDialog
            // 
            this.OpenDialog.FileName = "openFileDialog1";
            this.OpenDialog.Filter = "Tất cả các file(*.*)|*.*|(*.png)|*.png|(*.jpg)|*.jpg|(*.bmp)|*.bmp";
            this.OpenDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenDialog_FileOk);
            // 
            // SaveDialog
            // 
            this.SaveDialog.Filter = "Tất cả các file(*.*)|(*.*)|(*.png)|*.png|(*.jpg)|*.jpg|(*.bmp)|*.bmp";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(886, 465);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Processing Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Old)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.New)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem adjustmentsToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox Old;
        private PictureBox New;
        private OpenFileDialog OpenDialog;
        private SaveFileDialog SaveDialog;
        private ToolStripMenuItem brighnessToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem contrastToolStripMenuItem;
        private ToolStripMenuItem brighnessScrollToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem;
        private ToolStripMenuItem contrastScrollToolStripMenuItem;
        private ToolStripMenuItem convertToolStripMenuItem;
        private ToolStripMenuItem rGBToRedToolStripMenuItem;
        private ToolStripMenuItem rGBToGreenToolStripMenuItem;
        private ToolStripMenuItem rGBToBlueToolStripMenuItem;
        private ToolStripMenuItem rGBToGrayToolStripMenuItem1;
        private ToolStripMenuItem grayToBinToolStripMenuItem1;
        private ToolStripMenuItem invertToolStripMenuItem1;
    }
}