using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los días de la semana. La estructura es para registrar la temperatura diaria de
//una cabina de pago, estos oscilan entre los 7 y 38 grados. Deberá llenar la matriz de forma aleatoria para el mes de mayo donde el primer día inicia en
//lunes y el último (31) se ubica en el miércoles (la matriz puede ser inicializada con valores aleatorios desde el principio del programa, no es necesario pedir
//los valores al usuario para cada posición). Se nos pide hacer lo siguiente:
//a.Obtener la temperatura más alta y baja de la semana y que día se produjo (lunes, martes, etc.)
//b.Promedio de temperatura de la semana.
//c. Temperatura más alta del mes y su día.
namespace Guia3.Ejercicio6
{
    internal class MatrizTemperatura
    {

        public MatrizTemperatura() { }

        public int[,] temperaturas()
        {
            Random r = new Random();
            int[,] calendario = new int[5, 7];
            int cont = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (cont <= 31)
                    {
                        calendario[i, j] = r.Next(7, 38);
                    }
                    else
                    {
                        calendario[i, j] = 00;
                    }
                    cont++;
                }
            }

            return calendario;
        }

        public void mostrarCalendario(int[,] calendario)
        {
            int cont = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {


                    if (cont <= 31)
                    {
                        if (calendario[i, j] < 10)
                        {
                            Console.Write("[ 0" + calendario[i, j] + " ]");
                        }
                        else
                        {
                            Console.Write("[ " + calendario[i, j] + " ]");
                        }
                        cont++;
                    }

                }
                Console.WriteLine("");
            }
        }

        public void extremosSemanales(int[,] calendario)
        {
            int j, i, cont = 1; ;
            int mayor, menor, prom;
            string diaMayor = "", diaMenor = "";

            for (i = 0; i < 5; i++)
            {
                mayor = 0;
                menor = 100;

                for (j = 0; j < 7; j++)
                {
                    if (cont <= 31)
                    {
                        if (calendario[i, j] > mayor)
                        {
                            mayor = calendario[i, j];


                            if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 0)
                            {
                                diaMayor = "Lunes";
                            }
                            if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 1)
                            {
                                diaMayor = "Martes";
                            }
                            if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 2)
                            {
                                diaMayor = "Miercoles";
                            }
                            if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 3)
                            {
                                diaMayor = "Jueves";
                            }
                            if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 4)
                            {
                                diaMayor = "Viernes";
                            }
                            if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 5)
                            {
                                diaMayor = "Sábado";
                            }
                            if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 6)
                            {
                                diaMayor = "Domingo";
                            }
                        }
                        else if (calendario[i, j] <= menor)
                        {
                            menor = calendario[i, j];

                            if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 0)
                            {
                                diaMenor = "Lunes";
                            }
                            if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 1)
                            {
                                diaMenor = "Martes";
                            }
                            if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 2)
                            {
                                diaMenor = "Miercoles";
                            }
                            if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 3)
                            {
                                diaMenor = "Jueves";
                            }
                            if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 4)
                            {
                                diaMenor = "Viernes";
                            }
                            if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 5)
                            {
                                diaMenor = "Sábado";
                            }
                            if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 6)
                            {
                                diaMenor = "Domingo";
                            }

                        }

                    }
                    cont++;
                }
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Semana n° " + (i + 1));
                Console.WriteLine("Dia mas caluroso: " + diaMayor + " con " + mayor + "°C.");
                Console.WriteLine("Dia menos caluroso: " + diaMenor + " con " + menor + "°C.");
                Console.WriteLine("-------------------------------------------------------");
            }
        }

        public void promedio(int[,] calendario)
        {
            int ac = 0, i, j;
            int contDias = 0;
            int contSem = 0, cont = 1;

            for (i = 0; i < 5; i++)
            {
                ac = 0;
                contDias = 0;

                for (j = 0; j < 7; j++)
                {
                    ac += calendario[i, j];
                    contDias++;
                    cont++;
                    if (contSem == 4)
                    {
                        contDias = 3;
                    }

                }
                contSem++;
                Console.WriteLine("Promedio de temperatura semana N°" + contSem + ": " + (ac / contDias) + "°C");
            }
        }

        public void diaMensualMasCaluroso(int[,]calendario)
        {
            int i, j;
            int mayor = 0 ;
            string diaMayor = "";

            for(i = 0; i < 5; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    if (calendario[i,j]> mayor)
                    {
                        mayor = calendario[i, j];
                        if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 0)
                        {
                            diaMayor = "Lunes";
                        }
                        if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 1)
                        {
                            diaMayor = "Martes";
                        }
                        if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 2)
                        {
                            diaMayor = "Miercoles";
                        }
                        if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 3)
                        {
                            diaMayor = "Jueves";
                        }
                        if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 4)
                        {
                            diaMayor = "Viernes";
                        }
                        if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 5)
                        {
                            diaMayor = "Sábado";
                        }
                        if ((i == 0 || i == 1 || i == 2 || i == 3 || i == 4) && j == 6)
                        {
                            diaMayor = "Domingo";
                        }
                    }
                }
            }
            Console.WriteLine("Dia con mayor temperatura: "+ diaMayor + " con " + mayor + "°C.");
        }
    }
}

