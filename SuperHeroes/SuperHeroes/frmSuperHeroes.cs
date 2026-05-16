using SuperHeroes.BL;
using SuperHeroes.Entities;
using SuperHeroes.Modals;
using System.Web;

namespace SuperHeroes
{
    public partial class frmSuperHeroes : Form
    {
        public frmSuperHeroes()
        {
            InitializeComponent();
        }

        private SuperHeroesBL superHeroesBL = new SuperHeroesBL();
        private List<SuperHeroe> listaSuperHeroes = new List<SuperHeroe>();

        private void CargarGrid()
        {
            listaSuperHeroes = superHeroesBL.SuperHeroes_ObtenerTodos();
            gridSuperHeroes.DataSource = listaSuperHeroes;
        }

        private void frmSuperHeroes_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnAgregarSuperHeroe_Click(object sender, EventArgs e)
        {
            AgregarSuperHeroe_Modal modal = new AgregarSuperHeroe_Modal();
            modal.ShowDialog();
            CargarGrid();
        }

        private void gridSuperHeroes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            
            int IdSuperHeroe = listaSuperHeroes[e.RowIndex].IdSuperHeroe;
            string nombreSuperHeroe = listaSuperHeroes[e.RowIndex].Nombre;

            if (gridSuperHeroes.Columns[e.ColumnIndex].Name == "VerPoderes")
            {
                frmSuperHeroe_SuperPoder modalPoderes = new frmSuperHeroe_SuperPoder(IdSuperHeroe, nombreSuperHeroe);
                modalPoderes.ShowDialog();
            }
        }
    }
}
