using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7. Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la primera fila y la primera columna
//se debe guardar los números (de 0 a 9),estando el cero en la primera posición (fila 0, columna 0). El resto de los
//lugares debe ser calculado usando los números que se dispone, por ejemplo,en la fila 1, calcular 1*1, 1*2, 1*3, etc.
//usando las posiciones del array o arreglo. Al finalizar el cálculo, mostrar la matriz por pantalla.

namespace Guia3.Ejercicio7
{
    internal class Tabla
    {
        public Tabla() { }

        public int[,] crearMatriz()
        {
            int[,] tabla = new int[10,10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0)
                    {
                        tabla[i, j] = j;
                    }
                    else if (j == 0)

                    {
                        tabla[i, j] = i;
                    }
                    else
                    {
                        tabla[i, j] = i * j;
                    }
                }
            }
            return tabla;
        }

        public void mostrarMatriz(int[,]tabla)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i == 0 || j == 0 ) || (tabla[i, j] > 0 && tabla[i, j] < 10))
                    {
                        Console.Write("[ 0" + tabla[i, j] + " ]");
                    }
                    else
                    {
                        Console.Write("[ " + tabla[i, j] + " ]");
                    }
                }
                Console.WriteLine();
            }
        }










    }
}
