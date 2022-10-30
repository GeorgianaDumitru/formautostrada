namespace Autostrazi
{
    partial class FormAddAutostrada
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitlte = new System.Windows.Forms.TextBox();
            this.txtroute = new System.Windows.Forms.TextBox();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmdAdd_Click = new System.Windows.Forms.Button();
            this.cmdRemove_Click = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUploaderId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ruta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marimea";
            // 
            // txtTitlte
            // 
            this.txtTitlte.Location = new System.Drawing.Point(94, 52);
            this.txtTitlte.Name = "txtTitlte";
            this.txtTitlte.Size = new System.Drawing.Size(200, 23);
            this.txtTitlte.TabIndex = 4;
            // 
            // txtroute
            // 
            this.txtroute.Location = new System.Drawing.Point(94, 153);
            this.txtroute.Name = "txtroute";
            this.txtroute.Size = new System.Drawing.Size(200, 23);
            this.txtroute.TabIndex = 5;
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(94, 197);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(200, 23);
            this.txtsize.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(94, 105);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 23);
            this.dtpDate.TabIndex = 7;
           
            // 
            // cmdAdd_Click
            // 
            this.cmdAdd_Click.Location = new System.Drawing.Point(94, 286);
            this.cmdAdd_Click.Name = "cmdAdd_Click";
            this.cmdAdd_Click.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd_Click.TabIndex = 8;
            this.cmdAdd_Click.Text = "Adauga";
            this.cmdAdd_Click.UseVisualStyleBackColor = true;
            this.cmdAdd_Click.Click += new System.EventHandler(this.cmdAdd_Click_Click);
            // 
            // cmdRemove_Click
            // 
            this.cmdRemove_Click.Location = new System.Drawing.Point(219, 286);
            this.cmdRemove_Click.Name = "cmdRemove_Click";
            this.cmdRemove_Click.Size = new System.Drawing.Size(75, 23);
            this.cmdRemove_Click.TabIndex = 9;
            this.cmdRemove_Click.Text = "Renunta";
            this.cmdRemove_Click.UseVisualStyleBackColor = true;
            this.cmdRemove_Click.Click += new System.EventHandler(this.cmdRemove_Click_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID";
            // 
            // txtUploaderId
            // 
            this.txtUploaderId.Location = new System.Drawing.Point(94, 239);
            this.txtUploaderId.Name = "txtUploaderId";
            this.txtUploaderId.Size = new System.Drawing.Size(96, 23);
            this.txtUploaderId.TabIndex = 11;
            this.txtUploaderId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUploaderId_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUploaderId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdRemove_Click);
            this.Controls.Add(this.cmdAdd_Click);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.txtroute);
            this.Controls.Add(this.txtTitlte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTitlte;
        private TextBox txtroute;
        private TextBox txtsize;
        private DateTimePicker dtpDate;
        private Button cmdAdd_Click;
        private Button cmdRemove_Click;
        private Label label5;
        private TextBox txtUploaderId;
    }
}