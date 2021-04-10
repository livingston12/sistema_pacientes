using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using presentacion.Clases;
using presentacion.base_de_datos;


namespace presentacion.inicio
{
    public partial class frmIngresoPacientes : Form
    {
        public frmIngresoPacientes()
        {
            InitializeComponent();
        }

        sistema_pacientesEntities db = new sistema_pacientesEntities();
        private void tabPage1_Click(object sender, EventArgs e)
        {


        }
        public Byte[] byteFoto { get; set; }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarDocumento_Click(object sender, EventArgs e)
        {
            buscarImagen();
        }

        private void buscarImagen()
        {
            byte[] BytesImg;
            FileDialog.Filter = "Image Files(*.jpeg,*.jpg,*.gif,*.png)|*.jpeg;*.jpg;*.gif;*.png";
            FileDialog.FilterIndex = 1;
            DialogResult dgResult = FileDialog.ShowDialog();

            if (dgResult == DialogResult.OK)
            {
                try
                {
                    try
                    {
                        FileStream fsRead = new FileStream(FileDialog.FileName, FileMode.Open);
                        BytesImg = new Byte[fsRead.Length];
                        fsRead.Read(BytesImg, 0, BytesImg.Length);
                        fsRead.Close();
                        byteFoto = BytesImg;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al ingresar la imagen", "ERROR DE IMAGEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    imgFoto.Image = Image.FromFile(FileDialog.FileName);
                    txtDocumento.Text = FileDialog.FileName;
                    
                }

                
                catch
                {
                }
            }
           
        }

        private void frmIngresoPacientes_Load(object sender, EventArgs e)
        {
            cbEstadoCivil.SelectedIndex = 0;
            llenarComboxes();
            contarPacientes();
        }

        public void contarPacientes()
        {
            int valor = db.ma_pacientes.Select(x => x).Count();
            lblNumeroPacientes.Text = (valor + 1).ToString();
        }
        private void llenarComboxes()
        {
            llenarTipoIngreso();            
            llenarParientes();
            llenarTipoSeguro();
            llenarCoberturaSeguro();
            llenarTratamiento();
            llenarTipoSeguroExcluido();
            llenarCausas();
            
        }

        private void llenarCausas()
        {
            General g = new General();
            var busqueda = db.ma_causas.Select(x => x).ToList();
            DataTable dt = Converter<ma_causas>.Convert(busqueda);
            g.llenarComboBox(dt, cbCausas, "id_causa", "causa");
        }

        private void llenarTipoSeguroExcluido()
        {
            General g = new General();
            var busqueda = db.ma_tipos_seguros_excluidos.Select(x => x).ToList();
            DataTable dt = Converter<ma_tipos_seguros_excluidos>.Convert(busqueda);
            g.llenarComboBox(dt, cbTipoSeguroExcluido,"id_tipo_exclusion","tipo_exclusion");
        }

        private void llenarTratamiento()
        {
            General g = new General();
            var busqueda = db.ma_tratamientos.Select(x => x).ToList();
            DataTable dt = Converter<ma_tratamientos>.Convert(busqueda);
            g.llenarComboBox(dt, cbTratamiento, "id_tratamiento", "tratamiento");
        }

        private void llenarCoberturaSeguro()
        {
            General g = new General();
            var busqueda = db.ma_coberturas.Select(x => x).ToList();
            DataTable dt = Converter<ma_coberturas>.Convert(busqueda);
            g.llenarComboBox(dt, cbCobertura, "id_cobertura", "cobertura");
        }

        private void llenarTipoSeguro()
        {
            General g = new General();
            var busqueda = db.ma_tipos_seguro.Select(x => x).ToList();
            DataTable dt = Converter<ma_tipos_seguro>.Convert(busqueda);
            g.llenarComboBox(dt, cbTipoSeguro, "id_tipo_seguro", "tipo_seguro");
        }

        private void llenarParientes()
        {
            General g = new General();
            var busqueda = db.ma_tipo_pariente.Select(x => x).ToList();
            DataTable dt = Converter<ma_tipo_pariente>.Convert(busqueda);
            g.llenarComboBox(dt, cbParienteRef, "id_tipo_pariente", "tipo_pariente");
        }    

        private void llenarTipoIngreso()
        {
            General g = new General();
            var busqueda = db.ma_tipos_ingresos.Select(x => x).ToList();
            DataTable dt = Converter<ma_tipos_ingresos>.Convert(busqueda);
            g.llenarComboBox(dt, cbTipo_ingreso, "id_tipo_ingreso", "tipo");
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarFormularioCompleto();

        }

        private void tabGeneral_Click(object sender, EventArgs e)
        {

        }

        private void ckOtroDomicilio_CheckedChanged(object sender, EventArgs e)
        {
            if (ckOtroDomicilio.Checked)
                pnOtroDomicilio.Visible = true;
            else
                pnOtroDomicilio.Visible = false;

        }

        private void cbTipoSeguro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valor = cbTipoSeguro.SelectedIndex;
            if (valor == 0)
            {
                pnPoliza.Visible = false;
                pnSeguroAccidente.Visible = false;
            }
            else if (valor == 1)
            {
                pnPoliza.Visible = true;
                pnSeguroAccidente.Visible = false;
            }
            else
            {
                pnPoliza.Visible = true;
                pnSeguroAccidente.Visible = true;
            }

        }

