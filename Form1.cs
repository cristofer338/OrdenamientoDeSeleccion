using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenamientoSelecion
{
    public partial class Form1 : Form
    {
        private List<int> listaNumeros;
        public Form1()
        {
            InitializeComponent();
            listaNumeros = new List<int>();
        }
        /// <summary>
        /// Función auxiliar para actualizar el ListBox con el contenido de la lista.
        /// </summary>
        /// <param name="header">Texto a mostrar al inicio del ListBox.</param>
        private void ActualizarListBox(string header)
        {
            listBoxNumeros.Items.Clear();
            listBoxNumeros.Items.Add(header);
            listBoxNumeros.Items.Add("---------------------------------");

            // Agregar los números a la ListBox
            foreach (int num in listaNumeros)
            {
                listBoxNumeros.Items.Add(num.ToString());
            }

        }
        //los muestra en la segunda lista ya ordenados
        private void ActualizarListBoxOrdenado(string header)
        {
            listBoxOrdenado.Items.Clear();
            listBoxOrdenado.Items.Add(header);
            listBoxOrdenado.Items.Add("---------------------------------");

            // Agregar los números a la ListBox
            foreach (int num in listaNumeros)
            {
                listBoxOrdenado.Items.Add(num.ToString());
            }

        }

        // --- Manejadores de Eventos de los Botones ---

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            // 1. Generar la lista de 20 números aleatorios entre 0 y 100
            listaNumeros.Clear();
            Random rand = new Random();
            for (int i = 0; i < 20; i++) // Generamos 20 números como ejemplo
            {
                listaNumeros.Add(rand.Next(0, 101)); // Números de 0 a 100
            }

            // 2. Mostrar la lista en el ListBox
            ActualizarListBox("Lista Generada (Sin Ordenar):");

            // 3. Limpiar el tiempo
            lblTiempo.Text = "Tiempo de ejecución: --";
        }

        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            if (listaNumeros.Count == 0)
            {
                MessageBox.Show("Primero debes generar una lista de números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Iniciar cronómetro para medir el tiempo
            Stopwatch stopwatch = Stopwatch.StartNew();

            // 2. Ejecutar el algoritmo de Ordenamiento por Selección
            Ordenamiento.SelectionSort(listaNumeros);

            // 3. Detener cronómetro
            stopwatch.Stop();

            // 4. Mostrar la lista ordenada
            ActualizarListBoxOrdenado("Lista Ordenada (Selection Sort):");

            // 5. Mostrar el tiempo de ejecución
            lblTiempo.Text = $"Tiempo de ejecución: {stopwatch.Elapsed.TotalMilliseconds:F4} ms";
        }

        private void listBoxOrdenado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
