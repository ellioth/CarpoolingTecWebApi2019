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
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.AMIGOS = new HashSet<AMIGO>();
            this.AMIGOS1 = new HashSet<AMIGO>();
            this.CARROes = new HashSet<CARRO>();
            this.OBJETOS_INTERCAMBIO = new HashSet<OBJETOS_INTERCAMBIO>();
            this.TELEFONOS = new HashSet<TELEFONO>();
            this.VIAJES = new HashSet<VIAJE>();
            this.VIAJESXUSUARIOs = new HashSet<VIAJESXUSUARIO>();
            this.NOTIFICACIONES = new HashSet<NOTIFICACIONE>();
        }
    
        public int US_ID { get; set; }
        public string US_nombre { get; set; }
        public string US_apellido1 { get; set; }
        public string US_apellido2 { get; set; }
        public string US_correo { get; set; }
        public string US_rol { get; set; }
        public Nullable<int> US_estadoCuenta { get; set; }
        public Nullable<int> US_categoria { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AMIGO> AMIGOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AMIGO> AMIGOS1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARRO> CARROes { get; set; }
        public virtual CATEGORIA CATEGORIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBJETOS_INTERCAMBIO> OBJETOS_INTERCAMBIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TELEFONO> TELEFONOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VIAJE> VIAJES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VIAJESXUSUARIO> VIAJESXUSUARIOs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICACIONE> NOTIFICACIONES { get; set; }
    }
}
