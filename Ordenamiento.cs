using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoSelecion
{
    internal class Ordenamiento
    {
        public static void SelectionSort(List<int> arr)
        {
            /// <summary>
            /// Algoritmo de Ordenamiento por Selección (Selection Sort).
            /// </summary>
            /// <param name="arr">La lista de enteros a ordenar.</param>
            int n = arr.Count;
            // Un bucle para recorrer todo el arreglo
            for (int i = 0; i < n - 1; i++)
            {
                // Encontrar el índice del elemento mínimo en el resto de la lista no ordenada
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                }

                // Intercambiar el elemento mínimo encontrado con el primer elemento de la porción no ordenada
                // Si el índice mínimo es diferente al índice actual (i)
                if (min_idx != i)
                {
                    int temp = arr[min_idx];
                    arr[min_idx] = arr[i];
                    arr[i] = temp;
                }
            }
        }

    }
}
