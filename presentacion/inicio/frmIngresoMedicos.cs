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
    public partial class frmIngresoMedicos : Form
    {
        public frmIngresoMedicos()
        {
            InitializeComponent();
        }
        sistema_pacientesEntities db = new sistema_pacientesEntities();
        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresarPaciente_Click(object sender, EventArgs e)
        {
            ma_medicos medico = new ma_medicos();
            medico.nombre = txtNombre_medico.Text;
            medico.telefono = txtTel_medico.Text;
            medico.calle = txtcalle_Medico.Text;
            medico.localidad = txtLocalidad_Medico.Text;
            db.ma_medicos.Add(medico);
            db.SaveChanges();
            ma_medicos_clinica medidico_Clinica = new ma_medicos_clinica();
            medidico_Clinica.id_medico = medico.id_medico;
            db.ma_medicos_clinica.Add(medidico_Clinica);
            db.SaveChanges();
            MessageBox.Show("Datos ingresados correctamente !! ", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarFormulario();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void limpiarFormulario()
        {
            foreach (Control item in groupBox4.Controls)
            {
                if (!(item is Label))
                    item.Text = "";
            }
        }
    }
}
