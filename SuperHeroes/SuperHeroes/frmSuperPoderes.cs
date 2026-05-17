using SuperHeroes.BL;
using SuperHeroes.Entities;
using SuperHeroes.Modals;
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
        public int IdSuperHeroe;

        public frmSuperPoderes(int idSuperHeroe)
        {
            InitializeComponent();
            this.IdSuperHeroe = idSuperHeroe;
        }

        private SuperPoderesBL superPoderesBL = new SuperPoderesBL();
        private List<SuperPoder> listaSuperPoderes = new List<SuperPoder>();

        private SuperHeroe_SuperPoderBL SuperHeroe_SuperPoderBL = new SuperHeroe_SuperPoderBL();

        private void CargarGrid()
        {
            listaSuperPoderes = superPoderesBL.SuperPoderes_ObtenerTodos();
            gridSuperPoderes.DataSource = listaSuperPoderes;
        }
        private void frmSuperPoderes_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarSuperPoder_Modal frmSuperPoderes = new AgregarSuperPoder_Modal();
            frmSuperPoderes.ShowDialog();
            CargarGrid();
        }

        private void gridSuperPoderes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idSuperPoder = (int)gridSuperPoderes.Rows[e.RowIndex].Cells["IdSuperPoder"].Value;

            string mensaje;
            if (SuperHeroe_SuperPoderBL.AgregarPoderASuperHeroe(IdSuperHeroe, idSuperPoder, out mensaje))
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show(mensaje);
            }

            DialogResult = DialogResult.OK;

        }
    }
}
