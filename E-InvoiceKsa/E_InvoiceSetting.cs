using E_InvoiceKsa.Helper;
using System;
using System.Windows.Forms;
using ZatcaKsaLib.Interfaces;
using ZatcaKsaLib.Modals;
using ZatcaKsaLib.OperationalClasses;

namespace E_InvoiceKsa
{
    public partial class E_InvoiceSetting : Form
    {
        public E_InvoiceSetting()
        {
            InitializeComponent();
        }



        private void E_Invoice_Load(object sender, EventArgs e)
        {
            fillTextField();

            InvoiceType.DataSource = ListValues.InvoiceTypeList;
            InvoiceType.DisplayMember = "Name"; // What to show
            InvoiceType.ValueMember = "Id";

            Environment.DataSource = ListValues.EnvironmentList;
            Environment.DisplayMember = "Name"; // What to show
            Environment.ValueMember = "Id";
        }

        private void fillTextField()
        {
            CommonName.Text = "MST";
            SerialNumber.Text = "1-MST|2-TEST|3-uuid";
            OrganizationIdentifier.Text = "310931464300003";
            OrganizationUnitName.Text = "MB1";
            OrganizationName.Text = "شركة توريد التكنولوجيا بأقصى سرعة المحدودة|Maximum Speed Tech Supply LTD";
            Country.Text = "SA";
            Location.Text = "Riydh";
            Industry.Text = "Information Technology";
        }
      
        private ZatcaSettingKsa getZatcaSetting()
        {
            ZatcaSettingKsa ZatcaSettingKsa = new ZatcaSettingKsa
            {
                CommonName = CommonName.Text,
                SerialNumbeer = SerialNumber.Text,
                OrganizationIdentifier = OrganizationIdentifier.Text,
                OrganizationUnitName = OrganizationUnitName.Text,
                OrganizationName = OrganizationName.Text,
                Country = Country.Text,
                InvoiceType = InvoiceType.SelectedValue.ToString(),
                Location = Location.Text,
                Industry = Industry.Text,
            };
            return ZatcaSettingKsa;
        }

        private async void btnCSR_Click(object sender, EventArgs e)
        {
            var zatcaSetting = getZatcaSetting();
            IGenerationlocalCSRKsa generator = new GenerationlocalCSRKsa();
            var result = await generator.GeneratelocalCSRKsa(zatcaSetting);
            if (result.IsValid)
            {
                CSR.Text = result.Csr;
                Privatekey.Text = result.PrivateKey;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private async void btnPreCertificate_Click(object sender, EventArgs e)
        {
            var zatcaSetting = getZatcaSetting();
            zatcaSetting.CSR=CSR.Text;
            zatcaSetting.PrivateKey = Privatekey.Text;
            zatcaSetting.OTP = OTP.Text;
            zatcaSetting.Environment = Convert.ToInt32(Environment.SelectedValue);
            IGetComplianceCSIDKsa generator2 = new GetComplianceCSIDKsa();
            var result = await generator2.ComplianceCSIDKsa(zatcaSetting);
            if (result.IsValid)
            {
                Certificate.Text = result.Certificate;
                TokenId.Text = result.Token;
                SecretId.Text = result.Secret;
                RequestId.Text = result.RequestId;
                zatcaSetting.PreCertificate = true;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private async void btnLastCertificate_Click(object sender, EventArgs e)
        {
            var zatcaSetting = getZatcaSetting();
            zatcaSetting.CSR = CSR.Text;
            zatcaSetting.PrivateKey = Privatekey.Text;
            zatcaSetting.OTP = OTP.Text;
            zatcaSetting.Environment = Convert.ToInt32(Environment.SelectedValue);
            zatcaSetting.Certificate = Certificate.Text;
            zatcaSetting.Token = TokenId.Text;
            zatcaSetting.Secret = SecretId.Text;
            zatcaSetting.RequestId = RequestId.Text;
            IGetProductionCSIDKsa generator3 = new GetProductionCSIDKsa();
            var result = await generator3.ProductionCSIDKsa(zatcaSetting);
            if (result.IsValid)
            {
                Certificate.Text = result.Certificate;
                TokenId.Text = result.Token;
                SecretId.Text = result.Secret;
                RequestId.Text = result.RequestId;
                fillAppSetting();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void fillAppSetting()
        {
            var zatcaSetting = getZatcaSetting();
            zatcaSetting.CSR = CSR.Text;
            zatcaSetting.PrivateKey = Privatekey.Text;
            zatcaSetting.OTP = OTP.Text;
            zatcaSetting.Environment = Convert.ToInt32(Environment.SelectedValue);
            zatcaSetting.Certificate = Certificate.Text;
            zatcaSetting.Token = TokenId.Text;
            zatcaSetting.Secret = SecretId.Text;
            zatcaSetting.RequestId = RequestId.Text;
            zatcaSetting.PreCertificate = true;
            zatcaSetting.FinalCertificate=true;
            AppSettings.ZatcaSettingKsa = zatcaSetting;

        }
    }
}
