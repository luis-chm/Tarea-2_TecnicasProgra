using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_TecnicasProgra
{
    public static class Ejercicio1
    {
        //toma un diccionario y devuelve una lista por medio del metodo ContarOcurrencias
        public static Dictionary<int, int> ContarOcurrencias(List<int> lista)//se pasa por parametros una lista
        {
            //inicializar el diccionario y se crea uno nuevo vacio llamado DictContar
            Dictionary<int, int> DictContar = new Dictionary<int, int>();
            foreach (int elemento in lista)
            {
                if (DictContar.ContainsKey(elemento))
                {
                    DictContar[elemento] = DictContar[elemento] + 1;//si el diccionario conteo encuentra un elemento clave en la lista suma +1 al asociado realizando el conteo
                }
                else
                {
                    DictContar[elemento] = 1;//si no contiene el elemento clave le deja el valor en 1
                }
            }
            return DictContar;//devuelve diccionario con ocurrencias de num enteros
        }

        public static void ResultadoEjercicio1(Dictionary<int, int> DiccOcurrencia)//se pasa por parametros un diccionario de enteros los cuales vienen de la lista
        {
            Console.WriteLine("Resultado Ejercicio 1:");
            foreach (var par in DiccOcurrencia)//en cada vuelta el sistema extrae el key y value del diccionario
            {
                Console.WriteLine($"[{par.Key}, {par.Value}]");//imprime el valor encontrado
            }
            Console.WriteLine();
        }
    }
}
