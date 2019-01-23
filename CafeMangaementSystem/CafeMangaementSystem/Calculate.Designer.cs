namespace CafeMangaementSystem
{
    partial class Calculate
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
            this.lblfirst = new System.Windows.Forms.Label();
            this.lblsecond = new System.Windows.Forms.Label();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.txtsecond = new System.Windows.Forms.TextBox();
            this.Rdoadd = new System.Windows.Forms.RadioButton();
            this.Rdosub = new System.Windows.Forms.RadioButton();
            this.Rdomul = new System.Windows.Forms.RadioButton();
            this.Rdodiv = new System.Windows.Forms.RadioButton();
            this.btncalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfirst
            // 
            this.lblfirst.AutoSize = true;
            this.lblfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirst.Location = new System.Drawing.Point(12, 28);
            this.lblfirst.Name = "lblfirst";
            this.lblfirst.Size = new System.Drawing.Size(96, 16);
            this.lblfirst.TabIndex = 0;
            this.lblfirst.Text = "First Number";
            // 
            // lblsecond
            // 
            this.lblsecond.AutoSize = true;
            this.lblsecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblsecond.Location = new System.Drawing.Point(12, 66);
            this.lblsecond.Name = "lblsecond";
            this.lblsecond.Size = new System.Drawing.Size(119, 16);
            this.lblsecond.TabIndex = 1;
            this.lblsecond.Text = "Second Number";
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(137, 24);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(129, 20);
            this.txtfirst.TabIndex = 2;
            this.txtfirst.TextChanged += new System.EventHandler(this.txtfirst_TextChanged);
            // 
            // txtsecond
            // 
            this.txtsecond.Location = new System.Drawing.Point(137, 62);
            this.txtsecond.Name = "txtsecond";
            this.txtsecond.Size = new System.Drawing.Size(126, 20);
            this.txtsecond.TabIndex = 3;
            // 
            // Rdoadd
            // 
            this.Rdoadd.AutoSize = true;
            this.Rdoadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Rdoadd.Location = new System.Drawing.Point(26, 136);
            this.Rdoadd.Name = "Rdoadd";
            this.Rdoadd.Size = new System.Drawing.Size(58, 20);
            this.Rdoadd.TabIndex = 4;
            this.Rdoadd.TabStop = true;
            this.Rdoadd.Text = "ADD";
            this.Rdoadd.UseVisualStyleBackColor = true;
            // 
            // Rdosub
            // 
            this.Rdosub.AutoSize = true;
            this.Rdosub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Rdosub.Location = new System.Drawing.Point(158, 136);
            this.Rdosub.Name = "Rdosub";
            this.Rdosub.Size = new System.Drawing.Size(57, 20);
            this.Rdosub.TabIndex = 5;
            this.Rdosub.TabStop = true;
            this.Rdosub.Text = "SUB";
            this.Rdosub.UseVisualStyleBackColor = true;
            // 
            // Rdomul
            // 
            this.Rdomul.AutoSize = true;
            this.Rdomul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Rdomul.Location = new System.Drawing.Point(27, 175);
            this.Rdomul.Name = "Rdomul";
            this.Rdomul.Size = new System.Drawing.Size(57, 20);
            this.Rdomul.TabIndex = 6;
            this.Rdomul.TabStop = true;
            this.Rdomul.Text = "MUL";
            this.Rdomul.UseVisualStyleBackColor = true;
            this.Rdomul.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Rdodiv
            // 
            this.Rdodiv.AutoSize = true;
            this.Rdodiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Rdodiv.Location = new System.Drawing.Point(159, 175);
            this.Rdodiv.Name = "Rdodiv";
            this.Rdodiv.Size = new System.Drawing.Size(51, 20);
            this.Rdodiv.TabIndex = 7;
            this.Rdodiv.TabStop = true;
            this.Rdodiv.Text = "DIV";
            this.Rdodiv.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btncalculate.Location = new System.Drawing.Point(71, 236);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(98, 36);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(270, 298);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.Rdodiv);
            this.Controls.Add(this.Rdomul);
            this.Controls.Add(this.Rdosub);
            this.Controls.Add(this.Rdoadd);
            this.Controls.Add(this.txtsecond);
            this.Controls.Add(this.txtfirst);
            this.Controls.Add(this.lblsecond);
            this.Controls.Add(this.lblfirst);
            this.Name = "Calculate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfirst;
        private System.Windows.Forms.Label lblsecond;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.TextBox txtsecond;
        private System.Windows.Forms.RadioButton Rdoadd;
        private System.Windows.Forms.RadioButton Rdosub;
        private System.Windows.Forms.RadioButton Rdomul;
        private System.Windows.Forms.RadioButton Rdodiv;
        private System.Windows.Forms.Button btncalculate;
    }
}