using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Referencias
 * https://www.mycompiler.io/view/BJWJCX2vIWa
 * https://www.exercisescsharp.com/es/funciones-c/funcion-comprobar-palindromo/
 * https://gist.github.com/parzibyte/cf06316e801eede3d9b1892627f6be60
*/
namespace Tarea_2_TecnicasProgra
{
    public static class Ejercicio2
    {
        public static bool EsPalindromo(string palabra)//se pasa por parametro la palabra a validar
        {
            for (int i = 0; i < palabra.Length / 2; i++)//recorre hasta la mitad de la palabra ya que eso basta para saber si coincide o no
            {
                if (palabra[i] != palabra[palabra.Length - 1 - i])//se compara el carácter inicial con el final
                {
                    return false;//si los carácter no son iguales no seria un palindromo
                }
            }
            return true;//si los carácter son iguales es un palindromo
        }

        public static void ResultadoEjercicio2(string palabra, bool esPalindromo)//se pasa por parametro la palabra a evaluar y el resultado si es true/false
        {
            Console.WriteLine($"{palabra}: {esPalindromo}");//imprime palabra obteniendo resultado true/false
            if (!esPalindromo)
            {
                Console.WriteLine($"\nLa palabra {palabra} no es palíndromo");//imprime palabra obteniendo resultado false
            }
            Console.WriteLine();
        }
    }
}
