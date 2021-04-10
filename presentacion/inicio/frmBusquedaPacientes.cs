using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using presentacion.base_de_datos;

namespace presentacion.inicio
{
    public partial class frmBusquedaPacientes : Form
    {
        public frmBusquedaPacientes()
        {
            InitializeComponent();
        }
        sistema_pacientesEntities db = new sistema_pacientesEntities();
        private void btnIngresarPaciente_Click(object sender, EventArgs e)
        {
            var pacientes = (from a in db.ma_pacientes
                            join ingre in db.ma_ingresos on a.id_paciente equals ingre.id_paciente
                            join tip_ingre in db.ma_tipos_ingresos on ingre.id_tipo_ingreso equals tip_ingre.id_tipo_ingreso
                            join reli in db.ma_religiones on a.id_religion equals reli.id_religion
                            join domi in db.ma_domicilios on a.id_domicilio equals domi.id_domicilio
                            join trata in db.ma_tratamientos on a.id_tratamiento equals trata.id_tratamiento
                            join medcli in db.ma_medicos_clinica on a.id_medico_clinica equals medcli.id_medico_clinica
                            join medSol in db.ma_medicos_solicita_ingresos on a.id_medicos_solicita equals medSol.id_medico_solicita
                            join segPac in db.ma_seguros_pacientes on a.id_seguro_pacientes equals segPac.id_seguro_paciente
                            join tipSeg in db.ma_tipos_seguro on segPac.id_tipo_seguro equals tipSeg.id_tipo_seguro
                            join seg in db.ma_seguros on segPac.id_seguro equals seg.id_seguro
                            join cob in db.ma_coberturas on segPac.id_cobertura equals cob.id_cobertura
                             where a.nombre + a.apellido == txtNombre_medico.Text || a.nombre == txtNombre_medico.Text || a.apellido == txtNombre_medico.Text || a.apellido_solte == txtNombre_medico.Text || a.num_seguridad_social == txtNombre_medico.Text || a.num_tarjeta == txtNombre_medico.Text || segPac.num_poliza == txtNombre_medico.Text
                             select new {
                              a.nombre,
                              a.apellido,
                              ingre.fecha_ingreso,
                              ingre.hora_ingreso,
                              Tipo_Ingreso = tip_ingre.tipo,                            
                              a.num_seguridad_social,
                              a.num_tarjeta,
                              a.apellido_solte,
                              a.fecha_nacimiento,
                              a.sexo,
                              a.lugar_nacimiento,
                             a.profesion,
                             a.idioma,
                             a.nacionalidad,                            
                             a.estado_civil,
                             reli.religion,
                             direccion = domi.calle + " EN "+ domi.localidad,
                             domi.telefono,
                             domi.movil,
                             domi.pais,
                             domi.correo,
                             trata.tratamiento,
                             segPac.num_poliza,
                             tipSeg.tipo_seguro,
                             seg.seguro

                          }).ToList();

            dataGridView1.DataSource = pacientes;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarFormulario();

        }

        private void limpiarFormulario()
        {
            foreach (Control item in panel2.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }

            llenarGrid();
        }

        private void llenarGrid()
        {
            var pacientes = (from a in db.ma_pacientes
                             join ingre in db.ma_ingresos on a.id_paciente equals ingre.id_paciente
                             join tip_ingre in db.ma_tipos_ingresos on ingre.id_tipo_ingreso equals tip_ingre.id_tipo_ingreso
                             join reli in db.ma_religiones on a.id_religion equals reli.id_religion
                             join domi in db.ma_domicilios on a.id_domicilio equals domi.id_domicilio
                             join trata in db.ma_tratamientos on a.id_tratamiento equals trata.id_tratamiento
                             join medcli in db.ma_medicos_clinica on a.id_medico_clinica equals medcli.id_medico_clinica
                             join medSol in db.ma_medicos_solicita_ingresos on a.id_medicos_solicita equals medSol.id_medico_solicita
                             join segPac in db.ma_seguros_pacientes on a.id_seguro_pacientes equals segPac.id_seguro_paciente
                             join tipSeg in db.ma_tipos_seguro on segPac.id_tipo_seguro equals tipSeg.id_tipo_seguro
                             join seg in db.ma_seguros on segPac.id_seguro equals seg.id_seguro
                             join cob in db.ma_coberturas on segPac.id_cobertura equals cob.id_cobertura                            
                             select new
                             {
                                 a.nombre,
                                 a.apellido,
                                 ingre.fecha_ingreso,
                                 ingre.hora_ingreso,
                                 Tipo_Ingreso = tip_ingre.tipo,
                                 a.num_seguridad_social,
                                 a.num_tarjeta,
                                 a.apellido_solte,
                                 a.fecha_nacimiento,
                                 a.sexo,
                                 a.lugar_nacimiento,
                                 sexo_Paciente = a.sexo,
                                 lugarNacimiento = a.lugar_nacimiento,
                                 a.profesion,
                                 a.idioma,
                                 a.nacionalidad,
                                 a.estado_civil,
                                 reli.religion,
                                 direccion = domi.calle + " EN " + domi.localidad,
                                 domi.telefono,
                                 domi.movil,
                                 domi.pais,
                                 domi.correo,
                                 trata.tratamiento,
                                 segPac.num_poliza,
                                 tipSeg.tipo_seguro,
                                 seg.seguro

                             }).ToList();

            dataGridView1.DataSource = pacientes;
        }

        private void frmBusquedaPacientes_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }
    }
}
