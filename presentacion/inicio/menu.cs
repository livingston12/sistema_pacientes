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
    public partial class menu : Form
    {
        ma_usuarios currentUsuario;
        public menu(ma_usuarios usuario)
        {
            InitializeComponent();
            currentUsuario = usuario;
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void iNGRESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoPacientes pacientes = new frmIngresoPacientes();
            pacientes.ShowDialog();
        }

        private void picPacientes_Click(object sender, EventArgs e)
        {
            frmIngresoPacientes pacientes = new frmIngresoPacientes();
            pacientes.ShowDialog();
        }

        private void bUSCARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBusquedaPacientes pacientes = new frmBusquedaPacientes();
            pacientes.ShowDialog();
        }

        private void iNGRESOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmIngresoMedicos medicos = new frmIngresoMedicos();
            medicos.ShowDialog();
        }
        private void picMedicos_Click(object sender, EventArgs e)
        {
            frmIngresoMedicos medicos = new frmIngresoMedicos();
            medicos.ShowDialog();
        }

        private void bUSCARToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmBusquedaMedicos medicos = new frmBusquedaMedicos();
            medicos.ShowDialog();
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sALIRDELSISTEMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
