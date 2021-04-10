using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using presentacion.base_de_datos;


namespace presentacion.Clases
{
   public class ValidarDatosGuardar
    {
        public int? _IDreligion { get; set; }
        public int _IDdomicilio { get; set; }
        public int _IDtratamiento { get; set; }
        public int _IDmedico_clinica { get; set; }
        public int? _IDmedicoSolicita { get; set; }
        public int _IDseguroPaciente { get; set; }
        public int? _IDdireccionFac { get; set; }


        sistema_pacientesEntities db = new sistema_pacientesEntities();
        public bool GuardarDatos(ma_religiones religion,ma_domicilios domicilio,ma_tratamientos tratamiento,ma_medicos medico_clinica, ma_medicos medico_Solicita,ma_seguros_pacientes seguroPaciente,string Seguro,ma_direccion_facturas direccionFac)
        {
            int idDomicilio = 0;
            int IdMedicoClinica = 0;
            int IdMedicoSolicita = 0;
            int IdSeguroPaciente = 0;
            int? IdDireccion_fac = 0;
            int idTratamiento = 0;

            try
            {

             
             int? idReligion = guardarReligion(religion);
             idDomicilio = Guardardomicilio(domicilio);
             idTratamiento = BuscarTratamiento(tratamiento);
             IdMedicoClinica = GuardarMedicoClinica(medico_clinica);
             IdMedicoSolicita = GuardarMedicoSolicita(medico_Solicita);
             IdSeguroPaciente = GuardarSeguroPacientes(seguroPaciente,Seguro);
             IdDireccion_fac = GuardarDireccionRef(direccionFac);

                if (idReligion > 0 && idDomicilio > 0 && idTratamiento > 0 && IdMedicoClinica > 0 && IdMedicoSolicita > 0 && IdSeguroPaciente > 0 && IdDireccion_fac > 0)
                {
                    _IDreligion = idReligion;
                    _IDdomicilio = idDomicilio;
                    _IDmedico_clinica = IdMedicoClinica;
                    _IDmedicoSolicita = IdMedicoSolicita;
                    _IDseguroPaciente = IdSeguroPaciente;
                    _IDdireccionFac = IdDireccion_fac;
                    _IDtratamiento = idTratamiento;
                    return true;
                }
                  
                else
                {
                    borrarDatosIngresados(idDomicilio,IdMedicoClinica,IdMedicoSolicita,IdSeguroPaciente,IdDireccion_fac);
                    return false;
                }
                   

            }
            catch (Exception ex)
            {
                borrarDatosIngresados(idDomicilio, IdMedicoClinica, IdMedicoSolicita, IdSeguroPaciente, IdDireccion_fac);
                throw ex;
            }            

        }

