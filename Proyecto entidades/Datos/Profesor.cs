//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Datos
//{
//    public class Profesor
//    {
//        public void Agregar(Entidades.Persona profesor)
//        {
//            string strConexion = @"Server=CPX-22OFRV981AB\TRAINING;database=tecno;Integrated Security = true";
//            string strSQL = "insert profesores (id, apellido, nombre, mail) values (@id,@apellido,@nombre,@mail)";
//            SqlConnection objConexion = new SqlConnection();
//            objConexion.ConnectionString = strConexion;
//            SqlCommand objCommand = new SqlCommand();
//            objCommand.CommandText = strSQL;
//            objCommand.Connection = objConexion;
//            //parametros
//            objCommand.Parameters.AddWithValue("@id", profesor.ID);

//            //abro la conexion
//            objConexion.Open();
//            objCommand.ExecuteNonQuery();
//            objConexion.Close();

//        }
//    }

//    }


