using System.Collections.Generic;
using ZatcaKsaLib.EnumsKsa;

namespace E_InvoiceKsa.Helper
{
    internal static class ListValues
    {
        internal static List<InvoiceTypeModel> InvoiceTypeList = new List<InvoiceTypeModel>
            {
                new InvoiceTypeModel { Id = "1000", Name = "Standard Invoice فاتورة ضريبية" },
                new InvoiceTypeModel { Id = "0100", Name = "Simplified Invoice فاتورة ضريبية مبسطة" },
                new InvoiceTypeModel { Id = "1100", Name = "Standard And Simplified Invoice فاتورة ضريبية ومبسطة" }
            };

        internal static List<EnvironmentModel> EnvironmentList = new List<EnvironmentModel>
            {
                new EnvironmentModel { Id = (int)EnvironmentTypeKsa.NonProduction, Name = "NonProduction منصة المطورين" },
                new EnvironmentModel { Id = (int)EnvironmentTypeKsa.Simulation, Name = "Simulation منصة محاكاة الفاتورة الإلكترونية" },
                new EnvironmentModel { Id = (int)EnvironmentTypeKsa.Production, Name = "Production منصة الفاتورة الإلكترونية "}
            };

        internal static List<EnvironmentModel> DocTypeList = new List<EnvironmentModel>
            {
                new EnvironmentModel { Id = (int)SalesInvoiceNotesTypeKsa.SimplifiedInvoice, Name = "Simplified Invoice فاتورة ضريبية مبسطة"  },
                new EnvironmentModel { Id = (int)SalesInvoiceNotesTypeKsa.SimplifiedCreditNote, Name = "Simplified Credit Note إشعار دائن مبسط" },
                new EnvironmentModel { Id = (int)SalesInvoiceNotesTypeKsa.SimplifiedDebitNote, Name = "SimplifiedDebitNote إشعار مدين مبسط "},
                new EnvironmentModel { Id = (int)SalesInvoiceNotesTypeKsa.StandardInvoice, Name = "Standard Invoice فاتورة ضريبية "  },
                new EnvironmentModel { Id = (int)SalesInvoiceNotesTypeKsa.StandardCreditNote, Name = "Standard Credit Note إشعار دائن ضريبي" },
                new EnvironmentModel { Id = (int)SalesInvoiceNotesTypeKsa.StandardDebitNote, Name = "Standard إشعار مدين ضريبي "},

            };
    }
}