       public void borrarDatosIngresados(int idDomicilio, int idMedicoClinica, int? idMedicoSolicita, int idSeguroPaciente, int? idDireccion_fac)
        {
            try
            {
                if (idDomicilio > 0)
                {
                    var domicilio = db.ma_domicilios.Where(x => x.id_domicilio == idDomicilio);
                    db.ma_domicilios.RemoveRange(domicilio);
                }
                if (idMedicoClinica > 0)
                {
                    var medicoClinica = db.ma_medicos_clinica.Where(x => x.id_medico_clinica == idMedicoClinica);
                    db.ma_medicos_clinica.RemoveRange(medicoClinica);
                    int idMedico = medicoClinica.FirstOrDefault().id_medico;


                    var medico = db.ma_medicos.Where(x => x.id_medico == 0);
                    db.ma_medicos.RemoveRange(medico);
                }

                if (idMedicoSolicita > 0)
                {
                    var medicoSolicita = db.ma_medicos_solicita_ingresos.Where(x => x.id_medico_solicita == idMedicoSolicita);
                    db.ma_medicos_solicita_ingresos.RemoveRange(medicoSolicita);
                    int idMedico = medicoSolicita.FirstOrDefault().id_medico;

                    var medico = db.ma_medicos.Where(x => x.id_medico == idMedico);
                    db.ma_medicos.RemoveRange(medico);
                }

                if (idSeguroPaciente > 0)
                {
                    var SeguroPaciente = db.ma_seguros_pacientes.Where(x => x.id_seguro_paciente == idSeguroPaciente);
                    db.ma_seguros_pacientes.RemoveRange(SeguroPaciente);
                }

                if (idDireccion_fac > 0)
                {
                    var Direccion_fac = db.ma_direccion_facturas.Where(x => x.id_direccion_fac == idDireccion_fac);
                    db.ma_direccion_facturas.RemoveRange(Direccion_fac);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                
            }
            


        }

        private int guardarReligion(ma_religiones religion)
        {
            try
            {
                var busqueda = db.ma_religiones.Where(x => x.religion == religion.religion).Select(x => x);

                if (busqueda.Any())
                {
                    return busqueda.FirstOrDefault().id_religion;
                }
                else
                {
                    db.ma_religiones.Add(religion);
                    db.SaveChanges();
                    return religion.id_religion;

                }
            }
            catch (Exception ex)
            {
            throw ex;
            }   

      

            
        }

        private int Guardardomicilio(ma_domicilios domicilio)
        {
            try
            {
                db.ma_domicilios.Add(domicilio);
                //List<ma_otros_domicilios> otroDomicilio = domicilio.ma_otros_domicilios.ToList();
                //if (otroDomicilio.Count > 0)
                //{
                //    db.ma_otros_domicilios.Add(otroDomicilio.FirstOrDefault());
                //}
                db.SaveChanges();
                return domicilio.id_domicilio;
            }
            catch (Exception ex)
            {
                throw ex;

            }
         

        }

        private int BuscarTratamiento(ma_tratamientos tratamiento)
        {
            try
            {
                ma_tratamientos busqueda = db.ma_tratamientos.Where(x => x.tratamiento == tratamiento.tratamiento).Select(x=>x).FirstOrDefault();
                return busqueda.id_tratamiento;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private int GuardarMedicoClinica(ma_medicos medico)
        {
            try
            {
                ma_medicos_clinica medicoClinica = new ma_medicos_clinica();
                db.ma_medicos.Add(medico);
                medicoClinica.id_medico = medico.id_medico;
                db.ma_medicos_clinica.Add(medicoClinica);
               db.SaveChanges();
                return medicoClinica.id_medico_clinica;
            }
            catch (Exception ex)
            {               
                throw ex;
            }
           
           
        }

        private int GuardarMedicoSolicita(ma_medicos medico)
        {
            try
            {
                ma_medicos_solicita_ingresos medicoSolicita = new ma_medicos_solicita_ingresos();
                db.ma_medicos.Add(medico);
                medicoSolicita.id_medico = medico.id_medico;
                db.ma_medicos_solicita_ingresos.Add(medicoSolicita);
                db.SaveChanges();
                return medicoSolicita.id_medico_solicita;
            }
            catch (Exception ex)
            {               
                throw ex;
            }


        }

        private int GuardarSeguroPacientes(ma_seguros_pacientes SeguroPaciente,string seguro)
        {
            try
            {

                var busqueda = db.ma_seguros.Where(x => x.seguro == seguro);

                if (busqueda.Any())
                {
                    SeguroPaciente.id_seguro = busqueda.FirstOrDefault().id_seguro;
                }
                else
                {
                    ma_seguros segu = new ma_seguros();
                    segu.seguro = seguro;
                    db.ma_seguros.Add(segu);
                    SeguroPaciente.id_seguro = segu.id_seguro;
                }
               
                db.ma_seguros_pacientes.Add(SeguroPaciente);

                //if (SeguroPaciente.ma_seguro_pacientes_excluidos.Count()> 0)
                //{
                //    ma_seguro_pacientes_excluidos SeguroPacienteExcluido = new ma_seguro_pacientes_excluidos();
                //    SeguroPacienteExcluido = SeguroPaciente.ma_seguro_pacientes_excluidos.FirstOrDefault();
                //    db.ma_seguro_pacientes_excluidos.Add(SeguroPacienteExcluido);
                //}
                db.SaveChanges();

                return SeguroPaciente.id_seguro_paciente;

            }
            catch (Exception ex)
            {               
                throw ex; 
            }


        }

        private int? GuardarDireccionRef(ma_direccion_facturas direccionFac)
        {
            try
            {
                db.ma_direccion_facturas.Add(direccionFac);
                db.SaveChanges();
                return direccionFac.id_direccion_fac;

            }
            catch (Exception ex)
            {               
                throw ex;
            }


        }


    }


}
