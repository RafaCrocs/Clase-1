using SuperHeroes.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SuperHeroes.DAL
{
    public class SuperPoderDAL
    {

        public List<SuperPoder> SuperPoderes_ObtenerPorHeroe(int IdSuperHeroe)
        {
            List<SuperPoder> listaSuperPoderes = new List<SuperPoder>();

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_ObtenerSuperPoderes", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdSuperHeroe", IdSuperHeroe);

                cmd.Parameters.Add("@Mensaje", System.Data.SqlDbType.VarChar, 500).Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("@Resultado", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SuperPoder superPoder = new SuperPoder
                    {
                        IdSuperPoder = Convert.ToInt32(reader["IdSuperPoder"]),
                        Descripcion = reader["Descripcion"].ToString()
                    };
                    listaSuperPoderes.Add(superPoder);
                }
            }
            return listaSuperPoderes;
        }
    }
}
