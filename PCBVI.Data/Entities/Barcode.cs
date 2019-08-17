using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data
{
    public partial class Barcode
    {
        public Barcode(int code)
        {
            this.BarcodeCode = code;
        }
        //Lot No
        public string LotName { get; set; }
        public string ErrorTypeName { get; set; }
        public string ItemName { get; set; }
    }
}
