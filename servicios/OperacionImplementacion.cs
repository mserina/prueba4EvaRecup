using prueba4EvaRecup.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba4EvaRecup.servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public void meterDatos()
        {

            long id = Utiles.Utiles.idGenerator();
            Console.WriteLine("Inserte numero matricula");
            string matricula = Console.ReadLine();
            Console.WriteLine("Tipo de vehiculo");
            string tipo = Console.ReadLine();
            Console.WriteLine("¿Tiene mercanica?");
            string respuesta = Console.ReadLine();
            bool mercancia = false;

            if (respuesta.Equals("s"))
            {
                mercancia = true;
            }
            string zona = puertos(tipo, mercancia);

            Vehiculo vehiculo = new Vehiculo(id, matricula, tipo, zona, mercancia);
            Program.listaVehiculos.Add(vehiculo);

            foreach (Vehiculo vehiculos in Program.listaVehiculos)
            {
                Console.WriteLine(vehiculo.ToString());
            }
        }

        private string puertos(string tipo, bool mercancia)
        {
            string zona = "aa";

            //SN
            if(mercancia == false)
            {
                if (tipo.Equals("F") | tipo.Equals("A"))
                {
                    zona = "SN";
                    Console.WriteLine(" ");
                    Console.WriteLine("Bienvenido a la zona SN");
                    Console.WriteLine(" ");
                }

            }

            //SO
            if (tipo.Equals("P"))
            {
                zona = "SO";
                Console.WriteLine(" ");
                Console.WriteLine("Bienvenido a la zona SO");
                Console.WriteLine(" ");
            }



            return zona;
        }
    }
}
