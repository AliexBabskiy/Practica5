//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PePract5
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMP()
        {
            this.Checkk = new HashSet<Checkk>();
            this.EMPDolz = new HashSet<EMPDolz>();
        }
    
        public int ID_EMP { get; set; }
        public string SURNAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string MIDDLENAME { get; set; }
        public Nullable<int> DanVxod_ID { get; set; }
        public Nullable<int> Smena_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Checkk> Checkk { get; set; }
        public virtual DanVxod DanVxod { get; set; }
        public virtual Smena Smena { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPDolz> EMPDolz { get; set; }
    }
}
