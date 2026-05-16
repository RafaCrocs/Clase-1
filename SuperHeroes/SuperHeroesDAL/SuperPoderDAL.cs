using SuperHeroes.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SuperHeroesDAL
{
    public class SuperPoderDAL
    {

        public List<SuperPoder> SuperPoderes_ObtenerTodos()
        {

            List<SuperPoder> lista = new List<SuperPoder>();
            
            using(SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                string query = "SELECT * from SuperPoderes";
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            SuperPoder superPoder = new SuperPoder
                            {
                                IdSuperPoder = Convert.ToInt32(dr["IdSuperPoder"]),
                                Descripcion = dr["Descripcion"].ToString()
                            };
                            lista.Add(superPoder);
                        }
                    }
                }
            }
            return lista;
        }
    }
}
