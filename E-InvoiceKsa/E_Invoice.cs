using E_InvoiceKsa.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZatcaKsaLib.Interfaces;
using ZatcaKsaLib.Modals;
using ZatcaKsaLib.OperationalClasses;

namespace E_InvoiceKsa
{
    public partial class E_Invoice : Form
    {
        public E_Invoice()
        {
            InitializeComponent();
        }

        private void E_Invoice_Load(object sender, EventArgs e)
        {
            DocType.DataSource = ListValues.DocTypeList;
            DocType.DisplayMember = "Name"; // What to show
            DocType.ValueMember = "Id";
        }

        private async void BtnBaracode_Click(object sender, EventArgs e)
        {
            var currZatcaSetting = InvoiceOperations.GetAppSetting();
            var currCompanyKsa = InvoiceOperations.GetCompanyData();
            var currCustomerKsa = InvoiceOperations.GetCustomerKsa(RegistrationName.Text, CustomerVat.Text, CutomerAddress.Text, BuildingNumber.Text);
            var currSalesInvoiceReq = InvoiceOperations.GetSalesInvoiceReqKsa(DGVItems, InvoiceNo.Text, InvoiceDate.Value);
            var currSalesInvoiceLineReq = InvoiceOperations.GetSalesInvoiceLineReqKsa(DGVItems);

            VMSaleInvoiceReqKsa salesInvoice = new VMSaleInvoiceReqKsa
            {
                ZatcaSetting = currZatcaSetting,
                CompanyKsa = currCompanyKsa,
                CustomerKsa = currCustomerKsa,
                SalesInvoiceReq = currSalesInvoiceReq,
                SalesInvoiceLinesReq = currSalesInvoiceLineReq,
                MainSalesForNotesInvoice = null,
                DocType = Convert.ToInt32(DocType.SelectedValue),
            };
            IGenerationEInvoiceBarcodeKsa Generation = new GenerationEInvoiceBarcodeKsa();
            var result = await Generation.GeneratBarcode(salesInvoice);
            if (result.IsValid)
            {
                string bitMapBarcode = result.bitMapBarcode;
                Bitmap QrCode = InvoiceOperations.ToQrCode(result.bitMapBarcode);
                string safePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "barcode.txt");
                result.SavebitMapBarcodeToFile(safePath);
                btnBaracode.Image = Properties.Resources._true;
                MessageBox.Show(result.Message);
            }
            else
            {
                btnBaracode.Image = Properties.Resources._false;
                MessageBox.Show(result.Message);
            }
        }

