using Guia3.Ejercicio1;
using Guia3.Ejercicio1___2___3.servicios;
using System;

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

            //Ejercicio 2 : Crear lista de personas y veirifcar edad
            List<Alumno> alumnos = new List<Alumno>();
            //ServicioEj2 sv = new ServicioEj2();
            //alumnos = sv.createAlumnList();

            //foreach (var item in alumnos)
            //{
            //    Console.WriteLine(item.ToString(item));
            //    Console.WriteLine("==============================");
            //}

            //sv.mostrarMayorDeEdad(alumnos);
            string res;
            ServicioEj3 sv = new ServicioEj3();
            alumnos = sv.createAlumnList();
            sv.mostrarMayorDeEdad(alumnos);
            sv.mostrarNombreLargoCorto(alumnos);
            do
            {
                Console.WriteLine("Mostrar listado de alumnos? s/n");
                res = Console.ReadLine().ToLower();

            } while (res != "s" && res != "n");

            if (res=="s")
            {
                sv.mostrarLista(alumnos);
            }
            else
            {
                Console.WriteLine("fin del programa");
            }
           


        }
    }
}