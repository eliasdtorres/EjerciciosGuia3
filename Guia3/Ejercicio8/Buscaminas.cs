using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//8. Crear una matriz de 10 x 10, y “esconder” varias ‘X’ en lugares aleatorios (la
//cantidad que el programador decida, pero no más de la mitad de los lugares
//disponibles en la matriz). El usuario deberá ingresar el lugar donde cree que
//hay una X, ingresando la fila y la columna por separado. Informar si acertó o
//no por cada ingreso. Se debe pedir al usuario ingresar valores por tantas X
//que se haya guardado. El usuario tiene 3 intentos para fallar. Al finalizar (Ya
//sea porque se terminaron los 3 intentos, o el jugador acertó todas las X)
//imprimir por pantalla la matriz con sus correspondientes X, mostrando un *
//donde no haya nada.


namespace Guia3.Ejercicio8
{
    internal class Buscaminas
    {
        public Buscaminas() { }

        public string[,] crearTerreno()
        {
            string[,] terreno = new string[10, 10];
            int cont = 0, i, j, cantidadMinas, cantidad;
            Random r = new Random();
            cantidad = r.Next(11, 49);
            cantidadMinas = 0;
            string mina = "X";

            while (cont <= cantidad)
            {
                i = r.Next(0, 9);
                j = r.Next(0, 9);
                terreno[i, j] = "X";
                cont++;
            }


            for (int k = 0; k < 10; k++)
            {
                for (int l = 0; l < 10; l++)
                {
                    if (terreno[k, l] == null)
                    {
                        terreno[k, l] = "*";
                    }

                    if (terreno[k, l].Contains(mina))
                    {
                        cantidadMinas++;
                    }
                }
            }
            Console.WriteLine("Minas a encontrar :" + (cantidadMinas));
            return terreno;
        }

        public void jugar(string[,] terreno)
        {
            int vidas = 3;
            int i = 0, j = 0, cantidadDeMinas = 0, encontradas = 0;
            string mina = "X";
            bool isOk = false;
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Juguemos al Buscaminas, ingresa las coordenadas del elemento indicando el número de fila y columna, las minas encontradas se marcan con 'E'." +
                " Cuentas con 3 (tres) intentos");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");

            for (int k = 0; k < 10; k++)
            {
                for (int l = 0; l < 10; l++)
                {
                    if (terreno[k, l].Contains(mina))
                    {
                        cantidadDeMinas++;
                    }
                }
            }

            do
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Ingrese el número de fila. ( 1 al 10 )");
                        i = (int.Parse(Console.ReadLine())) - 1;

                        Console.WriteLine("Ingrese el número de columna.  ( 1 al 10 )");
                        j = (int.Parse(Console.ReadLine())) - 1;
                        isOk = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ingrese tipo de dato válido");
                        isOk = false;
                    }

                    if (i < 1 || i > 10 || j < 1 || j > 10)
                    {
                        Console.WriteLine("============================================================");
                        Console.WriteLine("= Ingrese un número dentro del rango indicado. ( 1 al 10 ) =");
                        Console.WriteLine("============================================================");
                    }


                } while (!isOk || i < 1 || i > 10 || j < 1 || j > 10);



                if (terreno[i, j].Contains(mina))
                {
                    cantidadDeMinas--;
                    encontradas++;
                    Console.WriteLine("Mina encontrada y desactivada. \nMinas restantes: " + cantidadDeMinas);
                    Console.WriteLine("----------------------------------------------------");
                    terreno[i, j] = "E";
                }
                else
                {
                    vidas -= 1;
                    Console.WriteLine("No se encontró ninguna mina.\nVidas disponibles: " + vidas);
                    Console.WriteLine("----------------------------------------------------");
                }
            } while (vidas > 0 && cantidadDeMinas > 0);

            Console.WriteLine("Cantidad de minas encontradas: " + encontradas);
        }


        public void mostrarTerreno(string[,] terreno)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("[ " + terreno[i, j] + " ]");
                }
                Console.WriteLine();
            }
        }
    }
}
