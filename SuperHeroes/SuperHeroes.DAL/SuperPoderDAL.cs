using SuperHeroes.Entities;
using System;
using System.Collections.Generic;
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
    }
}