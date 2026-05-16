using System;
using System.Collections.Generic;
using System.Text;
using SuperHeroes.DAL;
using SuperHeroes.Entities;
namespace SuperHeroes.BL
{
    public class SuperHeroesBL
    {

        private SuperHeroesDAL superHeroesDAL = new SuperHeroesDAL();

        public List<SuperHeroe> SuperHeroes_ObtenerTodos()
        {
            return superHeroesDAL.SuperHeroes_ObtenerTodos();
        }

        public bool Agregar_SuperHeroe(SuperHeroe superHeroe, out string mensaje)
        {
            return superHeroesDAL.Agregar_SuperHeroe(superHeroe, out mensaje);
        }
    }
}
