using System;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class Persona
    {
        private const string strConexion = @"Server=MELI-PC\SQLEXPRESS;database=ProyectoFinal;Integrated Security = true";

        public void Agregar(Entidades.Persona persona)
        {
            string strSQL = "insert personas(DNI, Nombre, Apellido, FechaDeNacimiento, NacionalidadID, EstadoJudicialID) values (@dni, @nombre, @apellido, @fechadenacimiento, @nacionalidadid, @estadojudicialid)";
            SqlConnection objConexion = new SqlConnection();
            objConexion.ConnectionString = strConexion;
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandText = strSQL;
            objCommand.Connection = objConexion;

            objCommand.Parameters.AddWithValue("@dni", persona.DNI);
            objCommand.Parameters.AddWithValue("@apellido", persona.Apellido);
            objCommand.Parameters.AddWithValue("@nombre", persona.Nombre);
            objCommand.Parameters.AddWithValue("@fechadenacimiento", persona.FechaDeNacimiento);
            objCommand.Parameters.AddWithValue("@nacionalidadid", persona.NacionalidadId);
            objCommand.Parameters.AddWithValue("@estadojudicialid", persona.EstadoJudicialId);

            objConexion.Open();
            objCommand.ExecuteNonQuery();
            objConexion.Close(); 
        }

        public DataTable TraerTodos()
        {
            string strSQL = "select * from Personas";
            SqlDataAdapter objDa = new SqlDataAdapter(strSQL, strConexion);
            DataTable dt = new DataTable();
            objDa.Fill(dt);


            return dt;
        }
         
    } 
   
}
