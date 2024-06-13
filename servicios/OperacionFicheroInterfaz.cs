using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba4EvaRecup.servicios
{
    /// <summary>
    /// Contiene la cabezera de los metodos del fichero
    /// msm - 120624
    /// </summary>
    internal interface OperacionFicheroInterfaz
    {
        /// <summary>
        /// Escribe en el fichero de los vehiculos que han pasado
        /// msm - 130624
        /// </summary>
        public void escribirFichero();

        /// <summary>
        /// Escribe en el fichero log
        /// msm - 130624
        /// </summary>
        /// <param name="texto"></param>
        public void escribirFicheroLog(string texto);

        /// <summary>
        /// Recarga los registros anteriores de los vehiculos
        /// msm - 130624
        /// </summary>
        public void cargaInicial();
    }
}
