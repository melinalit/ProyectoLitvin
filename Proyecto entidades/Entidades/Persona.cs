using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private int dni;
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private string nacionalidadId;
        private string estadoJudicialId;
        
        
        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre { get; set; }
               
        public string Apellido { get; set; }

       
        public DateTime FechaDeNacimiento
        { 
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }

        public string EstadoJudicialId
        {
            get { return estadoJudicialId; }
            set { estadoJudicialId = value; }
        }

        public string NacionalidadId
        {
            get { return nacionalidadId; }
            set { nacionalidadId = value; }

        }
    }
}
