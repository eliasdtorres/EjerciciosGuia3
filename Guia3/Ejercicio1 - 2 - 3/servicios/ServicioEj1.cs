using Guia3.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.Dado que se tiene almacenado en una lista, los resultados de los últimos 10
//exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10
//notas de los exámenes y el promedio resultante.

namespace Guia3.Ejercicio1___2___3.servicios
{
    internal class ServicioEj1
    {

        public ServicioEj1() { }

        
        
       
        public Alumno crearListaDeNotas()
        {
            Alumno alumno = new Alumno();

            List<Double> notas = new List<Double>();
            int nota = 0, cont = 1, ac = 1;

            while (cont <= 10)
            {
                Console.WriteLine("Ingrese nota N°{0}", cont);
                nota = int.Parse(Console.ReadLine());
                alumno.notas.Add(nota);
                cont++;
            }

            foreach (var item in notas)
            {
                Console.WriteLine("Nota exámen N°" + ac + ": " + item);
                ac++;
            }
            return alumno;
        }





        public void sacarPromedio(List<Double> notas)
        {
            double nota = 0;
            foreach (var item in notas)
            {
                nota += item;
            }
            Console.WriteLine("NotaTotal: {0}", nota);

            Console.WriteLine("Promedio: " + (nota / 10));

        }



    }
}
