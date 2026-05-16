using SuperHeroes.BL;
using SuperHeroes.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperHeroes
{
    public partial class frmSuperHeroe_SuperPoder : Form
    {
        public frmSuperHeroe_SuperPoder(int IdSuperHeroe, string nombreSuperHeroe)
        {
            InitializeComponent();
            this.IdSuperHeroe = IdSuperHeroe;
            this.NombreSuperHeroe = nombreSuperHeroe;
        }
        private int IdSuperHeroe;
        private string NombreSuperHeroe;

        private SuperHeroe_SuperPoderBL superHeroe_SuperPoderBL = new SuperHeroe_SuperPoderBL();
        private List<SuperHeroe_SuperPoder> listaSuperHeroe_SuperPoder = new List<SuperHeroe_SuperPoder>();
        private void CargarGrid()
        {
            listaSuperHeroe_SuperPoder = superHeroe_SuperPoderBL.ObtenerPoderesPorHeroe(IdSuperHeroe);
            gridSuperPoderes.DataSource = listaSuperHeroe_SuperPoder;
        }
        private void frmSuperPoderes_Load(object sender, EventArgs e)
        {
            lblNombre.Text = $"Poderes de {NombreSuperHeroe}";
            CargarGrid();
        }
    }
}
