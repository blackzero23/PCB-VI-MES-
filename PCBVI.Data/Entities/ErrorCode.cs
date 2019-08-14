using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data
{
    public partial class ErrorCode
    {
        public ErrorCode(string _code)
        {
            this.Code = _code;
        }

        public string ErrorTypeName { get; set; }
        public string ErrorKindName { get; set; }
    }
}
