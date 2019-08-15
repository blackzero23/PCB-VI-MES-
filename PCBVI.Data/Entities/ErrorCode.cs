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

        //DB 에에러코드 테이블에 해당 컬럼이 없기 때문에 DataGridView에서 뿌려주기위해서
        //임의로 프로퍼티를 만듬.
        public string ErrorTypeName { get; set; }

        public string ErrorKindName { get; set; }

    }
}
