namespace CafeMangaementSystem
{
    partial class CustomerType
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
            this.lblcustomertypename = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtcustomertypename = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcustomertypename
            // 
            this.lblcustomertypename.AutoSize = true;
            this.lblcustomertypename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblcustomertypename.Location = new System.Drawing.Point(3, 94);
            this.lblcustomertypename.Name = "lblcustomertypename";
            this.lblcustomertypename.Size = new System.Drawing.Size(145, 16);
            this.lblcustomertypename.TabIndex = 1;
            this.lblcustomertypename.Text = "Customertype name";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.YellowGreen;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnsave.Location = new System.Drawing.Point(109, 139);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 33);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dgData
            // 
            this.dgData.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgData.Location = new System.Drawing.Point(6, 237);
            this.dgData.Name = "dgData";
            this.dgData.Size = new System.Drawing.Size(293, 92);
            this.dgData.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Customertypeid";
            this.Column1.HeaderText = "Customertypeid";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Customertypename";
            this.Column2.HeaderText = "Customertypename";
            this.Column2.Name = "Column2";
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.YellowGreen;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btncancel.Location = new System.Drawing.Point(216, 139);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 33);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtcustomertypename
            // 
            this.txtcustomertypename.Location = new System.Drawing.Point(168, 94);
            this.txtcustomertypename.Name = "txtcustomertypename";
            this.txtcustomertypename.Size = new System.Drawing.Size(131, 20);
            this.txtcustomertypename.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Location = new System.Drawing.Point(39, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 38);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "CUSTOMER TYPE";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.BackgroundImage = global::CafeMangaementSystem.Properties.Resources.customer_types;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(303, 340);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtcustomertypename);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblcustomertypename);
            this.Name = "CustomerType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerType";
            this.Load += new System.EventHandler(this.CustomerType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcustomertypename;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtcustomertypename;
        private System.Windows.Forms.TextBox textBox1;
    }
}