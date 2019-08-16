using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class DB
    {
        public static DepartMentData Department { get;} = new DepartMentData();       
        public static BarCodeData BarCode { get; } = new BarCodeData();
        public static EmployeeData Employee { get; } = new EmployeeData();
        public static ErrorCodeData ErrorCode { get; } = new ErrorCodeData();
        public static ErrorTypeData ErrorType { get; } = new ErrorTypeData();
        public static ErrorKindData ErrorKind { get; } = new ErrorKindData();
        public static LotData Lot { get; } = new LotData();
    }
}
