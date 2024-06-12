using prueba4EvaRecup.dtos;
using prueba4EvaRecup.servicios;

namespace prueba4EvaRecup
{
    /// <summary>
    /// Clase principal del programa
    /// msm - 120624
    /// </summary>
    class Program
    {
        public static List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        /// <summary>
        /// Contiene el procedimiento del menu
        /// msm - 120624
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();

            int opcionUusariio = 0;
            bool cerrarMmeu = false;

            while (!cerrarMmeu)
            {
                opcionUusariio = mi.mostrarMenuPrincipal();
                try
                {
                    switch (opcionUusariio)
                    {
                        case 0:
                            cerrarMmeu = true;
                            break;

                        case 1:
                            op.meterDatos();
                            break;

                        default:
                            Console.WriteLine("Esa opcion no existe");
                            break;
                    }
                }catch(Exception e)
                {
                   
                }
                
            }
        }
    }
}