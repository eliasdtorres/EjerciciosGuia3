using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5.Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en
//lugares pares. Imprimir la matriz por pantalla
namespace Guia3.Ejercicio5
{
    internal class Matriz
    {

        public Matriz() { }

        public string[,] crearMatriz(int res)
        {
            string[,] matriz = new string[res, res];

            for (int i = 0; i < res; i++)
            {
                for (int j = 0; j < res; j++)
                {
                    if ((j + i) % 2 == 0)
                    {
                        matriz[i, j] = "P";
                    }
                    else
                    {
                        matriz[i, j] = "I";
                    }
                }
            }

            return matriz;
        }

        public void mostrarMatriz(string[,] matriz, int res)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Matriz creada");
            Console.WriteLine("==========================");
            for (int i = 0; i < res; i++)
            {

                for (int j = 0; j < res; j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }

                Console.WriteLine("");

            }

        }


    }
}
