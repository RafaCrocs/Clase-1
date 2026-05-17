using SuperHeroes.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SuperHeroes.DAL
{
    public class SuperHeroe_SuperPoderDAL
    {

        public List<SuperHeroe_SuperPoder> ObtenerPoderesPorHeroe(int IdSuperHeroe)
        {
            List<SuperHeroe_SuperPoder> listaSuperHeroe_SuperPoder = new List<SuperHeroe_SuperPoder>();

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
                    SuperHeroe_SuperPoder superHeroe_SuperPoder = new SuperHeroe_SuperPoder
                    {
                        IdSuperHeroe_SuperPoder = Convert.ToInt32(reader["IdSuperHeroe_SuperPoder"]),
                        IdSuperPoder = Convert.ToInt32(reader["IdSuperPoder"]),
                        Descripcion = reader["Descripcion"].ToString()
                    };
                    listaSuperHeroe_SuperPoder.Add(superHeroe_SuperPoder);
                }
            }
            return listaSuperHeroe_SuperPoder;
        }

        public bool AgregarSuperPoderASuperHeroe(int IdSuperHeroe, int IdSuperPoder, out string mensaje)
        {

            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_InsertarSuperPoderASuperHeroe", conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdSuperHeroe", IdSuperHeroe);
                    cmd.Parameters.AddWithValue("@IdSuperPoder", IdSuperPoder);

                    cmd.Parameters.Add("@Mensaje", System.Data.SqlDbType.VarChar, 255).Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add("@Resultado", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;

                    resultado = cmd.ExecuteNonQuery() > 0;
                    mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            return resultado;
        }
    }
}
