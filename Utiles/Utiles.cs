using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace prueba4EvaRecup.Utiles
{
    /// <summary>
    /// Metodos utiles para el desarrollo del programa
    /// msm - 120624
    /// </summary>
    internal class Utiles
    {
        public static long idGenerator()
        {
            int tamanoLista = Program.listaVehiculos.Count() -1;
            long idNuevo = 0;

            if (Program.listaVehiculos.Count > 0)   
            {
                idNuevo = Program.listaVehiculos[tamanoLista].Id + 1;
            }
            else
            {
                idNuevo = 1;
            }
            return idNuevo;
        } 

        public static string nombreFicheroVehiculos()
        {
            DateTime fechaHoy = DateTime.Now;
            string fechaHoyString = fechaHoy.ToString("ddMMyyyy");
            string nombreFichero = string.Concat("C:\\Users\\Usuario\\Desktop\\ARCHIVOS\\", fechaHoyString, "-entidad.txt");
            
            return nombreFichero;
        }

        public static string nombreFicheroLog()
        {
            DateTime fechaHoy = DateTime.Now;
            string fechaHoyString = fechaHoy.ToString("ddMMyyyy");
            string nombreFichero = string.Concat("C:\\Users\\Usuario\\Desktop\\ARCHIVOS\\fichero-log", fechaHoyString, ".txt");

            return nombreFichero;
        }
    }
}
