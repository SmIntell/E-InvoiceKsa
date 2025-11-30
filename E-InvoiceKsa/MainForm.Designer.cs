namespace E_InvoiceKsa
{
    partial class MainForm
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
            this.btnMainSetting = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMainSetting
            // 
            this.btnMainSetting.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnMainSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMainSetting.Location = new System.Drawing.Point(403, 202);
            this.btnMainSetting.Name = "btnMainSetting";
            this.btnMainSetting.Size = new System.Drawing.Size(97, 47);
            this.btnMainSetting.TabIndex = 40;
            this.btnMainSetting.Text = "الإعدادت الأساسية";
            this.btnMainSetting.UseVisualStyleBackColor = true;
            this.btnMainSetting.Click += new System.EventHandler(this.btnMainSetting_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoice.Location = new System.Drawing.Point(300, 202);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(97, 47);
            this.btnInvoice.TabIndex = 39;
            this.btnInvoice.Text = "الفاتورة";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMainSetting);
            this.Controls.Add(this.btnInvoice);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainSetting;
        private System.Windows.Forms.Button btnInvoice;
    }
}