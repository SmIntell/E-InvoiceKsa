using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_InvoiceKsa.Helper
{
    internal class InvoiceTypeModel
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name; // This is what will be displayed in the ComboBox
        }
    }
}
