//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace presentacion.base_de_datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class ma_tratamientos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ma_tratamientos()
        {
            this.ma_pacientes = new HashSet<ma_pacientes>();
        }
    
        public int id_tratamiento { get; set; }
        public string tratamiento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ma_pacientes> ma_pacientes { get; set; }
    }
}