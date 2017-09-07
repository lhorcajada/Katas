using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Katas;
using System.Linq;
using System.Collections.Generic;
using Katas.KataHolaDonRamon;

namespace KatasTest
{
    [TestClass]
    public class ManejadorPalabrasTest
    {
        [TestMethod]
        public void CrearFrasesConTresPalabras_TodasDistintas()
        {
            string[] palabras = new[] { "Hola", "Don", "Ramón" };

            ComprobarFrasesDistintas(palabras);
        }

     
        [TestMethod]
        public void CrearFrasesConCuatroPalabras_TodasDistintas()
        {
            string[] palabras = new[] { "Hola", "Don", "Ramón", "Pepe" };

            ComprobarFrasesDistintas(palabras);
        }
        private void ComprobarFrasesDistintas(string[] palabras)
        {
            ManejadorPalabra holadonRamon = new ManejadorPalabra();
            var gruposPalabras = holadonRamon.ObtenerGruposDeSeisPalabras(palabras);
            List<string> gruposConcatenados = new List<string>();

            ConcatenarGruposPalabras(gruposPalabras, gruposConcatenados);
            var numeroGruposConcatenadosNoRepetidos = gruposConcatenados.Distinct().Count();
            var numeroGrupos = gruposPalabras.Count();
            Assert.AreEqual(numeroGrupos, numeroGruposConcatenadosNoRepetidos);
        }

        private void ConcatenarGruposPalabras(List<string[]> gruposPalabras, List<string> gruposConcatenados)
        {
            foreach (var grupo in gruposPalabras)
            {
                string grupoConcatenado = string.Empty;
                foreach (var elemento in grupo)
                {
                    grupoConcatenado = grupoConcatenado + elemento;
                }
                gruposConcatenados.Add(grupoConcatenado);
            }
        }
    }
}
