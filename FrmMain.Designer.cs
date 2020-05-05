namespace Chuong4_part1
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chàoMừngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhTổngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngDãySốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chàoMừngToolStripMenuItem,
            this.tínhTổngToolStripMenuItem,
            this.tổngDãySốToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chàoMừngToolStripMenuItem
            // 
            this.chàoMừngToolStripMenuItem.Name = "chàoMừngToolStripMenuItem";
            this.chàoMừngToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.chàoMừngToolStripMenuItem.Text = "Chào Mừng";
            this.chàoMừngToolStripMenuItem.Click += new System.EventHandler(this.chàoMừngToolStripMenuItem_Click);
            // 
            // tínhTổngToolStripMenuItem
            // 
            this.tínhTổngToolStripMenuItem.Name = "tínhTổngToolStripMenuItem";
            this.tínhTổngToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.tínhTổngToolStripMenuItem.Text = "Tính tổng";
            this.tínhTổngToolStripMenuItem.Click += new System.EventHandler(this.tínhTổngToolStripMenuItem_Click);
            // 
            // tổngDãySốToolStripMenuItem
            // 
            this.tổngDãySốToolStripMenuItem.Name = "tổngDãySốToolStripMenuItem";
            this.tổngDãySốToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.tổngDãySốToolStripMenuItem.Text = "Tổng Dãy số";
            this.tổngDãySốToolStripMenuItem.Click += new System.EventHandler(this.tổngDãySốToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(112, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 171);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chàoMừngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhTổngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tổngDãySốToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}