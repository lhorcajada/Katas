using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.KataHolaDonRamon
{
    public class ProveedorEscritura : IProveedorEscritura
    {
        public void EscribirLinea(string linea)
        {
            Console.WriteLine(linea);
        }

        internal void EsperaPulsacionSpacebarParaSalir()
        {
            var tecla = Console.ReadKey();
            while (tecla.Key != ConsoleKey.Spacebar);
        }
    }
}
