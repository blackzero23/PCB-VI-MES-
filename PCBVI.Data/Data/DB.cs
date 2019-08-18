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
        public static FacilitiesData Facilities { get; } = new FacilitiesData();
        public static FacilitiesHistoryData FacilitiesHistory { get; } = new FacilitiesHistoryData();
        public static FHistoryDivisionData FHistoryDivision { get; } = new FHistoryDivisionData();
        public static WorkPlaceData WorkPlace { get; } = new WorkPlaceData();
        public static LotData Lot { get; } = new LotData();
        public static FirstItemDivisionData FirstItemDivision { get;} = new FirstItemDivisionData();
        public static SecondItemDivisionData SecondItemDivision { get; } = new SecondItemDivisionData();
        public static ItemData Item { get; } = new ItemData();
        public static ProcessData Process { get; } = new ProcessData();
        public static DefectiveProductData DefectiveProduct { get; } = new DefectiveProductData();
        public static MaterialHistoryData MaterialHistory { get; } = new MaterialHistoryData();
        public static FirstInspectionData FirstInspection { get; } = new FirstInspectionData();
        public static InspectionStandardTypeData InspectionStandardType { get; } = new InspectionStandardTypeData();
        public static InspectionStandardData InspectionStandard { get; } = new InspectionStandardData();
        public static RotationGroupData RotationGroup { get; } = new RotationGroupData();
        public static WorkOrderData WorkOrder { get; } = new WorkOrderData();

        public static WorkLogData WorkLog { get; } = new WorkLogData();
    }
}
