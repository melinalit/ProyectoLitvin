using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Nacionalidad
    {
        private int ID;
        private string nombre;
   
       
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
