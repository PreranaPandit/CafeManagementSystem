namespace CafeMangaementSystem
{
    partial class Customer
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
            this.lblcfname = new System.Windows.Forms.Label();
            this.lblclname = new System.Windows.Forms.Label();
            this.lblcaddress = new System.Windows.Forms.Label();
            this.txtcfname = new System.Windows.Forms.TextBox();
            this.txtclname = new System.Windows.Forms.TextBox();
            this.txtcaddress = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.Dgdata = new System.Windows.Forms.DataGridView();
            this.Ccode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblcustomertypeid = new System.Windows.Forms.Label();
            this.cmbcustomertypeid = new System.Windows.Forms.ComboBox();
            this.lblcgender = new System.Windows.Forms.Label();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.btncancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgdata)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcfname
            // 
            this.lblcfname.AutoSize = true;
            this.lblcfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblcfname.Location = new System.Drawing.Point(17, 16);
            this.lblcfname.Name = "lblcfname";
            this.lblcfname.Size = new System.Drawing.Size(60, 16);
            this.lblcfname.TabIndex = 0;
            this.lblcfname.Text = "Cfname";
            // 
            // lblclname
            // 
            this.lblclname.AutoSize = true;
            this.lblclname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblclname.Location = new System.Drawing.Point(17, 43);
            this.lblclname.Name = "lblclname";
            this.lblclname.Size = new System.Drawing.Size(60, 16);
            this.lblclname.TabIndex = 1;
            this.lblclname.Text = "Clname";
            // 
            // lblcaddress
            // 
            this.lblcaddress.AutoSize = true;
            this.lblcaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblcaddress.Location = new System.Drawing.Point(18, 72);
            this.lblcaddress.Name = "lblcaddress";
            this.lblcaddress.Size = new System.Drawing.Size(75, 16);
            this.lblcaddress.TabIndex = 2;
            this.lblcaddress.Text = "Caddress";
            // 
            // txtcfname
            // 
            this.txtcfname.Location = new System.Drawing.Point(149, 15);
            this.txtcfname.Name = "txtcfname";
            this.txtcfname.Size = new System.Drawing.Size(264, 20);
            this.txtcfname.TabIndex = 3;
            // 
            // txtclname
            // 
            this.txtclname.Location = new System.Drawing.Point(149, 46);
            this.txtclname.Name = "txtclname";
            this.txtclname.Size = new System.Drawing.Size(264, 20);
            this.txtclname.TabIndex = 4;
            // 
            // txtcaddress
            // 
            this.txtcaddress.Location = new System.Drawing.Point(149, 72);
            this.txtcaddress.Name = "txtcaddress";
            this.txtcaddress.Size = new System.Drawing.Size(264, 20);
            this.txtcaddress.TabIndex = 5;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.YellowGreen;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnsave.Location = new System.Drawing.Point(553, 261);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(99, 32);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Dgdata
            // 
            this.Dgdata.AllowUserToOrderColumns = true;
            this.Dgdata.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.Dgdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ccode,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7,
            this.Column8});
            this.Dgdata.Location = new System.Drawing.Point(3, 299);
            this.Dgdata.Name = "Dgdata";
            this.Dgdata.Size = new System.Drawing.Size(839, 156);
            this.Dgdata.TabIndex = 7;
            this.Dgdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgdata_CellContentClick);
            this.Dgdata.Click += new System.EventHandler(this.Dgdata_Click);
            // 
            // Ccode
            // 
            this.Ccode.DataPropertyName = "Ccode";
            this.Ccode.HeaderText = "Ccode";
            this.Ccode.Name = "Ccode";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Cfname";
            this.Column2.HeaderText = "Cfname";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Clname";
            this.Column3.HeaderText = "Clname";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Caddress";
            this.Column4.HeaderText = "Caddress";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Cgender";
            this.Column6.HeaderText = "Cgender";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Username";
            this.Column5.HeaderText = "Username";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Edit";
            this.Column7.Name = "Column7";
            this.Column7.Text = "Edit";
            this.Column7.ToolTipText = "Edit";
            this.Column7.UseColumnTextForLinkValue = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Delete";
            this.Column8.Name = "Column8";
            this.Column8.Text = "Delete";
            this.Column8.ToolTipText = "Delete";
            this.Column8.UseColumnTextForLinkValue = true;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblusername.Location = new System.Drawing.Point(18, 149);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(79, 16);
            this.lblusername.TabIndex = 8;
            this.lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblpassword.Location = new System.Drawing.Point(18, 182);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(76, 16);
            this.lblpassword.TabIndex = 9;
            this.lblpassword.Text = "Password";
            this.lblpassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(149, 149);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(264, 20);
            this.txtusername.TabIndex = 10;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(149, 182);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(264, 20);
            this.txtpassword.TabIndex = 11;
            // 
            // lblcustomertypeid
            // 
            this.lblcustomertypeid.AutoSize = true;
            this.lblcustomertypeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblcustomertypeid.Location = new System.Drawing.Point(17, 222);
            this.lblcustomertypeid.Name = "lblcustomertypeid";
            this.lblcustomertypeid.Size = new System.Drawing.Size(116, 16);
            this.lblcustomertypeid.TabIndex = 12;
            this.lblcustomertypeid.Text = "Customertypeid";
            // 
            // cmbcustomertypeid
            // 
            this.cmbcustomertypeid.FormattingEnabled = true;
            this.cmbcustomertypeid.Location = new System.Drawing.Point(149, 222);
            this.cmbcustomertypeid.Name = "cmbcustomertypeid";
            this.cmbcustomertypeid.Size = new System.Drawing.Size(264, 21);
            this.cmbcustomertypeid.TabIndex = 13;
            this.cmbcustomertypeid.SelectedIndexChanged += new System.EventHandler(this.cmbcustomertypeid_SelectedIndexChanged);
            // 
            // lblcgender
            // 
            this.lblcgender.AutoSize = true;
            this.lblcgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblcgender.Location = new System.Drawing.Point(18, 113);
            this.lblcgender.Name = "lblcgender";
            this.lblcgender.Size = new System.Drawing.Size(67, 16);
            this.lblcgender.TabIndex = 14;
            this.lblcgender.Text = "Cgender";
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rdomale.Location = new System.Drawing.Point(149, 113);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(60, 20);
            this.rdomale.TabIndex = 15;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rdofemale.Location = new System.Drawing.Point(252, 111);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(78, 20);
            this.rdofemale.TabIndex = 16;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.YellowGreen;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btncancel.Location = new System.Drawing.Point(686, 262);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(91, 31);
            this.btncancel.TabIndex = 17;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.BackgroundImage = global::CafeMangaementSystem.Properties.Resources.Customer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(842, 454);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.rdofemale);
            this.Controls.Add(this.rdomale);
            this.Controls.Add(this.lblcgender);
            this.Controls.Add(this.cmbcustomertypeid);
            this.Controls.Add(this.lblcustomertypeid);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.Dgdata);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtcaddress);
            this.Controls.Add(this.txtclname);
            this.Controls.Add(this.txtcfname);
            this.Controls.Add(this.lblcaddress);
            this.Controls.Add(this.lblclname);
            this.Controls.Add(this.lblcfname);
            this.DoubleBuffered = true;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcfname;
        private System.Windows.Forms.Label lblclname;
        private System.Windows.Forms.Label lblcaddress;
        private System.Windows.Forms.TextBox txtcfname;
        private System.Windows.Forms.TextBox txtclname;
        private System.Windows.Forms.TextBox txtcaddress;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView Dgdata;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblcustomertypeid;
        private System.Windows.Forms.ComboBox cmbcustomertypeid;
        private System.Windows.Forms.Label lblcgender;
        private System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.RadioButton rdofemale;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewLinkColumn Column7;
        private System.Windows.Forms.DataGridViewLinkColumn Column8;
    }
}