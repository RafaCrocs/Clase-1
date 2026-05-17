using SuperHeroes.BL;
using SuperHeroes.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperHeroes.Modals
{
    public partial class AgregarSuperPoder_Modal : Form
    {
        public AgregarSuperPoder_Modal()
        {
            InitializeComponent();
        }

        private SuperPoderesBL superPoderesBL = new SuperPoderesBL();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SuperPoder superPoder = new SuperPoder
            {
                Descripcion = txtDescripcion.Text
            };
            superPoderesBL.AgregarSuperPoder(superPoder, out string mensaje);
            MessageBox.Show(mensaje);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