        private async void BtnXML_Click(object sender, EventArgs e)
        {
            var currZatcaSetting = InvoiceOperations.GetAppSetting();
            var currCompanyKsa = InvoiceOperations.GetCompanyData();
            var currCustomerKsa = InvoiceOperations.GetCustomerKsa(RegistrationName.Text, CustomerVat.Text, CutomerAddress.Text, BuildingNumber.Text);
            var currSalesInvoiceReq = InvoiceOperations.GetSalesInvoiceReqKsa(DGVItems, InvoiceNo.Text, InvoiceDate.Value);
            var currSalesInvoiceLineReq = InvoiceOperations.GetSalesInvoiceLineReqKsa(DGVItems);
            
            VMSaleInvoiceReqKsa salesInvoice = new VMSaleInvoiceReqKsa
            {
                ZatcaSetting = currZatcaSetting,
                CompanyKsa = currCompanyKsa,
                CustomerKsa = currCustomerKsa,
                SalesInvoiceReq = currSalesInvoiceReq,
                SalesInvoiceLinesReq = currSalesInvoiceLineReq,
                MainSalesForNotesInvoice = null,
                DocType = Convert.ToInt32(DocType.SelectedValue),
            };
            ICreationFullXmlFileKsa Creation = new CreationFullXmlFileKsa();
            var result = await Creation.CreateFullXmlFile(salesInvoice);
            if (result.IsValid)
            {
                var xmlFile = result.XmlDocument;
                string safePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "xmlFile.xml");
                result.SaveXmlDocumentToFile(safePath);
                btnXML.Image = Properties.Resources._true;
                MessageBox.Show(result.Message);
            }
            else
            {
                btnXML.Image = Properties.Resources._false;
                MessageBox.Show(result.Message);
            }
        }

        private async void BtnReporting_Click(object sender, EventArgs e)
        {
            var currZatcaSetting = InvoiceOperations.GetAppSetting();
            var currCompanyKsa = InvoiceOperations.GetCompanyData();
            var currCustomerKsa = InvoiceOperations.GetCustomerKsa(RegistrationName.Text, CustomerVat.Text, CutomerAddress.Text, BuildingNumber.Text);
            var currSalesInvoiceReq = InvoiceOperations.GetSalesInvoiceReqKsa(DGVItems, InvoiceNo.Text, InvoiceDate.Value);
            var currSalesInvoiceLineReq = InvoiceOperations.GetSalesInvoiceLineReqKsa(DGVItems);

            VMSaleInvoiceReqKsa salesInvoice = new VMSaleInvoiceReqKsa
            {
                ZatcaSetting = currZatcaSetting,
                CompanyKsa = currCompanyKsa,
                CustomerKsa = currCustomerKsa,
                SalesInvoiceReq = currSalesInvoiceReq,
                SalesInvoiceLinesReq = currSalesInvoiceLineReq,
                MainSalesForNotesInvoice = null,
                DocType = Convert.ToInt32(DocType.SelectedValue),
            };
            IReportingInvoiceXmlKsa Reporting = new ReportingInvoiceXmlKsa();
            var result = await Reporting.ReportInvoiceXml(salesInvoice);
            if (result.IsValid)
            {
                string body = result.BodyContent;
                string safePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BodyContent.txt");
                result.SaveBodyContentToFile(safePath);
                btnReporting.Image = Properties.Resources._true;
                MessageBox.Show(result.Message);
            }
            else
            {
                btnReporting.Image = Properties.Resources._false;
                MessageBox.Show(result.Message);
            }
        }

        private async void BtnClearance_Click(object sender, EventArgs e)
        {
            var currZatcaSetting = InvoiceOperations.GetAppSetting();
            var currCompanyKsa = InvoiceOperations.GetCompanyData();
            var currCustomerKsa = InvoiceOperations.GetCustomerKsa(RegistrationName.Text, CustomerVat.Text, CutomerAddress.Text, BuildingNumber.Text);
            var currSalesInvoiceReq = InvoiceOperations.GetSalesInvoiceReqKsa(DGVItems, InvoiceNo.Text, InvoiceDate.Value);
            var currSalesInvoiceLineReq = InvoiceOperations.GetSalesInvoiceLineReqKsa(DGVItems);

            VMSaleInvoiceReqKsa salesInvoice = new VMSaleInvoiceReqKsa
            {
                ZatcaSetting = currZatcaSetting,
                CompanyKsa = currCompanyKsa,
                CustomerKsa = currCustomerKsa,
                SalesInvoiceReq = currSalesInvoiceReq,
                SalesInvoiceLinesReq = currSalesInvoiceLineReq,
                MainSalesForNotesInvoice = null,
                DocType = Convert.ToInt32(DocType.SelectedValue),
            };
            IClearancingInvoiceXmlKsa Clearancing = new ClearancingInvoiceXmlKsa();
            var result = await Clearancing.ClearanceInvoiceXml(salesInvoice);
            if (result.IsValid)
            {
                string body = result.BodyContent;
                string safePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BodyContent.txt");
                result.SaveBodyContentToFile(safePath);
                btnClearance.Image = Properties.Resources._true;
                MessageBox.Show(result.Message);
            }
            else
            {
                btnClearance.Image = Properties.Resources._false;
                MessageBox.Show(result.Message);
            }
        }

        private void DGVItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                if(e.ColumnIndex== DGVItems.Columns["Price"].Index)
                {
                    DGVItems.Rows[e.RowIndex].Cells["Total"].Value =
                        Convert.ToDecimal(DGVItems.Rows[e.RowIndex].Cells["Price"].Value) * Convert.ToDecimal(DGVItems.Rows[e.RowIndex].Cells["Quantity"].Value);
                }
                if (e.ColumnIndex == DGVItems.Columns["Vat"].Index)
                {
                    decimal total = Convert.ToDecimal(DGVItems.Rows[e.RowIndex].Cells["Price"].Value) * Convert.ToDecimal(DGVItems.Rows[e.RowIndex].Cells["Quantity"].Value);
                    DGVItems.Rows[e.RowIndex].Cells["Total"].Value =total + Convert.ToDecimal(DGVItems.Rows[e.RowIndex].Cells["Price"].Value)/100*total;
                }
            }
        }
    }
}
