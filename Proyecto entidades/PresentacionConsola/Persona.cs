using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionConsola
{
    class Persona
    {
        static void Main(string[] args)
        {
            Entidades.Persona objEntidadPersona = new Entidades.Persona();
            
            Console.Write("Ingrese DNI:");
            objEntidadPersona.DNI = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("Ingrese nombre:");
            objEntidadPersona.Nombre = Console.ReadLine();

            Console.Write("Ingrese apellido:");
            objEntidadPersona.Apellido = Console.ReadLine();

            Console.Write("Ingrese fecha de nacimiento");
            objEntidadPersona.FechaDeNacimiento = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Ingrese nacionalidad:");
            objEntidadPersona.NacionalidadId = Console.ReadLine();

            Console.Write("Ingrese estado judicial:");
            objEntidadPersona.EstadoJudicialId = Console.ReadLine();

            Logica.Persona objLogicaPersona = new Logica.Persona();
            objLogicaPersona.Agregar(objEntidadPersona);
            Console.WriteLine("Registro agregado");
            Console.ReadKey();
        }
    }
}
