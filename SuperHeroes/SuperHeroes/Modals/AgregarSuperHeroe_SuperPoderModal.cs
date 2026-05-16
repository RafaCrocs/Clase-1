using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperHeroes.Modals
{
    public partial class AgregarSuperHeroe_SuperPoderModal : Form
    {
        public AgregarSuperHeroe_SuperPoderModal(int idSuperHeroe)
        {
            InitializeComponent();
            this.IdSuperHeroe = idSuperHeroe;
        }
        private int IdSuperHeroe;
    }
}
