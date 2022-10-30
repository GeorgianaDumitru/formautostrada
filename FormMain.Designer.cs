namespace Proiect
{
    partial class FormMain
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
            this.autostraziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inLucruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autostraziToolStripMenuItem,
            this.inLucruToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // autostraziToolStripMenuItem
            // 
            this.autostraziToolStripMenuItem.Name = "autostraziToolStripMenuItem";
            this.autostraziToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.autostraziToolStripMenuItem.Text = "Autostrada";
            this.autostraziToolStripMenuItem.Click += new System.EventHandler(this.autostraziToolStripMenuItem_Click);
            // 
            // inLucruToolStripMenuItem
            // 
            this.inLucruToolStripMenuItem.Name = "inLucruToolStripMenuItem";
            this.inLucruToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.inLucruToolStripMenuItem.Text = "In lucru";
            this.inLucruToolStripMenuItem.Click += new System.EventHandler(this.inLucruToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem autostraziToolStripMenuItem;
        private ToolStripMenuItem inLucruToolStripMenuItem;
    }
}