using SuperHeroes.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SuperHeroes.DAL
{
    public class SuperHeroesDAL
    {

        public List<SuperHeroe> SuperHeroes_ObtenerTodos()
        {
            List<SuperHeroe> listaSuperHeroes = new List<SuperHeroe>();
            string query = "SELECT * from SuperHeroes";

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                SuperHeroe superHeroe = new SuperHeroe
                                {
                                    IdSuperHeroe = Convert.ToInt32(rdr["IdSuperHeroe"]),
                                    Nombre = rdr["Nombre"].ToString()
                                };
                                listaSuperHeroes.Add(superHeroe);
                            }
                        }
                    }

                }
                ;
            }
            catch (Exception ex)
            {

            }


            return listaSuperHeroes;
        }

        public bool Agregar_SuperHeroe(SuperHeroe superHeroe, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_InsertarSuperHeroe", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nombre", superHeroe.Nombre);

                        cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        
                        resultado = cmd.ExecuteNonQuery() > 0;
                        mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                    }
                }
                ;
            }
            catch (Exception ex)
            {
                mensaje = "Error al agregar el superhéroe";
            }
            return resultado;

        }
    }
}