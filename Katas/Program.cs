using Katas.KataHolaDonRamon;
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
            string[] palabras = new[] { "Hola", "Don", "Ramón" };

            ManejadorPalabra manejadorPalabra = new ManejadorPalabra();
            var gruposDeSeisPalabras = manejadorPalabra.ObtenerGruposDeSeisPalabras(palabras);
            var proveedorEscritura = new ProveedorEscritura();
            ManejadorFrase frase = new ManejadorFrase(proveedorEscritura);
            frase.ImprimirFrases(gruposDeSeisPalabras);
            frase.ImprimirFrase("Pulse la tecla espaciadora para salir.");
            proveedorEscritura.EsperaPulsacionSpacebarParaSalir();

        }
    }
}
