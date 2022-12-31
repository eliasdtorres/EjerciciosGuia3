using Guia3.Ejercicio1;
using Guia3.Ejercicio1___2___3.servicios;
using Guia3.Ejercicio4;
using Guia3.Ejercicio5;
using Guia3.Ejercicio6;
using Guia3.Ejercicio7;
using System;
using System.Numerics;

namespace Program
{
    class program
    {
        public static void Main(string[] args)
        {

            //Ejercicio 1 : Sacar Promedio de notas;
            //ServicioEj1 sv = new ServicioEj1();
            //Alumno alumno= new Alumno();
            //alumno = sv.crearListaDeNotas();
            //sv.sacarPromedio(alumno.notas);

            //=======================================================================================
            //Ejercicio 2 : Crear lista de personas y veirifcar edad

            //List<Alumno> alumnos = new List<Alumno>();
            //ServicioEj2 sv = new ServicioEj2();
            //alumnos = sv.createAlumnList();

            //foreach (var item in alumnos)
            //{
            //    Console.WriteLine(item.ToString(item));
            //    Console.WriteLine("==============================");
            //}

            //sv.mostrarMayorDeEdad(alumnos);

            //=======================================================================================
            //Ejercicio 3 : Nombre mas largo y mas corto
            //string res;
            //List<Alumno> alumnos = new List<Alumno>();
            //ServicioEj3 sv = new ServicioEj3();
            //alumnos = sv.createAlumnList();
            //sv.mostrarMayorDeEdad(alumnos);
            //sv.mostrarNombreLargoCorto(alumnos);
            //do
            //{
            //    Console.WriteLine("Mostrar listado de alumnos? s/n");
            //    res = Console.ReadLine().ToLower();

            //} while (res != "s" && res != "n");

            //if (res=="s")
            //{
            //    sv.mostrarLista(alumnos);
            //}
            //else
            //{
            //    Console.WriteLine("fin del programa");
            //}

            //===================================================================================================
            //Ejercicio 4 : Lista de compras

            //Producto producto = new Producto();
            //string[][] listas= new string[2][];
            //List<string> lista = new List<string>();
            //int res = 0;  
            //bool isOk= false;
            //lista = producto.listaDeProductos();
            //listas = producto.comprar(lista);

            //if (listas[0]!=null)
            //{
            //    do
            //    {
            //        do
            //        {
            //            try
            //            {
            //                Console.WriteLine("Seleccione opción");
            //                Console.WriteLine("1- Mostrar lista de productos no comprados y comprados pero agregados" +
            //                    "\n2- Mostrar lista de productos comprados\n3- Fin");
            //                res = int.Parse(Console.ReadLine());
            //                isOk = true;
            //            }
            //            catch (FormatException)
            //            {
            //                Console.WriteLine("Debe elegir una opcíon numérica válida");
            //                isOk = false;
            //            }
            //        } while (!isOk);

            //        switch (res)
            //        {
            //            case 1:
            //                Console.WriteLine("Lista de productos final (No comprados y comprados pero agregados)");
            //                Console.WriteLine("-------------------");
            //                foreach (var item in listas[0])
            //                {
            //                    Console.WriteLine("- "+item);
            //                }
            //                Console.WriteLine("-------------------");
            //                break;
            //            case 2:
            //                Console.WriteLine("-------------------");
            //                Console.WriteLine("Productos comprados");
            //                foreach (var item in listas[1])
            //                {
            //                    Console.WriteLine("- " + item);
            //                }
            //                Console.WriteLine("-------------------");
            //                break;
            //            case 3:
            //                Console.WriteLine("Fin del programa");
            //                break;
            //            default:
            //                Console.WriteLine("Debe elegir una opcíon numérica válida");
            //                break;
            //        }

            //    } while (res != 3);
            //}
            //else{}


            //===================================================================================================
            //Ejercicio 5 : Matriz Par Impar

            //Matriz m = new Matriz();
            //bool isOk;
            //int res = 0;

            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Ingrese tamaño matriz: ");
            //        res = int.Parse(Console.ReadLine());
            //        isOk = true;
            //    }
            //    catch (FormatException)
            //    {
            //        isOk = false;
            //    }
            //} while (!isOk);

            //string[,] matriz = m.crearMatriz(res); 
            //m.mostrarMatriz(matriz,res);

            //===================================================================================================
            //Ejercicio 6 : Matriz Temperatura
            //MatrizTemperatura m = new MatrizTemperatura();

            //int[,] matriz = m.temperaturas();
            //m.mostrarCalendario(matriz);
            //m.extremosSemanales(matriz);
            //Console.WriteLine("===========================");
            //m.promedio(matriz);
            //Console.WriteLine("===========================");
            //m.diaMensualMasCaluroso(matriz);

            //===================================================================================================
            //Ejercicio 7 : Matriz de tablas
            Tabla t = new Tabla();
            int[,] tabla = t.crearMatriz();
            t.mostrarMatriz(tabla);

            //===================================================================================================
            //Ejercicio 8 :

        }
    }
}