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
    
    public partial class ma_domicilios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ma_domicilios()
        {
            this.ma_pacientes = new HashSet<ma_pacientes>();
            this.ma_otros_domicilios = new HashSet<ma_otros_domicilios>();
        }
    
        public int id_domicilio { get; set; }
        public string calle { get; set; }
        public string localidad { get; set; }
        public string telefono { get; set; }
        public string movil { get; set; }
        public string pais { get; set; }
        public string correo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ma_pacientes> ma_pacientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ma_otros_domicilios> ma_otros_domicilios { get; set; }
    }
}
