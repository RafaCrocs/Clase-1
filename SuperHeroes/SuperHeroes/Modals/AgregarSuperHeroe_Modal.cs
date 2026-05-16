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
    public partial class AgregarSuperHeroe_Modal : Form
    {
        public AgregarSuperHeroe_Modal()
        {
            InitializeComponent();
        }

        private SuperHeroesBL superHeroesBL = new SuperHeroesBL();
        private string mensaje = string.Empty;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SuperHeroe superHeroe = new SuperHeroe
            {
                Nombre = txtNombre.Text
            };
            if (superHeroesBL.Agregar_SuperHeroe(superHeroe, out mensaje))
            {
                MessageBox.Show("Superhéroe agregado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
