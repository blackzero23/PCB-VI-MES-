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
    
    public partial class Lot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lot()
        {
            this.DefectiveProducts = new HashSet<DefectiveProduct>();
            this.LotBarCodes = new HashSet<LotBarCode>();
            this.MaterialHistories = new HashSet<MaterialHistory>();
            this.MaterialsManages = new HashSet<MaterialsManage>();
        }
    
        public int LotId { get; set; }
        public string LotCode { get; set; }
        public int WorkPlaceId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DefectiveProduct> DefectiveProducts { get; set; }
        public virtual WorkPlace WorkPlace { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LotBarCode> LotBarCodes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialHistory> MaterialHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialsManage> MaterialsManages { get; set; }
    }
}
