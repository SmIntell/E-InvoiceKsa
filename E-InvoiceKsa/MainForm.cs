using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_InvoiceKsa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMainSetting_Click(object sender, EventArgs e)
        {
            E_InvoiceSetting e_InvoiceSetting = new E_InvoiceSetting();
            e_InvoiceSetting.ShowDialog();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            E_Invoice e_Invoice = new E_Invoice();
            e_Invoice.ShowDialog();
            
        }
    }
}
