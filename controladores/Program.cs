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
        public static string texto;
        public static string rutaFichero = Utiles.Utiles.nombreFicheroVehiculos();
        public static string rutaFicheroLog = Utiles.Utiles.nombreFicheroLog();
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
            OperacionFicheroInterfaz of = new OperacionFicheroImplementacion();

            of.cargaInicial();

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
                            texto = "Se ha cerrado la aplicacion";
                            of.escribirFicheroLog(texto);
                            of.escribirFichero();
                            break;

                        case 1:
                            op.meterDatos();
                            texto = "Se ha accedidod a la opcion de meter datos";
                            of.escribirFicheroLog(texto);
                            break;

                        default:
                            Console.WriteLine("Esa opcion no existe");
                            break;
                    }
                }catch(Exception e)
                {
                   texto = e.Message;
                   of.escribirFicheroLog(texto);
                }
                
            }
        }
    }
}