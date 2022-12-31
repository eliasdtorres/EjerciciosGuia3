using Guia3.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3. Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y
//el que tenga menos letras de todos.

namespace Guia3.Ejercicio1___2___3.servicios
{
    internal class ServicioEj3 : ServicioEj2
    {
        public ServicioEj3() { }


        public void mostrarNombreLargoCorto(List<Alumno> alumnos)
        {
            int actual = 0, anterior = 0, mayorCantLetras = 0, menorCantLetras = 0;
            Alumno alumnoMasLetras = new Alumno();
            Alumno alumnoMenosLetras = new Alumno();
            foreach (Alumno item in alumnos)
            {
                actual = item._name.Length;

                if (actual > anterior)
                {
                    anterior = actual;
                    mayorCantLetras = actual;
                    alumnoMasLetras = item;

                }
                else if (actual < anterior)
                {
                    anterior = actual;
                    menorCantLetras = actual;
                    alumnoMenosLetras = item;
                }
                else 
                {
                    anterior = actual;
                    mayorCantLetras = actual;
                    menorCantLetras = actual;
                }
            }

            if (mayorCantLetras != menorCantLetras)
            {
                Console.WriteLine("El nombre: '" + alumnoMasLetras._name + "' es el de mayor longitud con: " + mayorCantLetras + " letras.");
                Console.WriteLine("El nombre: '" + alumnoMenosLetras._name + "' es el de menor longitud con: " + menorCantLetras + " letras.");
            }
            else
            {
                Console.WriteLine("Todos tienen la misma cantidad de letras.");

            }
           


        }


    }
}
