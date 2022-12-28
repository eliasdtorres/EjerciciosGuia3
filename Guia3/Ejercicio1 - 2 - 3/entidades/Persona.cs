using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia3.Ejercicio1
{
    internal class Persona
    {
        public string _name;
        public string _lastName;
        public int _age;
        public DateTime _dateOfBirth { get; set; }
        public Persona() { }

        public Persona createPerson()
        {
            Persona p = new Persona();
            int day = 0, month = 0, year = 0;
            bool _isOk = false;

            Console.WriteLine("Ingrese nombre");
            p._name = Console.ReadLine().ToUpper();

            Console.WriteLine("Ingrese apelldo");
            p._lastName = Console.ReadLine();

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

            p._dateOfBirth = new DateTime(year, month, day);
            return p;
        }

        public int getAge(DateTime _dateOfBirth)
        {
            int age = DateTime.Today.AddTicks(-_dateOfBirth.Ticks).Year - 1;
            
            return age;
        }
                        
    }
}
