using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Persona
    {
        public void Agregar(Entidades.Persona pPersona)
        {
           
            Datos.Persona objPersona = new Datos.Persona();
            objPersona.Agregar(pPersona);
        }
        public DataTable TraerTodos()
        {
            Datos.Persona objDatos = new Datos.Persona();
            return objDatos.TraerTodos();
        }

        
    }
}
