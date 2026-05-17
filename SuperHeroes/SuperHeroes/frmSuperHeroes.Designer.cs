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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridSuperHeroes).BeginInit();
            SuspendLayout();
            // 
            // gridSuperHeroes
            // 
            gridSuperHeroes.AllowUserToAddRows = false;
            gridSuperHeroes.BackgroundColor = SystemColors.Control;
            gridSuperHeroes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSuperHeroes.Columns.AddRange(new DataGridViewColumn[] { VerPoderes, IdSuperHeroe, Nombre });
            gridSuperHeroes.Font = new Font("Segoe UI", 14F);
            gridSuperHeroes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridSuperHeroes.Location = new Point(28, 103);
            gridSuperHeroes.Margin = new Padding(3, 2, 3, 2);
            gridSuperHeroes.Name = "gridSuperHeroes";
            gridSuperHeroes.ReadOnly = true;
            gridSuperHeroes.RowHeadersWidth = 51;
            gridSuperHeroes.Size = new Size(850, 318);
            gridSuperHeroes.TabIndex = 0;
            gridSuperHeroes.CellContentClick += gridSuperHeroes_CellContentClick;
            // 
            // VerPoderes
            // 
            VerPoderes.HeaderText = "";
            VerPoderes.MinimumWidth = 6;
            VerPoderes.Name = "VerPoderes";
            VerPoderes.ReadOnly = true;
            VerPoderes.Text = "Ver Poderes";
            VerPoderes.UseColumnTextForButtonValue = true;
            VerPoderes.Width = 150;
            // 
            // IdSuperHeroe
            // 
            IdSuperHeroe.DataPropertyName = "IdSuperHeroe";
            IdSuperHeroe.HeaderText = "IdSuperHeroe";
            IdSuperHeroe.MinimumWidth = 6;
            IdSuperHeroe.Name = "IdSuperHeroe";
            IdSuperHeroe.ReadOnly = true;
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
            Nombre.ReadOnly = true;
            // 
            // btnAgregarSuperHeroe
            // 
            btnAgregarSuperHeroe.Font = new Font("Segoe UI", 12F);
            btnAgregarSuperHeroe.Location = new Point(730, 62);
            btnAgregarSuperHeroe.Margin = new Padding(3, 2, 3, 2);
            btnAgregarSuperHeroe.Name = "btnAgregarSuperHeroe";
            btnAgregarSuperHeroe.Size = new Size(148, 37);
            btnAgregarSuperHeroe.TabIndex = 1;
            btnAgregarSuperHeroe.Text = "Agregar Heroe";
            btnAgregarSuperHeroe.UseVisualStyleBackColor = true;
            btnAgregarSuperHeroe.Click += btnAgregarSuperHeroe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(28, 36);
            label1.Name = "label1";
            label1.Size = new Size(345, 46);
            label1.TabIndex = 2;
            label1.Text = "Lista de Super Heroes";
            // 
            // frmSuperHeroes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 457);
            Controls.Add(label1);
            Controls.Add(btnAgregarSuperHeroe);
            Controls.Add(gridSuperHeroes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSuperHeroes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmSuperHeroes_Load;
            ((System.ComponentModel.ISupportInitialize)gridSuperHeroes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridSuperHeroes;
        private Button btnAgregarSuperHeroe;
        private Label label1;
        private DataGridViewButtonColumn VerPoderes;
        private DataGridViewTextBoxColumn IdSuperHeroe;
        private DataGridViewTextBoxColumn Nombre;
    }
}
