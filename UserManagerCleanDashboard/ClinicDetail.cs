//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Medical
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClinicDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClinicDetail()
        {
            this.Reserves = new HashSet<Reserve>();
        }
    
        public int ClinicDetailID { get; set; }
        public Nullable<int> DoctorID { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public int PeriodID { get; set; }
        public Nullable<int> Online { get; set; }
        public Nullable<int> RoomID { get; set; }
        public Nullable<System.DateTime> ClinicDate { get; set; }
        public Nullable<int> LimitNum { get; set; }
    
        public virtual ClinicRoom ClinicRoom { get; set; }
        public virtual Department Department { get; set; }
        public virtual Period Period { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reserve> Reserves { get; set; }
    }
}