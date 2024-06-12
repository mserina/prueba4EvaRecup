using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba4EvaRecup.servicios
{
    /// <summary>
    /// Contiene la logica de los metodos del servicio menu
    /// msm - 120624
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuPrincipal()
        {
            int opcionUsuario;

            Console.WriteLine("BIENVENIDO");
            Console.WriteLine("______________");
            Console.WriteLine("0[] Cerrar Menu");
            Console.WriteLine("1[] Acceder al puerto");
        
            opcionUsuario = Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;
        }
    }
}
