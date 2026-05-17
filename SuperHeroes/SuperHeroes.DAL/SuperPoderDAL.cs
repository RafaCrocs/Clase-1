using SuperHeroes.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using System.Text;

namespace SuperHeroes.DAL
{
    public class SuperPoderDAL
    {

        public List<SuperPoder> SuperPoderes_ObtenerTodos()
        {
            List<SuperPoder> listaSuperPoderes = new List<SuperPoder>();

            string query = "Select * from SuperPoderes";

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                SuperPoder superPoder = new SuperPoder
                                {
                                    IdSuperPoder = Convert.ToInt32(dr["IdSuperPoder"]),
                                    Descripcion = dr["Descripcion"].ToString()
                                };
                                listaSuperPoderes.Add(superPoder);
                            }
                        }
                    }
                }

                return listaSuperPoderes;
            }
        }

        public bool Agregar_SuperPoder(SuperPoder superPoder, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {

                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_InsertarSuperPoder", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Descripcion", superPoder.Descripcion);

                        cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;

                        resultado = cmd.ExecuteNonQuery() > 0;

                        mensaje = cmd.Parameters["@Mensaje"].Value.ToString();

                        return resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }
    }
}