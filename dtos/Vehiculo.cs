using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba4EvaRecup.dtos
{
    /// <summary>
    /// Contiene los campos y metodos de la clase alumno
    /// msm - 120624
    /// </summary>
    internal class Vehiculo
    {
        long id;
        string matricula = "aaaaa";
        string tipoVehiculo = "aaaa";
        string zonaDestino = "S";
        bool mercancia = false;
        DateTime fechaPaso = DateTime.Now;
        bool apto = false;

      

        public long Id { get => id; set => id = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string ZonaDestino { get => zonaDestino; set => zonaDestino = value; }
        public bool Mercancia { get => mercancia; set => mercancia = value; }
        public DateTime FechaPaso { get => fechaPaso; set => fechaPaso = value; }
        public bool Apto { get => apto; set => apto = value; }
        public string TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }
       

        public Vehiculo(long id, string matricula, string tipoVehiculo, bool mercancia)
        {
            this.id = id;
            this.matricula = matricula;
            this.tipoVehiculo = tipoVehiculo;
            this.zonaDestino = zonaDestino;
            this.mercancia = mercancia;
            this.fechaPaso = fechaPaso;
            this.apto = apto;
        }

        public Vehiculo()
        {
            
        }

        override
        public string ToString()
        {
            string texto =
                string.Concat(matricula,";",tipoVehiculo,";",zonaDestino,";",mercancia,";",fechaPaso);
        
            return texto;
        } 
    }
}
