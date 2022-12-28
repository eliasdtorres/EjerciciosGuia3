using Guia3.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2. Dada las edades de 20 personas guardadas en una lista, imprimir por
//pantalla cuántos son mayores de edad y cuántos no.
namespace Guia3.Ejercicio1___2___3.servicios
{
    internal class ServicioEj2
    {
        public ServicioEj2() { }

        public List<Alumno> createAlumnList()
        {
            int cont = 1;
            int year = 0, month = 0, day = 0;
            
            List<Alumno> alumnos = new List<Alumno>();
            Random random = new Random();

            Console.WriteLine("Registro alumnos: ");
            do
            {
                Alumno a = new Alumno();
                a._name = "Alumno" + random.Next(1,100);

                year = random.Next(2000, 2010);
                month = random.Next(1, 12);
                day = random.Next(1, 28);

                a._dateOfBirth = new DateTime(year, month, day);
                a._age = a.getAge(a._dateOfBirth);

                alumnos.Add(a);
                

                cont++;
            } while (cont <= 20);


            Console.WriteLine("------------------------------");
            Console.WriteLine("LISTA DE ALUMNOS CREADAS");
           
            return alumnos;
        }

        public void mostrarMayorDeEdad(List<Alumno> alumnos)
        {
            int cont = 0;
            Console.WriteLine("==============================");
            Console.WriteLine("Mayor/es de edad: ");
            Console.WriteLine("==============================");
            foreach (var item in alumnos)
            {
                if (item._age>=18)
                {
                    cont++;
                    Console.WriteLine(item.ToString(item));
                    Console.WriteLine("------------------------------");
                }
            }
            Console.WriteLine("=======================================");
            Console.WriteLine("Cantidad de Mayor/es de edad: "+cont+"/"+alumnos.Count);
            Console.WriteLine("=======================================");
        }

        public void mostrarLista(List<Alumno> alumnos)
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Listado de alumnos");
            Console.WriteLine("*********************");
            
            foreach (Alumno item in alumnos)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine(item.ToString(item));
                Console.WriteLine("--------------------");
                
            }
        }

    }
}
