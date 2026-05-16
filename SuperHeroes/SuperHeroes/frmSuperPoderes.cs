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
    public partial class frmSuperPoderes : Form
    {
        public frmSuperPoderes()
        {
            InitializeComponent();
        }

        private SuperPoderesBL superPoderesBL = new SuperPoderesBL();
        private List<SuperPoder> listaSuperPoderes = new List<SuperPoder>();

        private void CargarGrid()
        {
            listaSuperPoderes = superPoderesBL.SuperPoderes_ObtenerTodos();
            gridSuperPoderes.DataSource = listaSuperPoderes;
        }
        private void frmSuperPoderes_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
    }
}
