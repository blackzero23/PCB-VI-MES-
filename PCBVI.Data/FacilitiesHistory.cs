//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PCBVI.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class FacilitiesHistory
    {
        public int FacilitiesHistoryId { get; set; }
        public System.DateTime WorkDate { get; set; }
        public int FacilitiesId { get; set; }
        public string Place { get; set; }
        public int FHistoryDivisionId { get; set; }
        public string HistoryContent { get; set; }
        public string OCompanyName { get; set; }
        public string OCompanyPhoneNum { get; set; }
        public string OCompanyEmployee { get; set; }
    
        public virtual Facility Facility { get; set; }
        public virtual FHistoryDivision FHistoryDivision { get; set; }
    }
}
