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
    
    public partial class ma_ingresos
    {
        public int id_ingreso { get; set; }
        public int id_paciente { get; set; }
        public int id_tipo_ingreso { get; set; }
        public string solicitud_ingreso { get; set; }
        public System.DateTime fecha_ingreso { get; set; }
        public Nullable<System.TimeSpan> hora_ingreso { get; set; }
        public byte[] documento_identidad { get; set; }
    
        public virtual ma_pacientes ma_pacientes { get; set; }
        public virtual ma_tipos_ingresos ma_tipos_ingresos { get; set; }
    }
}