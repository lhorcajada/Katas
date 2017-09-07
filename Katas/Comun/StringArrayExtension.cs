using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class StringArrayExtension
    {
        public static string[] OrdenarArrayAleatoriamente(this string[] palabras)
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
        public static string[] InicializarArray(this string[] palabras, int numeroPalabras)
        {
            palabras =  new string[numeroPalabras];
            return palabras;
        }
        public static bool ExisteNumeroEnArray(this int?[] indicePalabras, int numeroBuscado)
        {
            return indicePalabras.Any(i => i == numeroBuscado);
        }
    }
}
