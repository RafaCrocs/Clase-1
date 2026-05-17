using SuperHeroes.DAL;
using SuperHeroes.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroes.BL
{
    public  class SuperPoderesBL
    {

        private SuperPoderDAL superPoderesDAL = new SuperPoderDAL();

        public List<SuperPoder> SuperPoderes_ObtenerTodos()
        {
            return superPoderesDAL.SuperPoderes_ObtenerTodos();
        }

        public bool AgregarSuperPoder(SuperPoder superPoder, out string mensaje)
        {
            return superPoderesDAL.Agregar_SuperPoder(superPoder, out mensaje);
        }
    }
}
