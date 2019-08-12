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
    
    public partial class ErrorCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ErrorCode()
        {
            this.Barcode = new HashSet<Barcode>();
            this.DefectiveProduct = new HashSet<DefectiveProduct>();
            this.ProductionHistory = new HashSet<ProductionHistory>();
            this.ProcessDefect = new HashSet<ProcessDefect>();
        }
    
        public int ErrorCodeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int ErrorTypeId { get; set; }
        public int ErrorKindId { get; set; }
        public bool UseState { get; set; }
        public string Explanation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Barcode> Barcode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DefectiveProduct> DefectiveProduct { get; set; }
        public virtual ErrorKind ErrorKind { get; set; }
        public virtual ErrorType ErrorType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductionHistory> ProductionHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessDefect> ProcessDefect { get; set; }
    }
}