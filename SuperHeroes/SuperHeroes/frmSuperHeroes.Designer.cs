namespace SuperHeroes
{
    partial class frmSuperHeroes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridSuperHeroes = new DataGridView();
            VerPoderes = new DataGridViewButtonColumn();
            IdSuperHeroe = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            btnAgregarSuperHeroe = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridSuperHeroes).BeginInit();
            SuspendLayout();
            // 
            // gridSuperHeroes
            // 
            gridSuperHeroes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSuperHeroes.Columns.AddRange(new DataGridViewColumn[] { VerPoderes, IdSuperHeroe, Nombre });
            gridSuperHeroes.Font = new Font("Segoe UI", 14F);
            gridSuperHeroes.Location = new Point(71, 190);
            gridSuperHeroes.Name = "gridSuperHeroes";
            gridSuperHeroes.RowHeadersWidth = 51;
            gridSuperHeroes.Size = new Size(971, 424);
            gridSuperHeroes.TabIndex = 0;
            gridSuperHeroes.CellContentClick += gridSuperHeroes_CellContentClick;
            // 
            // VerPoderes
            // 
            VerPoderes.HeaderText = "";
            VerPoderes.MinimumWidth = 6;
            VerPoderes.Name = "VerPoderes";
            VerPoderes.Text = "Ver Poderes";
            VerPoderes.UseColumnTextForButtonValue = true;
            VerPoderes.Width = 175;
            // 
            // IdSuperHeroe
            // 
            IdSuperHeroe.DataPropertyName = "IdSuperHeroe";
            IdSuperHeroe.HeaderText = "IdSuperHeroe";
            IdSuperHeroe.MinimumWidth = 6;
            IdSuperHeroe.Name = "IdSuperHeroe";
            IdSuperHeroe.Visible = false;
            IdSuperHeroe.Width = 125;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // btnAgregarSuperHeroe
            // 
            btnAgregarSuperHeroe.Font = new Font("Segoe UI", 12F);
            btnAgregarSuperHeroe.Location = new Point(873, 135);
            btnAgregarSuperHeroe.Name = "btnAgregarSuperHeroe";
            btnAgregarSuperHeroe.Size = new Size(169, 49);
            btnAgregarSuperHeroe.TabIndex = 1;
            btnAgregarSuperHeroe.Text = "Agregar Heroe";
            btnAgregarSuperHeroe.UseVisualStyleBackColor = true;
            btnAgregarSuperHeroe.Click += btnAgregarSuperHeroe_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(840, 80);
            button1.Name = "button1";
            button1.Size = new Size(202, 49);
            button1.TabIndex = 2;
            button1.Text = "Ver Super Poderes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmSuperHeroes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 640);
            Controls.Add(button1);
            Controls.Add(btnAgregarSuperHeroe);
            Controls.Add(gridSuperHeroes);
            Name = "frmSuperHeroes";
            Text = "Form1";
            Load += frmSuperHeroes_Load;
            ((System.ComponentModel.ISupportInitialize)gridSuperHeroes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridSuperHeroes;
        private DataGridViewButtonColumn VerPoderes;
        private DataGridViewTextBoxColumn IdSuperHeroe;
        private DataGridViewTextBoxColumn Nombre;
        private Button btnAgregarSuperHeroe;
        private Button button1;
    }
}
