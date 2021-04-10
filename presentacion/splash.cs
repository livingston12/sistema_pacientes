using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        int contador = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = contador;
            lblContador.Text = contador.ToString();
            contador += 1;

            if (contador == 100)
            {
                timer1.Stop();                
                this.Close();
                
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
