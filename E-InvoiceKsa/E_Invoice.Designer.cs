namespace E_InvoiceKsa
{
    partial class E_Invoice
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
            this.btnXML = new System.Windows.Forms.Button();
            this.MainSetting = new System.Windows.Forms.Panel();
            this.InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.BuildingNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CutomerAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CustomerVat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RegistrationName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InvoiceNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGVItems = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearance = new System.Windows.Forms.Button();
            this.btnReporting = new System.Windows.Forms.Button();
            this.btnBaracode = new System.Windows.Forms.Button();
            this.DocType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MainSetting.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXML
            // 
            this.btnXML.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnXML.Image = global::E_InvoiceKsa.Properties.Resources._false;
            this.btnXML.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXML.Location = new System.Drawing.Point(115, 487);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(97, 47);
            this.btnXML.TabIndex = 0;
            this.btnXML.Text = "Create XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.BtnXML_Click);
            // 
            // MainSetting
            // 
            this.MainSetting.Controls.Add(this.DocType);
            this.MainSetting.Controls.Add(this.label11);
            this.MainSetting.Controls.Add(this.label12);
            this.MainSetting.Controls.Add(this.InvoiceDate);
            this.MainSetting.Controls.Add(this.BuildingNumber);
            this.MainSetting.Controls.Add(this.label13);
            this.MainSetting.Controls.Add(this.label14);
            this.MainSetting.Controls.Add(this.CutomerAddress);
            this.MainSetting.Controls.Add(this.label15);
            this.MainSetting.Controls.Add(this.label16);
            this.MainSetting.Controls.Add(this.CustomerVat);
            this.MainSetting.Controls.Add(this.label7);
            this.MainSetting.Controls.Add(this.label8);
            this.MainSetting.Controls.Add(this.RegistrationName);
            this.MainSetting.Controls.Add(this.label5);
            this.MainSetting.Controls.Add(this.label6);
            this.MainSetting.Controls.Add(this.label3);
            this.MainSetting.Controls.Add(this.label4);
            this.MainSetting.Controls.Add(this.InvoiceNo);
            this.MainSetting.Controls.Add(this.label2);
            this.MainSetting.Controls.Add(this.label1);
            this.MainSetting.Location = new System.Drawing.Point(12, 12);
            this.MainSetting.Name = "MainSetting";
            this.MainSetting.Size = new System.Drawing.Size(776, 200);
            this.MainSetting.TabIndex = 1;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.Location = new System.Drawing.Point(158, 38);
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.Size = new System.Drawing.Size(504, 20);
            this.InvoiceDate.TabIndex = 18;
            // 
            // BuildingNumber
            // 
            this.BuildingNumber.Location = new System.Drawing.Point(158, 142);
            this.BuildingNumber.Name = "BuildingNumber";
            this.BuildingNumber.Size = new System.Drawing.Size(505, 20);
            this.BuildingNumber.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(12, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Building Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(670, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "رقم المبنى";
            // 
            // CutomerAddress
            // 
            this.CutomerAddress.Location = new System.Drawing.Point(158, 116);
            this.CutomerAddress.Name = "CutomerAddress";
            this.CutomerAddress.Size = new System.Drawing.Size(505, 20);
            this.CutomerAddress.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(12, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Customer Address";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(670, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "العنوان";
            // 
            // CustomerVat
            // 
            this.CustomerVat.Location = new System.Drawing.Point(158, 90);
            this.CustomerVat.Name = "CustomerVat";
            this.CustomerVat.Size = new System.Drawing.Size(505, 20);
            this.CustomerVat.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Customer VAT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(670, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "الرقم الضريبي";
            // 
            // RegistrationName
            // 
            this.RegistrationName.Location = new System.Drawing.Point(158, 64);
            this.RegistrationName.Name = "RegistrationName";
            this.RegistrationName.Size = new System.Drawing.Size(505, 20);
            this.RegistrationName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Registration Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(670, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "اسم العميل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Invoice Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(670, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "تاريخ الفاتورة";
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.Location = new System.Drawing.Point(158, 12);
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.Size = new System.Drawing.Size(505, 20);
            this.InvoiceNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(670, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGVItems);
            this.panel1.Location = new System.Drawing.Point(12, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 263);
            this.panel1.TabIndex = 2;
            // 
            // DGVItems
            // 
            this.DGVItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Quantity,
            this.Price,
            this.Vat,
            this.Total});
            this.DGVItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVItems.Location = new System.Drawing.Point(0, 0);
            this.DGVItems.Name = "DGVItems";
            this.DGVItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGVItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVItems.Size = new System.Drawing.Size(776, 263);
            this.DGVItems.TabIndex = 0;
            this.DGVItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVItems_CellValueChanged);
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "الصنف";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 300;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "الكمية";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "السعر";
            this.Price.Name = "Price";
            // 
            // Vat
            // 
            this.Vat.HeaderText = "الضريبة %";
            this.Vat.Name = "Vat";
            // 
            // Total
            // 
            this.Total.HeaderText = "الإجمالي";
            this.Total.Name = "Total";
            this.Total.Width = 132;
            // 
            // btnClearance
            // 
            this.btnClearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnClearance.Image = global::E_InvoiceKsa.Properties.Resources._false;
            this.btnClearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearance.Location = new System.Drawing.Point(321, 487);
            this.btnClearance.Name = "btnClearance";
            this.btnClearance.Size = new System.Drawing.Size(97, 47);
            this.btnClearance.TabIndex = 38;
            this.btnClearance.Text = "Cleanrance";
            this.btnClearance.UseVisualStyleBackColor = true;
            this.btnClearance.Click += new System.EventHandler(this.BtnClearance_Click);
            // 
            // btnReporting
            // 
            this.btnReporting.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnReporting.Image = global::E_InvoiceKsa.Properties.Resources._false;
            this.btnReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporting.Location = new System.Drawing.Point(218, 487);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(97, 47);
            this.btnReporting.TabIndex = 37;
            this.btnReporting.Text = "Reporting";
            this.btnReporting.UseVisualStyleBackColor = true;
            this.btnReporting.Click += new System.EventHandler(this.BtnReporting_Click);
            // 
            // btnBaracode
            // 
            this.btnBaracode.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnBaracode.Image = global::E_InvoiceKsa.Properties.Resources._false;
            this.btnBaracode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaracode.Location = new System.Drawing.Point(12, 487);
            this.btnBaracode.Name = "btnBaracode";
            this.btnBaracode.Size = new System.Drawing.Size(97, 47);
            this.btnBaracode.TabIndex = 39;
            this.btnBaracode.Text = "Baracode";
            this.btnBaracode.UseVisualStyleBackColor = true;
            this.btnBaracode.Click += new System.EventHandler(this.BtnBaracode_Click);
            // 
            // DocType
            // 
            this.DocType.FormattingEnabled = true;
            this.DocType.Location = new System.Drawing.Point(158, 168);
            this.DocType.Name = "DocType";
            this.DocType.Size = new System.Drawing.Size(504, 21);
            this.DocType.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(12, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Document Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(670, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "نوع الوثيقة";
            // 
            // E_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.btnBaracode);
            this.Controls.Add(this.btnClearance);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReporting);
            this.Controls.Add(this.MainSetting);
            this.Controls.Add(this.btnXML);
            this.Name = "E_Invoice";
            this.Text = "بيانات الفاتورة";
            this.Load += new System.EventHandler(this.E_Invoice_Load);
            this.MainSetting.ResumeLayout(false);
            this.MainSetting.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Panel MainSetting;
        private System.Windows.Forms.TextBox BuildingNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox CutomerAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox CustomerVat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RegistrationName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InvoiceNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearance;
        private System.Windows.Forms.Button btnReporting;
        private System.Windows.Forms.DateTimePicker InvoiceDate;
        private System.Windows.Forms.DataGridView DGVItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnBaracode;
        private System.Windows.Forms.ComboBox DocType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

