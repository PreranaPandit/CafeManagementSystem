namespace CafeMangaementSystem
{
    partial class GenerateBill
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTtotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgItemDetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCcode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.cmbSelectItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomertypename = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCgender = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCaddress = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblClname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCfname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(314, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Generate Bill";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::CafeMangaementSystem.Properties.Resources.Bill_designstyle_smoothie_m;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.txtDiscount);
            this.groupBox2.Controls.Add(this.btnGenerateBill);
            this.groupBox2.Controls.Add(this.lblNetTotal);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.lblVat);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblTtotal);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.dgItemDetails);
            this.groupBox2.Location = new System.Drawing.Point(351, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 415);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ItemsDetails";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(405, 228);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(119, 20);
            this.txtDiscount.TabIndex = 22;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGenerateBill.Location = new System.Drawing.Point(202, 373);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(123, 34);
            this.btnGenerateBill.TabIndex = 9;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.AutoSize = true;
            this.lblNetTotal.Location = new System.Drawing.Point(425, 318);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(13, 13);
            this.lblNetTotal.TabIndex = 8;
            this.lblNetTotal.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(315, 319);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 16);
            this.label21.TabIndex = 7;
            this.label21.Text = "Net Total";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(425, 282);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(13, 13);
            this.lblVat.TabIndex = 6;
            this.lblVat.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(315, 279);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 16);
            this.label19.TabIndex = 5;
            this.label19.Text = "Vat(13%)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(312, 232);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 16);
            this.label17.TabIndex = 3;
            this.label17.Text = "Discount";
            // 
            // lblTtotal
            // 
            this.lblTtotal.AutoSize = true;
            this.lblTtotal.Location = new System.Drawing.Point(425, 197);
            this.lblTtotal.Name = "lblTtotal";
            this.lblTtotal.Size = new System.Drawing.Size(13, 13);
            this.lblTtotal.TabIndex = 2;
            this.lblTtotal.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(328, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Ttotal";
            // 
            // dgItemDetails
            // 
            this.dgItemDetails.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgItemDetails.Location = new System.Drawing.Point(40, 25);
            this.dgItemDetails.Name = "dgItemDetails";
            this.dgItemDetails.Size = new System.Drawing.Size(458, 133);
            this.dgItemDetails.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ItemName";
            this.Column1.HeaderText = "ItemName";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ItemRate";
            this.Column2.HeaderText = "ItemRate";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Quantity";
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Ltotal";
            this.Column4.HeaderText = "Ltotal";
            this.Column4.Name = "Column4";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.txtCcode);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblRate);
            this.groupBox1.Controls.Add(this.cmbSelectItem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblCustomertypename);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblCgender);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblCaddress);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblClname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblCfname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblBillNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-3, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 419);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CustomerDetails";
            // 
            // txtCcode
            // 
            this.txtCcode.Location = new System.Drawing.Point(103, 59);
            this.txtCcode.Name = "txtCcode";
            this.txtCcode.Size = new System.Drawing.Size(119, 20);
            this.txtCcode.TabIndex = 21;
            this.txtCcode.TextChanged += new System.EventHandler(this.txtCcode_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(218, 377);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 34);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(125, 322);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(116, 20);
            this.txtQuantity.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(25, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quantity";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(122, 289);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(13, 13);
            this.lblRate.TabIndex = 17;
            this.lblRate.Text = "0";
            // 
            // cmbSelectItem
            // 
            this.cmbSelectItem.FormattingEnabled = true;
            this.cmbSelectItem.Location = new System.Drawing.Point(125, 250);
            this.cmbSelectItem.Name = "cmbSelectItem";
            this.cmbSelectItem.Size = new System.Drawing.Size(155, 21);
            this.cmbSelectItem.TabIndex = 16;
            this.cmbSelectItem.SelectedIndexChanged += new System.EventHandler(this.cmbSelectItem_SelectedIndexChanged);
            this.cmbSelectItem.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectItem_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(32, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select an Item";
            // 
            // lblCustomertypename
            // 
            this.lblCustomertypename.AutoSize = true;
            this.lblCustomertypename.Location = new System.Drawing.Point(122, 221);
            this.lblCustomertypename.Name = "lblCustomertypename";
            this.lblCustomertypename.Size = new System.Drawing.Size(23, 13);
            this.lblCustomertypename.TabIndex = 13;
            this.lblCustomertypename.Text = "null";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(13, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Customertype";
            // 
            // lblCgender
            // 
            this.lblCgender.AutoSize = true;
            this.lblCgender.Location = new System.Drawing.Point(122, 189);
            this.lblCgender.Name = "lblCgender";
            this.lblCgender.Size = new System.Drawing.Size(23, 13);
            this.lblCgender.TabIndex = 11;
            this.lblCgender.Text = "null";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(13, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cgender";
            // 
            // lblCaddress
            // 
            this.lblCaddress.AutoSize = true;
            this.lblCaddress.Location = new System.Drawing.Point(122, 160);
            this.lblCaddress.Name = "lblCaddress";
            this.lblCaddress.Size = new System.Drawing.Size(23, 13);
            this.lblCaddress.TabIndex = 9;
            this.lblCaddress.Text = "null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(13, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Caddress";
            // 
            // lblClname
            // 
            this.lblClname.AutoSize = true;
            this.lblClname.Location = new System.Drawing.Point(122, 128);
            this.lblClname.Name = "lblClname";
            this.lblClname.Size = new System.Drawing.Size(23, 13);
            this.lblClname.TabIndex = 7;
            this.lblClname.Text = "null";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(13, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Clname";
            // 
            // lblCfname
            // 
            this.lblCfname.AutoSize = true;
            this.lblCfname.Location = new System.Drawing.Point(122, 98);
            this.lblCfname.Name = "lblCfname";
            this.lblCfname.Size = new System.Drawing.Size(23, 13);
            this.lblCfname.TabIndex = 5;
            this.lblCfname.Text = "null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cfname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ccode";
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBillNo.Location = new System.Drawing.Point(94, 29);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(16, 16);
            this.lblBillNo.TabIndex = 1;
            this.lblBillNo.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill No";
            // 
            // GenerateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(880, 460);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GenerateBill";
            this.Text = "GenerateBill";
            this.Load += new System.EventHandler(this.GenerateBill_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTtotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgItemDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCcode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.ComboBox cmbSelectItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustomertypename;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCgender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCaddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblClname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCfname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label6;
    }
}