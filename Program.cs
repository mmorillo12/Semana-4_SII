using System;

namespace Encapsulamiento_Persona
{
    class Persona{
        private string nombre;
        private DateTime fecha_Nacimiento;
        private int edad;
        public Persona(string nombre){
            this.nombre = nombre;
            this.fecha_Nacimiento = new DateTime (1999,2,23);
        }
        public void Registrar_Persona(){
            Console.WriteLine("\nEl nombre de la Persona es {0}, nacio el {1}, y tiene {2} años\n", nombre, fecha_Nacimiento, edad);
        }
        public void CalcularEdad(){
            DateTime Hoy = DateTime.Now;
            var today = DateTime.Today;
            edad = today.Year - fecha_Nacimiento.Year;
            if (fecha_Nacimiento.Date > today.AddYears(-edad)) edad--;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Clara");
            p.CalcularEdad();
            p.Registrar_Persona();

        }
    }
}
