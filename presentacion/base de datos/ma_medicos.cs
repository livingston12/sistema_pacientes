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
    
    public partial class ma_medicos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ma_medicos()
        {
            this.ma_medicos_clinica = new HashSet<ma_medicos_clinica>();
            this.ma_medicos_solicita_ingresos = new HashSet<ma_medicos_solicita_ingresos>();
        }
    
        public int id_medico { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string calle { get; set; }
        public string localidad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ma_medicos_clinica> ma_medicos_clinica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ma_medicos_solicita_ingresos> ma_medicos_solicita_ingresos { get; set; }
    }
}