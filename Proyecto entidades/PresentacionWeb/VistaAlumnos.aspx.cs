using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class VistaAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Logica.Persona objLogica = new Logica.Persona();
            GVAlumnos.DataSource = objLogica.TraerTodos();
            GVAlumnos.DataBind();
        }
    }
}