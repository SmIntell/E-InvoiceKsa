using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZatcaKsaLib.Modals;

namespace E_InvoiceKsa.Helper
{
    public static class InvoiceOperations
    {
        public static ZatcaSettingKsa GetAppSetting()
        {
            var zatcaSettings = AppSettings.ZatcaSettingKsa;

            if (zatcaSettings != null)
            {
                MessageBox.Show($"FinalCertificate: {zatcaSettings.FinalCertificate} And PreCertificate: {zatcaSettings.PreCertificate}");
            }
            else
            {
                MessageBox.Show("Settings not configured yet.");
            }
            return zatcaSettings;
        }

        public static CompanyKsa GetCompanyData()
        {
            CompanyKsa companyKsa = new CompanyKsa
            {
                RegistrationName= "شركة توريد التكنولوجيا بأقصى سرعة المحدودة",
                RegistrationNameEn= "Maximum Speed Tech Supply LTD",
                CompanyID= "399999999900003",
                CRN= "1010010000",
                PostalZone = "23333",
                CityName= "الرياض",
                CityEnName= "Riyadh",
                CitySubdivisionName= "المربع",
                CitySubdivisionNameEn= "Al-Murabba",
                BuildingNumber= "2322",
                StreetName= "الامير سلطان",
                StreetNameEn= "Prince Sultan",
            };
            return companyKsa;
        }

        public static CustomerKsa GetCustomerKsa(string _RegistrationName,string _CustomerVat,string _CutomerAddress,string _BuildingNumber)
        {
            CustomerKsa customerKsa = new CustomerKsa
            {
                RegistrationName = _RegistrationName,
                CompanyID = _CustomerVat,
                StreetName = _CutomerAddress,
                BuildingNumber = _BuildingNumber,
                
            };
            return customerKsa;
        }

        public static List<SalesInvoiceLineReqKsa> GetSalesInvoiceLineReqKsa(DataGridView DGVItems)
        {
            List<SalesInvoiceLineReqKsa> salesInvoiceLineReqKsas = new List<SalesInvoiceLineReqKsa>();
            
            foreach (DataGridViewRow row in DGVItems.Rows)
            {
                string ItemName = "";
                int Quantity = 0;
                decimal Price = 0;
                decimal Vat = 0;
                decimal Total = 0;
                if (row.Cells[0].Value != null)
                {
                    ItemName = row.Cells[0].Value.ToString();
                }
                if (row.Cells[1].Value != null)
                {
                    Quantity = Convert.ToInt32(row.Cells[1].Value);
                }
                if (row.Cells[2].Value != null)
                {
                    Price = Convert.ToDecimal(row.Cells[2].Value);
                }
                if (row.Cells[3].Value != null)
                {
                    Vat = Convert.ToDecimal(row.Cells[3].Value);
                }
                Total = Quantity * Price;
                if (Total > 0)
                {
                    SalesInvoiceLineReqKsa salesInvoiceReqKsa = new SalesInvoiceLineReqKsa
                    {
                        ItemName = ItemName,
                        ItemQuantity = Quantity,
                        ItemPrice = Price,
                        DiscountAmount = 0,
                        VatPrecent = Vat,
                        VatAmount = Convert.ToDecimal(Vat) / Convert.ToDecimal(100) * Total,
                        TotalAmount = Total,
                    };
                    salesInvoiceLineReqKsas.Add(salesInvoiceReqKsa);
                }
            }

            return salesInvoiceLineReqKsas;
        }

        private static decimal GetTotalAmount(DataGridView DGVItems)
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in DGVItems.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    decimal quantity;
                    decimal cost;
                    if (decimal.TryParse(row.Cells[1].Value.ToString(), out quantity)
                        && decimal.TryParse(row.Cells[2].Value.ToString(), out cost))
                    {
                        totalAmount += (quantity * cost);
                    }
                }
            }
            return totalAmount;
        }

        public static SalesInvoiceReqKsa GetSalesInvoiceReqKsa(DataGridView DGVItems, string _InvoiceNo,DateTime _InvoiceDate)
        {
            decimal total = GetTotalAmount(DGVItems);
            SalesInvoiceReqKsa salesInvoiceReqKsa = new SalesInvoiceReqKsa
            {
                IId = Convert.ToInt32(_InvoiceNo),
                InvoiceNo = _InvoiceNo,
                InvoiceDate = _InvoiceDate,
                PaymentMethod = "10",
                DiscountAmount = 0,
                Percent = 15,
                TaxAmount = Convert.ToDecimal(15) / Convert.ToDecimal(100) * total,
                TotalAmount = total,
                Comment = "فاتورة تجريبة",
            };
            return salesInvoiceReqKsa;
        }

        public static Bitmap ToQrCode(string QRBase64, int width = 250, int height = 250)
        {
            ZXing.BarcodeWriter barcodeWriter = new ZXing.BarcodeWriter
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = width,
                    Height = height
                }
            };
            return barcodeWriter.Write(QRBase64);

        }



    }
}
