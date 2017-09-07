using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.KataHolaDonRamon
{
    public class ManejadorPalabra
    {
    
        public List<string[]> ObtenerGruposDeSeisPalabras(string[] palabras)
        {
            string[] palabrasOrdenadasAleatoriamente=null;
            List<string[]> gruposPalabras = new List<string[]>();
            for (int x = 0; x < 6; x++)
            {
                do
                {
                    palabrasOrdenadasAleatoriamente = palabras.OrdenarArrayAleatoriamente();
                    if(!YaExisteOrdenDePalabrasEnElGrupo(gruposPalabras,palabrasOrdenadasAleatoriamente))
                    {
                        AñadirPalabrasAlGrupoDePalabras(palabrasOrdenadasAleatoriamente, gruposPalabras);
                        palabrasOrdenadasAleatoriamente = palabrasOrdenadasAleatoriamente.InicializarArray(palabras.Count());
                    }
                }
                while (YaExisteOrdenDePalabrasEnElGrupo(gruposPalabras,palabrasOrdenadasAleatoriamente));
            }
            return gruposPalabras;
        }

        

        private void AñadirPalabrasAlGrupoDePalabras(string[] palabras, List<string[]> gruposPalabras)
        {
            gruposPalabras.Add(palabras);
        }


        private bool YaExisteOrdenDePalabrasEnElGrupo(List<string[]> gruposPalabras, string[] ordenDePalabras)
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
  

   


    }
}