        private void ckSi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSi.Checked)
            {
                lblClinica.Visible = true;
                txtClinica.Visible = true;
                ckNo.Checked = false;
            }
            else
                ckNo.Checked = true;
        }

        private void ckNo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNo.Checked == false) ckSi.Checked = true;
            else
            {
                lblClinica.Visible = false;
                txtClinica.Visible = false;
                ckSi.Checked = false;
            }
        }

        private void ckOtra_CheckedChanged(object sender, EventArgs e)
        {
            if (ckOtra.Checked)
            {
                txtOtraReligion.Visible = true;
                ckProtestante.Checked = false;               
                ckCatolica.Checked = false;
            }
            else
            {
                txtOtraReligion.Visible = false;
            }
        }

        private void ckProtestante_CheckedChanged(object sender, EventArgs e)
        {
            if (ckProtestante.Checked)
            {
                ckCatolica.Checked = false;
                ckOtra.Checked = false;
                txtOtraReligion.Visible = false;
            }
        }

        private void ckCatolica_CheckedChanged(object sender, EventArgs e)
        {
            if (ckCatolica.Checked)
            {
                ckProtestante.Checked = false;
                ckOtra.Checked = false;
                txtOtraReligion.Visible = false;
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            ValidarDatosGuardar validar = new ValidarDatosGuardar();
            try
            {
                
                db.Database.BeginTransaction();

                ma_religiones religion = new ma_religiones();
                ma_domicilios domicilio = new ma_domicilios();
                ma_otros_domicilios otro_domi = new ma_otros_domicilios();
                ma_tratamientos trata = new ma_tratamientos();
                ma_medicos medicoCLinica = new ma_medicos();
                ma_medicos medicoRef = new ma_medicos();
                ma_seguros_pacientes Seguropacientes = new ma_seguros_pacientes();
                ma_direccion_facturas direccion = new ma_direccion_facturas();

                foreach (Control item  in pnReligion.Controls)
                {
                    CheckBox ck = item  as CheckBox;
                    if (item is CheckBox && ck.Checked == true && item.Text != "Otra")
                    {
                        religion.religion = item.Text.ToString();
                    }
                    else if (item is CheckBox && ck.Checked == true && item.Text == "Otra")
                    {
                        religion.religion = txtOtraReligion.Text;
                    }
                }

                domicilio.calle = TxtCalle_domicilio.Text;
                domicilio.localidad = txtLocalidad_Domicilio.Text;
                domicilio.telefono = txtTelefono_Domicilio.Text;
                domicilio.movil = TxtMovil_Domicilio.Text;
                domicilio.pais = txtPais_Domicilio.Text;
                domicilio.correo = txtCorreo_Domicilio.Text;               

                trata.tratamiento = cbTratamiento.Text;

                medicoCLinica.calle = txtcalle_Medico.Text;
                medicoCLinica.nombre = txtNombre_medico.Text;
                medicoCLinica.telefono = txtTel_medico.Text;
                medicoCLinica.localidad = txtLocalidad_Medico.Text;

                medicoRef.calle = txtCalle_rfMedico.Text;
                medicoRef.nombre = txtNombre_rfMedico.Text;
                medicoRef.telefono = txtTel_rfMedico.Text;
                medicoRef.localidad = txtLocalidad_rfMedico.Text;
               
                Seguropacientes.num_poliza = txtNumPoliza.Text;
                Seguropacientes.id_tipo_seguro = int.Parse(cbTipoSeguro.SelectedValue.ToString());
                Seguropacientes.id_cobertura = int.Parse(cbCobertura.SelectedValue.ToString());

                direccion.nombre = txtNombreDire.Text;
                direccion.apellidos = txtApellidoDire.Text;
                direccion.calle = txtCalleDire.Text;
                direccion.localidad = txtCalleDire.Text;


                if (validar.GuardarDatos(religion,domicilio,trata,medicoCLinica,medicoRef,Seguropacientes,txtNomSeguro.Text,direccion))
                {
                    
                    ma_pacientes paciente = new ma_pacientes();                    
                    paciente.num_seguridad_social = txtSeguridadSocial.Text;
                    paciente.num_tarjeta = txtNumAsegurado.Text;
                    paciente.nombre = txtNombre_Generales.Text;
                    paciente.apellido = txtApellido_generales.Text;
                    paciente.apellido_solte = txtApellido_soltero_Generales.Text;
                    //paciente.fecha_nacimiento = DateTime.Now;
                    paciente.fecha_nacimiento = dtFechaNaci.Value;
                    paciente.lugar_nacimiento = txtLugarOrigen_generales.Text;
                    paciente.profesion = txtprofesion.Text;
                    paciente.idioma = txtIdioma_generales.Text;
                    paciente.nacionalidad = txtNacionalida_registro.Text;
                    paciente.permiso_residencia = "";
                    paciente.estado_civil = cbEstadoCivil.SelectedItem.ToString();
                    paciente.id_religion = validar._IDreligion;
                    paciente.id_domicilio = validar._IDdomicilio;
                    paciente.id_medico_clinica = validar._IDmedico_clinica;
                    paciente.id_medicos_solicita = validar._IDmedicoSolicita;                   
                    paciente.id_seguro_pacientes = validar._IDseguroPaciente;
                    paciente.id_direccion_fac = validar._IDdireccionFac;
                    paciente.id_tratamiento = validar._IDtratamiento;

                    foreach (Control item in pnSexo.Controls)
                    {
                        RadioButton ck = item as RadioButton;
                        if (item is RadioButton && ck.Checked)
                        {
                            paciente.sexo = ck.Text;
                        }
                    
                    }

                    db.ma_pacientes.Add(paciente);
                    db.SaveChanges();
                    db.Database.CurrentTransaction.Commit();


                    int pacienteID = paciente.id_paciente;

                    ma_ingresos ingreso = new ma_ingresos();                    
                    ingreso.id_paciente = pacienteID;
                    ingreso.id_tipo_ingreso = int.Parse(cbTipo_ingreso.SelectedValue.ToString());
                    ingreso.solicitud_ingreso = txtSolicitudIngreso.Text;
                    ingreso.fecha_ingreso = DateTime.Parse(dtFecha.Text);
                    ingreso.hora_ingreso = TimeSpan.Parse(txtHora.Text);
                    db.ma_ingresos.Add(ingreso);

                    if (byteFoto != null)
                    {
                        ingreso.documento_identidad = byteFoto;
                    }                    

                    if (ckOtroDomicilio.Checked)
                    {
                        ma_domicilios domicilio2 = new ma_domicilios();
                        domicilio2.calle = txtCalle_otro_Domicilio.Text;
                        domicilio2.localidad = txtLocalidad_otro_Domicilio.Text;
                        domicilio2.telefono = txtTel_Otro_domicilio.Text;
                        domicilio2.movil = txtMovil_otro_domicilio.Text;
                        domicilio2.pais = txtPais_otro_Domicilio.Text;
                        domicilio2.correo = txtCorreo_otro_Domicilio.Text;
                        db.ma_domicilios.Add(domicilio2);
                        db.SaveChanges();

                        otro_domi.id_domilicio = domicilio2.id_domicilio;
                        otro_domi.id_paciente = pacienteID;
                        otro_domi.domiciliado = txtDomiciliado.Text;
                        db.ma_otros_domicilios.Add(otro_domi);
                        

                    }
                   
                    if (cbTipoSeguro.SelectedValue.ToString() == "3")
                    {
                        ma_seguro_pacientes_excluidos pacienteEx = new ma_seguro_pacientes_excluidos();
                        pacienteEx.id_seguro_paciente = validar._IDseguroPaciente;
                        pacienteEx.id_tipo_exclusion =  int.Parse(cbTipoSeguroExcluido.SelectedValue.ToString());
                        pacienteEx.asegurador = txtAsegurador.Text;
                        pacienteEx.num_accidente = txtNumAccidente.Text;
                        pacienteEx.num_empresa = txtEmpresa.Text;
                        pacienteEx.lugar_accidente = txtLugarAccidente.Text;
                        pacienteEx.fecha_accidente = DateTime.Parse(dtFechaAccidente.Text);
                        pacienteEx.num_disposicion_invalidez = txtDisposicionInvalidez.Text;
                        db.ma_seguro_pacientes_excluidos.Add(pacienteEx);
                    }                    

                    ma_causas_pacientes1 causaPaciente = new ma_causas_pacientes1();
                    causaPaciente.id_causa = int.Parse(cbCausas.SelectedValue.ToString());
                    causaPaciente.id_paciente = pacienteID;
                    db.ma_causas_pacientes1Set.Add(causaPaciente);

                    ma_parientes_pacientes pariente = new ma_parientes_pacientes();
                    pariente.id_paciente = pacienteID;
                    pariente.tipo_pariente =  int.Parse(cbParienteRef.SelectedValue.ToString());
                    pariente.relacion = cbParienteRef.Text;
                    pariente.Nombre = txtNombreRef.Text;
                    pariente.apellidos = txtApellidoRef.Text;
                    pariente.telefono = txtApellidoRef.Text;
                    pariente.calle = txtCalleRef.Text;
                    pariente.localidad = txtLocalidadRef.Text;
                    pariente.pais = txtPaisRef.Text;
                    db.ma_parientes_pacientes.Add(pariente);

                    db.SaveChanges();
                    MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE !! ", "DATOS GUARDADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarFormularioCompleto();                   
                    
                    
                }
                else
                {
                    validar.borrarDatosIngresados(validar._IDdomicilio, validar._IDmedico_clinica, validar._IDmedicoSolicita, validar._IDseguroPaciente, validar._IDdireccionFac);
                    db.Database.CurrentTransaction.Rollback();
                    MessageBox.Show("REVISE TODOS SUS DATOS","DATOS INCOMPLETOS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
              
                //validar.borrarDatosIngresados(validar._IDdomicilio, validar._IDmedico_clinica, validar._IDmedicoSolicita, validar._IDseguroPaciente, validar._IDdireccionFac);
                
                MessageBox.Show("ERROR: " + ex.Message);

            }

        }

        private void limpiarFormularioCompleto()
        {
            foreach (Control tabs in tbGenral.Controls)
            {

                foreach (Control tabsItem in tabs.Controls)
                {
                   
                    if (tabsItem is TextBox)
                        tabsItem.Text = "";
                    if (tabsItem is MaskedTextBox && tabsItem.Name != "txtHora")
                        tabsItem.Text = "";

                    foreach (Control tabsGroup in tabsItem.Controls)
                    {
                        if(tabsGroup is GroupBox)
                        {
                            foreach (Control item in tabsGroup.Controls)
                            {
                                if (item is TextBox)
                                    item.Text = "";
                                if (item is MaskedTextBox)
                                    item.Text = "";
                            }
                        }

                    }
                }
                




            }

         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var medico = db.ma_medicos.Where(x => x.nombre == TxtBusqueda.Text);

            if (medico.Any())
            {
                txtNombre_medico.Text = medico.FirstOrDefault().nombre;
                txtTel_medico.Text = medico.FirstOrDefault().telefono;
                txtLocalidad_Medico.Text = medico.FirstOrDefault().localidad;
                txtcalle_Medico.Text = medico.FirstOrDefault().calle;
            }
            else
                MessageBox.Show("Este medico no existe !!", "Medico no existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
