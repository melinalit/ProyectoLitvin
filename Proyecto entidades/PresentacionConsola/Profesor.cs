//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PresentacionConsola
//{
//    public class Profesor
//    {
//        static void main (string[] args)
//        {
//            Entidades.Persona objEntidadProfesor = new Entidades.Persona();
//            //pedir datos al usuario
//            Console.Write("Ingrese ID:");
//            objEntidadProfesor.ID = Convert.ToInt32(Console.ReadLine());


//            Console.Write("Ingrese nombre:");
//            objEntidadProfesor.nombre = Console.ReadLine();

//            Console.Write("Ingrese apellido:");
//            objEntidadProfesor.Apellido = Console.ReadLine();

//            Console.Write("Ingrese mail:");
//            objEntidadProfesor.Mail = Console.ReadLine();

//            Logica.Profesor objLogicaProfesor = new Logica.Profesor();
//            objLogicaProfesor.Agregar(objEntidadProfesor);
//            Console.WriteLine("Profesor agregado");
//            Console.ReadKey();
//        }
//    }
//}
