using prueba4EvaRecup.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace prueba4EvaRecup.servicios
{
    /// <summary>
    /// Contiene la logica de los metodos del servicio operativa
    /// msm - 120624
    /// </summary>
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
         

            Vehiculo vehiculo = new Vehiculo(id, matricula, tipo, mercancia);
            Program.listaVehiculos.Add(vehiculo);

            puertos(vehiculo);
            foreach (Vehiculo vehiculos in Program.listaVehiculos)
            {
                Console.WriteLine(vehiculos.ToString());
            }
        }

        private string puertos(Vehiculo vehiculo)
        {
            string zona = "aa";

            //SN
            if(vehiculo.Mercancia == false)
            {
                if (vehiculo.TipoVehiculo.Equals("F") | vehiculo.TipoVehiculo.Equals("A"))
                {
                    zona = "SN";
                    Console.WriteLine(" ");
                    Console.WriteLine("El vehiculo ha llegado al puerto SN");
                    Console.WriteLine(" ");
                }

            }

            //SO
            if (vehiculo.TipoVehiculo.Equals("P"))
            {
                zona = "SO";
                Console.WriteLine(" ");
                Console.WriteLine("El vehiculo ha llegado al puerto SO");
                Console.WriteLine(" ");
            }

            //SE
            if (vehiculo.TipoVehiculo.Equals("F") | vehiculo.TipoVehiculo.Equals("A"))
            {
                if (vehiculo.Mercancia)
                {
                    zona = "SE";

                    if (zona.Equals("SE"))
                    {
                        zona = "PIF";

                        Console.WriteLine(" ");
                        Console.WriteLine("¿Es apto la mercancia? s/n");
                        Console.WriteLine(" ");
                        string respuesta = Console.ReadLine();
                        if (respuesta.Equals("s"))
                        {
                            zona = "EN";
                            Console.WriteLine(" ");
                            Console.WriteLine("El vehiculo ha llegado al puerto EN");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            zona = "S";
                            Console.WriteLine(" ");
                            Console.WriteLine("El vehiculo a sido redirigido al puerto S");
                            Console.WriteLine(" ");
                        }
                    }
                }
            }

            return zona;
        }

        
    }
}
