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
    
    public partial class Facility
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facility()
        {
            this.ProductionHistories = new HashSet<ProductionHistory>();
            this.FacilitiesHistories = new HashSet<FacilitiesHistory>();
            this.FacilitiesPowers = new HashSet<FacilitiesPower>();
            this.Workers = new HashSet<Worker>();
        }
    
        public int FacilitiesId { get; set; }
        public int Num { get; set; }
        public string Name { get; set; }
        public bool InspectionStatus { get; set; }
        public bool UseState { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double length { get; set; }
        public double volume { get; set; }
        public int ProcessId { get; set; }
        public double Weight { get; set; }
    
        public virtual Process Process { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductionHistory> ProductionHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilitiesHistory> FacilitiesHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilitiesPower> FacilitiesPowers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Worker> Workers { get; set; }
    }
}