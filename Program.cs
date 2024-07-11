using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_TecnicasProgra
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1
            //Ejercicio 1
            List<int> listaOcurrencia = new List<int> { 10, 10, 2, 6, 70, 5 };
            Dictionary<int, int> DiccOcurrencia = Ejercicio1.ContarOcurrencias(listaOcurrencia);//se pasa por parametro una lista en el metodo para luego retornar la data al diccionario
            Ejercicio1.ResultadoEjercicio1(DiccOcurrencia);//el diccionario con data se pasa al metodo para devolver el resultado
            #endregion Ejercicio 1

            #region Ejercicio 2
            //Ejercicio 2
            string[] palabras = { "abba", "cabra" };//array con 2 palabras de ejemplo, una si es y la otra no
            Console.WriteLine("Resultado Ejercicio 2\n");
            foreach (string palabra in palabras)
            {
                /*se llama al metodo EsPalindromo en la classe ejercicio 2 y se pasa por parametro la palabra que obtuvo el foreach. 
                 * si bool es true si devuelve valido, false si no devuelve.
                 * cada true/false se almacena en la variable */
                bool esPalindromo = Ejercicio2.EsPalindromo(palabra);
                Ejercicio2.ResultadoEjercicio2(palabra, esPalindromo);
            }
            #endregion Ejercicio 2

            #region Ejercicio 3
            //Ejercicio 3
            string texto = "mala sala en la casa";
            string buscar = "ala";
            string reemplazar = "opo";
            string modificado = Ejercicio3.ReemplazarCaracteres(texto, buscar, reemplazar);
            Ejercicio3.ResultadoEjercicio3(texto, modificado);
            #endregion Ejercicio 3

            #region Ejercicio 4
            //Ejercicio 3

            #endregion Ejercicio 4
        }
    }
}
