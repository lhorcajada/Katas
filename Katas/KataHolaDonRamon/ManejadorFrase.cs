using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.KataHolaDonRamon
{
    public class ManejadorFrase
    {
        private readonly IProveedorEscritura _proveedorEscritura;
        public ManejadorFrase(IProveedorEscritura proveedorEscritura)
        {
            _proveedorEscritura = proveedorEscritura;
        }

        public void ImprimirFrases(List<string[]> gruposPalabras)
        {
            foreach (var grupo in gruposPalabras)
            {
                string frase = ObtenerFrase(grupo);
                _proveedorEscritura.EscribirLinea(frase);
            }
        }
        public void ImprimirFrase(string frase)
        {
           _proveedorEscritura.EscribirLinea(frase);
        }
        public string ObtenerFrase(string[] palabrasOrdenadasAleatoriamente)
        {
            var frase = string.Empty;
            foreach (string palabra in palabrasOrdenadasAleatoriamente)
            {
                frase = string.Format("{0} {1}", frase, palabra);
            }
            return frase;
        }
    }
}
