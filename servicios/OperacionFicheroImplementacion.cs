using prueba4EvaRecup.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba4EvaRecup.servicios
{
    /// <summary>
    /// Contiene la logica de los metodos del servicio ficheros
    /// msm - 120624
    /// </summary>
    internal class OperacionFicheroImplementacion : OperacionFicheroInterfaz
    {
        public void escribirFichero()
        {
            StreamWriter sw;

            try
            {
                using (sw = new StreamWriter(Program.rutaFichero))
                {
                    foreach (Vehiculo veh in Program.listaVehiculos)
                    {
                       
                        sw.WriteLine(veh.ToString());
     
                    }

                }
            }catch (IOException ex)
            {
                Program.texto = ex.Message;
                escribirFicheroLog(Program.texto);
            }
            
        }

        public void escribirFicheroLog(string texto)
        {
            StreamWriter sw;

            try
            {
                using (sw = new StreamWriter(Program.rutaFicheroLog, true))
                {
                    sw.Write(string.Concat(texto, "\n"));

                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ha ocurrido un error, espere un momento");
            }

        }

        public void cargaInicial()
        {
            if (File.Exists(Program.rutaFichero))
            {
                string ruta = Program.rutaFichero;
                StreamReader sr = new StreamReader(Program.rutaFichero);
                string linea;
                try
                {
                    while ((linea = sr.ReadLine()) != null)
                    {
                        Vehiculo vehiculoNuevo = new Vehiculo();
                        string[] campos = linea.Split(";");
                        vehiculoNuevo.Id = Utiles.Utiles.idGenerator();
                        vehiculoNuevo.Matricula = campos[0].Trim();
                        vehiculoNuevo.TipoVehiculo = campos[1].Trim();
                        vehiculoNuevo.ZonaDestino = campos[2].Trim();
                        if (campos[3] == "True")
                        {
                            vehiculoNuevo.Mercancia = true;
                        }
                        else
                        {
                            vehiculoNuevo.Mercancia = false;
                        }
                        vehiculoNuevo.FechaPaso = Convert.ToDateTime(campos[4]);

                        Program.listaVehiculos.Add(vehiculoNuevo);
                    }
                    
                }
                catch (Exception e)
                {
                    Program.texto = e.Message;
                    escribirFicheroLog(Program.texto);
                }
                finally
                {
                    sr.Close();
                }
            }
            
        }
    }
}
