using SuperHeroes.DAL;
using SuperHeroes.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroes.BL
{
    public class SuperHeroe_SuperPoderBL
    {

        private SuperHeroe_SuperPoderDAL superHeroe_SuperPoderDAL = new SuperHeroe_SuperPoderDAL();

        public List<SuperHeroe_SuperPoder> ObtenerPoderesPorHeroe(int IdSuperHeroe)
        {
            return superHeroe_SuperPoderDAL.ObtenerPoderesPorHeroe(IdSuperHeroe);
        }

        public bool AgregarPoderASuperHeroe(int IdSuperHeroe, int IdSuperPoder, out string mensaje)
        {
            return superHeroe_SuperPoderDAL.AgregarSuperPoderASuperHeroe(IdSuperHeroe, IdSuperPoder, out mensaje);
        }
    }
}
