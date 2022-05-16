namespace XLA
{
    partial class ContrastScroll
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
            this.Scroll = new System.Windows.Forms.TrackBar();
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Scroll)).BeginInit();
            this.SuspendLayout();
            // 
            // Scroll
            // 
            this.Scroll.AutoSize = false;
            this.Scroll.Location = new System.Drawing.Point(40, 26);
            this.Scroll.Maximum = 255;
            this.Scroll.Name = "Scroll";
            this.Scroll.Size = new System.Drawing.Size(451, 56);
            this.Scroll.TabIndex = 0;
            this.Scroll.Value = 1;
            this.Scroll.Scroll += new System.EventHandler(this.Scroll_Scroll);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(441, 98);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(50, 20);
            this.L1.TabIndex = 1;
            this.L1.Text = "label1";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Location = new System.Drawing.Point(237, 98);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(50, 20);
            this.L2.TabIndex = 2;
            this.L2.Text = "label2";
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Location = new System.Drawing.Point(31, 98);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(50, 20);
            this.L3.TabIndex = 3;
            this.L3.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContrastScroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(627, 135);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.Scroll);
            this.Name = "ContrastScroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ContrastScroll";
            this.Load += new System.EventHandler(this.ContrastScroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Scroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar Scroll;
        private Label L1;
        private Label L2;
        private Label L3;
        private Button button1;
    }
}