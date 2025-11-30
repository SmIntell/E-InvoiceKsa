namespace E_InvoiceKsa
{
    partial class E_InvoiceSetting
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
            this.btnCSR = new System.Windows.Forms.Button();
            this.MainSetting = new System.Windows.Forms.Panel();
            this.Environment = new System.Windows.Forms.ComboBox();
            this.InvoiceType = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.OTP = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Industry = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.OrganizationName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.OrganizationUnitName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OrganizationIdentifier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SerialNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CommonName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLastCertificate = new System.Windows.Forms.Button();
            this.btnPreCertificate = new System.Windows.Forms.Button();
            this.RequestId = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.SecretId = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.TokenId = new System.Windows.Forms.RichTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.Certificate = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Privatekey = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CSR = new System.Windows.Forms.RichTextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.MainSetting.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCSR
            // 
            this.btnCSR.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnCSR.Image = global::E_InvoiceKsa.Properties.Resources._false;
            this.btnCSR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCSR.Location = new System.Drawing.Point(676, 14);
            this.btnCSR.Name = "btnCSR";
            this.btnCSR.Size = new System.Drawing.Size(97, 47);
            this.btnCSR.TabIndex = 0;
            this.btnCSR.Text = "CSR توليد";
            this.btnCSR.UseVisualStyleBackColor = true;
            this.btnCSR.Click += new System.EventHandler(this.btnCSR_Click);
            // 
            // MainSetting
            // 
            this.MainSetting.Controls.Add(this.Environment);
            this.MainSetting.Controls.Add(this.InvoiceType);
            this.MainSetting.Controls.Add(this.label19);
            this.MainSetting.Controls.Add(this.label20);
            this.MainSetting.Controls.Add(this.OTP);
            this.MainSetting.Controls.Add(this.label21);
            this.MainSetting.Controls.Add(this.label22);
            this.MainSetting.Controls.Add(this.Industry);
            this.MainSetting.Controls.Add(this.label23);
            this.MainSetting.Controls.Add(this.label24);
            this.MainSetting.Controls.Add(this.Location);
            this.MainSetting.Controls.Add(this.label9);
            this.MainSetting.Controls.Add(this.label10);
            this.MainSetting.Controls.Add(this.label11);
            this.MainSetting.Controls.Add(this.label12);
            this.MainSetting.Controls.Add(this.Country);
            this.MainSetting.Controls.Add(this.label13);
            this.MainSetting.Controls.Add(this.label14);
            this.MainSetting.Controls.Add(this.OrganizationName);
            this.MainSetting.Controls.Add(this.label15);
            this.MainSetting.Controls.Add(this.label16);
            this.MainSetting.Controls.Add(this.OrganizationUnitName);
            this.MainSetting.Controls.Add(this.label7);
            this.MainSetting.Controls.Add(this.label8);
            this.MainSetting.Controls.Add(this.OrganizationIdentifier);
            this.MainSetting.Controls.Add(this.label5);
            this.MainSetting.Controls.Add(this.label6);
            this.MainSetting.Controls.Add(this.SerialNumber);
            this.MainSetting.Controls.Add(this.label3);
            this.MainSetting.Controls.Add(this.label4);
            this.MainSetting.Controls.Add(this.CommonName);
            this.MainSetting.Controls.Add(this.label2);
            this.MainSetting.Controls.Add(this.label1);
            this.MainSetting.Location = new System.Drawing.Point(12, 12);
            this.MainSetting.Name = "MainSetting";
            this.MainSetting.Size = new System.Drawing.Size(776, 305);
            this.MainSetting.TabIndex = 1;
            // 
            // Environment
            // 
            this.Environment.FormattingEnabled = true;
            this.Environment.Location = new System.Drawing.Point(158, 275);
            this.Environment.Name = "Environment";
            this.Environment.Size = new System.Drawing.Size(504, 21);
            this.Environment.TabIndex = 33;
            // 
            // InvoiceType
            // 
            this.InvoiceType.FormattingEnabled = true;
            this.InvoiceType.Location = new System.Drawing.Point(158, 169);
            this.InvoiceType.Name = "InvoiceType";
            this.InvoiceType.Size = new System.Drawing.Size(504, 21);
            this.InvoiceType.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(12, 275);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Environment";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(670, 275);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "بيئة الربط";
            // 
            // OTP
            // 
            this.OTP.Location = new System.Drawing.Point(158, 246);
            this.OTP.Name = "OTP";
            this.OTP.Size = new System.Drawing.Size(505, 20);
            this.OTP.TabIndex = 29;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(12, 249);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 13);
            this.label21.TabIndex = 28;
            this.label21.Text = "OTP";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(670, 249);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 13);
            this.label22.TabIndex = 27;
            this.label22.Text = "كود الإتصال";
            // 
            // Industry
            // 
            this.Industry.Location = new System.Drawing.Point(158, 220);
            this.Industry.Name = "Industry";
            this.Industry.Size = new System.Drawing.Size(505, 20);
            this.Industry.TabIndex = 26;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(12, 223);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 25;
            this.label23.Text = "Industry";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(670, 223);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 24;
            this.label24.Text = "مجال العمل";
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(158, 194);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(505, 20);
            this.Location.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(12, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Location";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(670, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "الموقع";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(12, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Invoice Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(670, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "نوع الفاتورة";
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(158, 142);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(505, 20);
            this.Country.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(12, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Country";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(670, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "الدولة";
            // 
            // OrganizationName
            // 
            this.OrganizationName.Location = new System.Drawing.Point(158, 116);
            this.OrganizationName.Name = "OrganizationName";
            this.OrganizationName.Size = new System.Drawing.Size(505, 20);
            this.OrganizationName.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(12, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Organization Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(670, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "اسم الشركة";
            // 
            // OrganizationUnitName
            // 
            this.OrganizationUnitName.Location = new System.Drawing.Point(158, 90);
            this.OrganizationUnitName.Name = "OrganizationUnitName";
            this.OrganizationUnitName.Size = new System.Drawing.Size(505, 20);
            this.OrganizationUnitName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Organization Unit Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(670, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "اسم الفرع";
            // 
            // OrganizationIdentifier
            // 
            this.OrganizationIdentifier.Location = new System.Drawing.Point(158, 64);
            this.OrganizationIdentifier.Name = "OrganizationIdentifier";
            this.OrganizationIdentifier.Size = new System.Drawing.Size(505, 20);
            this.OrganizationIdentifier.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Organization Identifier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(670, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "الرقم الضريبي";
            // 
            // SerialNumber
            // 
            this.SerialNumber.Location = new System.Drawing.Point(158, 38);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(505, 20);
            this.SerialNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serial Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(670, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "الرقم التسلسلي";
            // 
            // CommonName
            // 
            this.CommonName.Location = new System.Drawing.Point(158, 12);
            this.CommonName.Name = "CommonName";
            this.CommonName.Size = new System.Drawing.Size(505, 20);
            this.CommonName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Common Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(670, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "الإسم العام";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLastCertificate);
            this.panel1.Controls.Add(this.btnPreCertificate);
            this.panel1.Controls.Add(this.RequestId);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.SecretId);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.TokenId);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.Certificate);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.Privatekey);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.CSR);
            this.panel1.Controls.Add(this.btnCSR);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Location = new System.Drawing.Point(9, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 292);
            this.panel1.TabIndex = 2;
            // 
            // btnLastCertificate
            // 
            this.btnLastCertificate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnLastCertificate.Image = global::E_InvoiceKsa.Properties.Resources._false;
            this.btnLastCertificate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLastCertificate.Location = new System.Drawing.Point(673, 126);
            this.btnLastCertificate.Name = "btnLastCertificate";
            this.btnLastCertificate.Size = new System.Drawing.Size(97, 47);
            this.btnLastCertificate.TabIndex = 38;
            this.btnLastCertificate.Text = "إصدار شهادة نهائية";
            this.btnLastCertificate.UseVisualStyleBackColor = true;
            this.btnLastCertificate.Click += new System.EventHandler(this.btnLastCertificate_Click);
            // 
            // btnPreCertificate
            // 
            this.btnPreCertificate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnPreCertificate.Image = global::E_InvoiceKsa.Properties.Resources._false;
            this.btnPreCertificate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreCertificate.Location = new System.Drawing.Point(676, 70);
            this.btnPreCertificate.Name = "btnPreCertificate";
            this.btnPreCertificate.Size = new System.Drawing.Size(97, 47);
            this.btnPreCertificate.TabIndex = 37;
            this.btnPreCertificate.Text = "إصدار شهادة مبدئية";
            this.btnPreCertificate.UseVisualStyleBackColor = true;
            this.btnPreCertificate.Click += new System.EventHandler(this.btnPreCertificate_Click);
            // 
            // RequestId
            // 
            this.RequestId.Location = new System.Drawing.Point(161, 261);
            this.RequestId.Name = "RequestId";
            this.RequestId.Size = new System.Drawing.Size(505, 20);
            this.RequestId.TabIndex = 36;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(15, 264);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 13);
            this.label26.TabIndex = 35;
            this.label26.Text = "Request Id";
            // 
            // SecretId
            // 
            this.SecretId.Location = new System.Drawing.Point(161, 235);
            this.SecretId.Name = "SecretId";
            this.SecretId.Size = new System.Drawing.Size(505, 20);
            this.SecretId.TabIndex = 34;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(15, 238);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 13);
            this.label27.TabIndex = 33;
            this.label27.Text = "Secret Id";
            // 
            // TokenId
            // 
            this.TokenId.Location = new System.Drawing.Point(161, 179);
            this.TokenId.Name = "TokenId";
            this.TokenId.Size = new System.Drawing.Size(505, 50);
            this.TokenId.TabIndex = 8;
            this.TokenId.Text = "";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(15, 192);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 13);
            this.label25.TabIndex = 7;
            this.label25.Text = "Public Key";
            // 
            // Certificate
            // 
            this.Certificate.Location = new System.Drawing.Point(161, 123);
            this.Certificate.Name = "Certificate";
            this.Certificate.Size = new System.Drawing.Size(505, 50);
            this.Certificate.TabIndex = 6;
            this.Certificate.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(15, 143);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Certificate";
            // 
            // Privatekey
            // 
            this.Privatekey.Location = new System.Drawing.Point(161, 67);
            this.Privatekey.Name = "Privatekey";
            this.Privatekey.Size = new System.Drawing.Size(505, 50);
            this.Privatekey.TabIndex = 4;
            this.Privatekey.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(15, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Private key";
            // 
            // CSR
            // 
            this.CSR.Location = new System.Drawing.Point(161, 11);
            this.CSR.Name = "CSR";
            this.CSR.Size = new System.Drawing.Size(505, 50);
            this.CSR.TabIndex = 2;
            this.CSR.Text = "";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label43.Location = new System.Drawing.Point(15, 31);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(29, 13);
            this.label43.TabIndex = 1;
            this.label43.Text = "CSR";
            // 
            // E_InvoiceSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainSetting);
            this.Name = "E_InvoiceSetting";
            this.Text = "الإعدادات الأساسية";
            this.Load += new System.EventHandler(this.E_Invoice_Load);
            this.MainSetting.ResumeLayout(false);
            this.MainSetting.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCSR;
        private System.Windows.Forms.Panel MainSetting;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox OTP;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox Industry;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox OrganizationName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox OrganizationUnitName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox OrganizationIdentifier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SerialNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CommonName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox CSR;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox RequestId;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox SecretId;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.RichTextBox TokenId;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.RichTextBox Certificate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox Privatekey;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnLastCertificate;
        private System.Windows.Forms.Button btnPreCertificate;
        private System.Windows.Forms.ComboBox InvoiceType;
        private System.Windows.Forms.ComboBox Environment;
    }
}

