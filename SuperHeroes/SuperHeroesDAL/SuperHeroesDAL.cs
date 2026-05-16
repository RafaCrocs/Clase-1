using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using SuperHeroes.Entities;
using SuperHeroesDAL;

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
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while(rdr.Read())
                            {
                                SuperHeroe superHeroe = new SuperHeroe
                                {
                                    IdSuperHeroe = Convert.ToInt32(rdr["IdSuperHeroe"]),
                                    Nombre = rdr["Nombre"].ToString(),
                                    IdSuperPoder = Convert.ToInt32(rdr["IdSuperPoder"])
                                };
                                listaSuperHeroes.Add(superHeroe);
                            }
                        }
                    }

                };
            }
            catch (Exception ex)
            {

            }


            return listaSuperHeroes;
        }
        
    }
}
