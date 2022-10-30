namespace Autostrazi
{
    partial class FormAutostrada
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdAdd_Click = new System.Windows.Forms.Button();
            this.cmdRemove_Click = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista autostrazi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalii";
            // 
            // cmdAdd_Click
            // 
            this.cmdAdd_Click.Location = new System.Drawing.Point(184, 371);
            this.cmdAdd_Click.Name = "cmdAdd_Click";
            this.cmdAdd_Click.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd_Click.TabIndex = 2;
            this.cmdAdd_Click.Text = "Adauga";
            this.cmdAdd_Click.UseVisualStyleBackColor = true;
            this.cmdAdd_Click.Click += new System.EventHandler(this.cmdAdd_Click_Click);
            // 
            // cmdRemove_Click
            // 
            this.cmdRemove_Click.Location = new System.Drawing.Point(318, 371);
            this.cmdRemove_Click.Name = "cmdRemove_Click";
            this.cmdRemove_Click.Size = new System.Drawing.Size(75, 23);
            this.cmdRemove_Click.TabIndex = 3;
            this.cmdRemove_Click.Text = "Sterge";
            this.cmdRemove_Click.UseVisualStyleBackColor = true;
            this.cmdRemove_Click.Click += new System.EventHandler(this.cmdRemove_Click_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(129, 304);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 256);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmdRemove_Click);
            this.Controls.Add(this.cmdAdd_Click);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button cmdAdd_Click;
        private Button cmdRemove_Click;
        private ListBox listBox1;
        private TextBox textBox1;
    }
}