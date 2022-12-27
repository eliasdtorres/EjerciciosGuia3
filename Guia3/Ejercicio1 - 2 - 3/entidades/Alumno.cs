using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. Dado que se tiene almacenado en una lista, los resultados de los últimos 10
//exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10
//notas de los exámenes y el promedio resultante.
namespace Guia3.Ejercicio1
{
    internal class Alumno : Persona
    {

        public List<Double> notas = new List<Double>();

        public Alumno() { }


        public Alumno createAlumn()
        {
            Alumno a = new Alumno();
            int day = 0, month = 0, year = 0;
            bool _isOk = false;

            Console.WriteLine("Ingrese nombre");
            a._name = Console.ReadLine().ToUpper();

            Console.WriteLine("Ingrese apelldo");
            a._lastName = Console.ReadLine();

            Console.WriteLine("Fecha de nacimiento");

            do
            {
                try
                {
                    Console.WriteLine("Ingrese día: ");
                    day = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese mes: ");
                    month = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese año: ");
                    year = int.Parse(Console.ReadLine());

                    _isOk = true;
                }
                catch (FormatException)
                {
                    _isOk = false;
                    Console.WriteLine("Ingrese valores numéricos");
                }
            } while (!_isOk);

            a._dateOfBirth = new DateTime(year, month, day);
            a._age = a.getAge(a._dateOfBirth);

            return a;
        }


        public string ToString(Alumno alumno)
        {
            return "Nombre: " + alumno._name + "\nApellido: " + alumno._lastName + "\nEdad: " + alumno._age;
        }












    }
}
