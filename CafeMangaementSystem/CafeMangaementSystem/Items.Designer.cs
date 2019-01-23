namespace CafeMangaementSystem
{
    partial class Items
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
            this.lblitemname = new System.Windows.Forms.Label();
            this.lblrate = new System.Windows.Forms.Label();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.Itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btncancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.BackColor = System.Drawing.Color.YellowGreen;
            this.lblitemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblitemname.Location = new System.Drawing.Point(24, 76);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(75, 16);
            this.lblitemname.TabIndex = 0;
            this.lblitemname.Text = "Itemname";
            // 
            // lblrate
            // 
            this.lblrate.AutoSize = true;
            this.lblrate.BackColor = System.Drawing.Color.YellowGreen;
            this.lblrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblrate.Location = new System.Drawing.Point(33, 119);
            this.lblrate.Name = "lblrate";
            this.lblrate.Size = new System.Drawing.Size(41, 16);
            this.lblrate.TabIndex = 1;
            this.lblrate.Text = "Rate";
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(131, 75);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(199, 20);
            this.txtitemname.TabIndex = 2;
            // 
            // txtrate
            // 
            this.txtrate.Location = new System.Drawing.Point(131, 119);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(199, 20);
            this.txtrate.TabIndex = 3;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.YellowGreen;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnsave.Location = new System.Drawing.Point(245, 167);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(101, 30);
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
            this.Itemid,
            this.Column2,
            this.Rate,
            this.Edit,
            this.Delete});
            this.dgData.GridColor = System.Drawing.Color.YellowGreen;
            this.dgData.Location = new System.Drawing.Point(12, 216);
            this.dgData.Name = "dgData";
            this.dgData.Size = new System.Drawing.Size(539, 162);
            this.dgData.TabIndex = 5;
            this.dgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellContentClick);
            this.dgData.Click += new System.EventHandler(this.dgData_Click);
            // 
            // Itemid
            // 
            this.Itemid.DataPropertyName = "Itemid";
            this.Itemid.HeaderText = "Itemid";
            this.Itemid.Name = "Itemid";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Itemname";
            this.Column2.HeaderText = "Itemname";
            this.Column2.Name = "Column2";
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Itemrate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.YellowGreen;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btncancel.Location = new System.Drawing.Point(399, 168);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 29);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Location = new System.Drawing.Point(222, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 38);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "ITEMS";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BackgroundImage = global::CafeMangaementSystem.Properties.Resources.items;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 390);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.txtitemname);
            this.Controls.Add(this.lblrate);
            this.Controls.Add(this.lblitemname);
            this.Name = "Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.Label lblrate;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.TextBox textBox1;
    }
}

