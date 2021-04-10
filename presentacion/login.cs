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
using presentacion.inicio;

namespace presentacion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        sistema_pacientesEntities db = new sistema_pacientesEntities();
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            validarUsuario(txtUsuario.Text, txtPass.Text);
        }
        
        private void validarUsuario(string usuario, string pass)
        {
            var busqueda = db.ma_usuarios.Where(x => x.usuario.Equals(usuario) && x.pass.Equals(pass));
            if (busqueda.Any())
            {
                ma_usuarios usu = busqueda.FirstOrDefault();
                menu menu = new menu(usu);
                this.Hide();
                menu.ShowDialog();
            }
            else
                MessageBox.Show("Usuario y/o contraseña incorrectos !!","ERROR DE USUARIO",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
