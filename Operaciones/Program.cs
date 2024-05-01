using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SOLID.Empleado empleado = new SOLID.Empleado();
            empleado.NombreEmpleado = "NombreEmplado";
    

            SOLID.Persona persona = new SOLID.Persona();
            persona.NombrePersona = "NombrPersona";


            SOLID.Persona personaliskov = (SOLID.Persona)empleado;
            personaliskov.NombrePersona = "NombrPersonaLiskov";
            

            //POO, Herencia, Encapsulamiento, Polimorfismo, Abstraccion
            // Modificadores acceso , Propiedades, Get , Set, Override
            // Constructor , Sobrecarga de Contructores y metodos
            // virtual, Static

            //string nombre = Console.ReadLine();
            //            Console.WriteLine("Hola " + nombre);


            //Operaciones  Parse / Convert

            //int numero1 = int.Parse(Console.ReadLine());
            //int numero2 = int.Parse(Console.ReadLine());

            //int suma = numero1 + numero2;
            //Console.WriteLine("La suma es: " + suma);
            //Console.ReadKey();

            //Lower numPm varibles 
            //Upper NumPm Clases, Propiedades, Metodos
            Operacion operacion = new Operacion();
            operacion.numero1 = 10;
            operacion.numero2 = 20;

            operacion.Suma();

            int resultadoResta = operacion.Resta(10, 5);
            Console.WriteLine("La resta es: "+ resultadoResta);
            Console.WriteLine("La resta es metodo2: " + operacion.Resta(100, 5));
            Console.ReadKey();
        }
    }
}
