using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class HolaDonRamon
    {
        private readonly IProveedorEscritura _proveedorEscritura;
        public HolaDonRamon(IProveedorEscritura proveedorEscritura)
        {
            _proveedorEscritura = proveedorEscritura;
        }
        public List<string[]> ObtenerGruposPalabras(string[] palabras)
        {
            string[] palabrasOrdenadasAleatoriamente=null;
            List<string[]> gruposPalabras = new List<string[]>();
            for (int x = 0; x < 6; x++)
            {
                do
                {
                    palabrasOrdenadasAleatoriamente = OrdenarArrayAleatoriamente(palabras);
                    if(!YaExisteOrdenDePalabras(gruposPalabras,palabrasOrdenadasAleatoriamente))
                    {
                        gruposPalabras.Add(palabrasOrdenadasAleatoriamente);
                        palabrasOrdenadasAleatoriamente = new string[palabras.Count()];
                    }
                }
                while (YaExisteOrdenDePalabras(gruposPalabras,palabrasOrdenadasAleatoriamente));
            }
            return gruposPalabras;
        }
        public void ImprimirFrases(List<string[]> gruposPalabras)
        {
            foreach (var grupo in gruposPalabras)
            {
                string frase = ObtenerFrase(grupo);
                _proveedorEscritura.EscribirLinea(frase);
            }
        }
        private string[] OrdenarArrayAleatoriamente(string[] palabras)
        {
            int numeroPalabras = palabras.Count();
            int?[] indicePalabras = new int?[numeroPalabras];
            string[] palabrasOrdenasAleatoriamente = new string[numeroPalabras];
            Random random = new Random();
            int numeroAleatorio = -1;
            for (int x = 0; x < numeroPalabras; x++)
            {
                do
                {
                    numeroAleatorio = random.Next(0, numeroPalabras);
                    if (!ExisteNumeroEnArray(indicePalabras, numeroAleatorio))
                    {
                        indicePalabras[x] = numeroAleatorio;
                        palabrasOrdenasAleatoriamente[x] = palabras[numeroAleatorio];
                        numeroAleatorio = -1;
                    }
                }
                while (ExisteNumeroEnArray(indicePalabras, numeroAleatorio));
            }
            return palabrasOrdenasAleatoriamente;
        }
        private bool ExisteNumeroEnArray(int?[] indicePalabras, int numeroBuscado)
        {
            return indicePalabras.Any(i => i == numeroBuscado);
        }
        private bool YaExisteOrdenDePalabras(List<string[]> gruposPalabras, string[] ordenDePalabras)
        {
            if (gruposPalabras.Count == 0)
                return false;
            string ordenPalabrasConcatenadas = string.Empty;
            foreach (var palabra in ordenDePalabras)
            {
                ordenPalabrasConcatenadas = ordenPalabrasConcatenadas + palabra;
            }
            foreach (var grupo in gruposPalabras)
            {
                string grupoConcatenado = string.Empty;
                foreach (var elemento in grupo)
                {
                    grupoConcatenado = grupoConcatenado + elemento;
                }
                if (grupoConcatenado == ordenPalabrasConcatenadas)
                    return true;
            }
            
            return false;
        }
  

        private string ObtenerFrase(string[] palabrasOrdenadasAleatoriamente)
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
