//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarPoolingTecWebApi22019.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VIAJE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VIAJE()
        {
            this.VIAJESXUSUARIOs = new HashSet<VIAJESXUSUARIO>();
        }
    
        public int VI_ID { get; set; }
        public int VI_choferID { get; set; }
        public string VI_fecha { get; set; }
        public Nullable<int> VI_parqueo { get; set; }
        public string VI_placaCarro { get; set; }
    
        public virtual CARRO CARRO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VIAJESXUSUARIO> VIAJESXUSUARIOs { get; set; }
    }
}
