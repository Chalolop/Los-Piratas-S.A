using PiratasCostaRica.BDConection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratasCostaRica.Procedimientos
{
    class ServicioControl:Servicio
    {
        public override bool SolicitarServicio(Servicio serv)
        {

            bool result = false;
            try
            {
                Myconnection myConnection = new Myconnection();
                SqlConnection conexion = myConnection.CreateConnection();
                SqlCommand comando = myConnection.CreateCommand(conexion);

                comando.CommandText = "Recaudacion";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@pDinero", serv.Dinero);
                comando.Parameters.AddWithValue("@pRuta", serv.Ruta);
                comando.Parameters.AddWithValue("@pCedulaChofer", serv.Cedchofer);

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                result = true;
            }
            catch (SqlException e)
            {
                result = false;
            }
            return result;
        }
    }
}
