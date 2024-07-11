using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Referencias y ejemplos para uso de Replace
 * https://tinchicus.com/2023/02/15/c-string-replace/
 * https://www.kyocode.com/2018/12/cambiar-caracteres-cadena-con-replace-c/
 * 
 * No se si era posible usarlo pero lo vi automatizable, sino la otra era iterar con varios for o foreach
 */
namespace Tarea_2_TecnicasProgra
{
    public static class Ejercicio3
    {
        public static string ReemplazarCaracteres(string texto, string buscar, string reemplazar)
        {
            return texto.Replace(buscar, reemplazar);//reemplaza todas las ocurrencias de buscar con reemplazar en texto, (old value, new value) 
        }
        public static void ResultadoEjercicio3(string texto, string modificado)
        {
            Console.WriteLine($"Resultado Ejercicio 3:");
            Console.WriteLine($"Texto original: {texto}");
            Console.WriteLine($"Texto modificado: {modificado}");
            Console.WriteLine();
        }
    }
}
