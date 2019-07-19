using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstadoJudicial
    {
        private int ID;
        private string estado;


        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}
