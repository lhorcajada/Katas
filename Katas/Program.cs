using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            HolaDonRamon holaDonRamon = new HolaDonRamon(new ProveedorEscritura());
            string[] palabras = new[] { "Hola", "Don", "Ramón" };

            var gruposPalabras = holaDonRamon.ObtenerGruposPalabras(palabras);
            holaDonRamon.ImprimirFrases(gruposPalabras);

            Console.ReadLine();

        }
    }
}
