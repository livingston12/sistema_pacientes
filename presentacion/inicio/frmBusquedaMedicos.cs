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
    public partial class frmBusquedaMedicos : Form
    {
        public frmBusquedaMedicos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        sistema_pacientesEntities db = new sistema_pacientesEntities();

        private void btnIngresarPaciente_Click(object sender, EventArgs e)
        {
            var medico = (from a in db.ma_medicos
                           join b in db.ma_medicos_clinica on a.id_medico equals b.id_medico
                          where a.nombre == txtNombre_medico.Text
                           select new
                           {
                               a.nombre,
                               a.telefono,
                               a.localidad,
                               a.calle
                           }).ToList();       
           

            if (medico.Any())            
                    dataGridView1.DataSource = medico.ToList();             
           else                
                    MessageBox.Show("Este medico no existe !!", "Medico no existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
              
          
        }

        private void frmBusquedaMedicos_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void llenarGrid()
        {
            var medicos = (from a in db.ma_medicos
                          join b in db.ma_medicos_clinica on a.id_medico equals b.id_medico
                          select new {
                              a.nombre,
                              a.telefono,
                              a.localidad,
                              a.calle
                          }).ToList();
                          


            if (medicos.Any())
            { 
            dataGridView1.DataSource = medicos;
              

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox4.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
            llenarGrid();
        }
    }
}
