using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class AltaAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Entidades.Alumno objEntidad = new Entidades.Alumno();
            Logica.Persona objLogica = new Logica.Persona();
            objEntidad.DNI = Convert.ToInt32(txtDNI.Text);
            objEntidad.Apellido = txtApellido.Text;
            objEntidad.Nombre = txtNombre.Text;

            objLogica.Agregar(objEntidad);
            lblMensaje.Text = "Alumno agregado";
        }
    }
}