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
    
    public partial class EMPDolz
    {
        public int ID_EMPDolz { get; set; }
        public int EMP_ID { get; set; }
        public int Dolz_ID { get; set; }
    
        public virtual Dolz Dolz { get; set; }
        public virtual EMP EMP { get; set; }
    }
}