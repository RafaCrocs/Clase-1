namespace SuperHeroes
{
    partial class frmSuperHeroe_SuperPoder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridSuperPoderes = new DataGridView();
            Descripcion = new DataGridViewTextBoxColumn();
            IdSuperHeroe_SuperPoder = new DataGridViewTextBoxColumn();
            IdSuperPoder = new DataGridViewTextBoxColumn();
            btnAgregarSuperPoder = new Button();
            lblNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)gridSuperPoderes).BeginInit();
            SuspendLayout();
            // 
            // gridSuperPoderes
            // 
            gridSuperPoderes.AllowUserToAddRows = false;
            gridSuperPoderes.BackgroundColor = SystemColors.Control;
            gridSuperPoderes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSuperPoderes.Columns.AddRange(new DataGridViewColumn[] { Descripcion, IdSuperHeroe_SuperPoder, IdSuperPoder });
            gridSuperPoderes.Location = new Point(49, 112);
            gridSuperPoderes.Margin = new Padding(3, 2, 3, 2);
            gridSuperPoderes.Name = "gridSuperPoderes";
            gridSuperPoderes.ReadOnly = true;
            gridSuperPoderes.RowHeadersWidth = 51;
            gridSuperPoderes.Size = new Size(505, 231);
            gridSuperPoderes.TabIndex = 0;
            gridSuperPoderes.Font = new Font("Segoe UI", 14F);
            gridSuperPoderes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // IdSuperHeroe_SuperPoder
            // 
            IdSuperHeroe_SuperPoder.DataPropertyName = "IdSuperHeroe_SuperPoder";
            IdSuperHeroe_SuperPoder.HeaderText = "IdSuperHeroe_SuperPoder";
            IdSuperHeroe_SuperPoder.MinimumWidth = 6;
            IdSuperHeroe_SuperPoder.Name = "IdSuperHeroe_SuperPoder";
            IdSuperHeroe_SuperPoder.ReadOnly = true;
            IdSuperHeroe_SuperPoder.Visible = false;
            IdSuperHeroe_SuperPoder.Width = 125;
            // 
            // IdSuperPoder
            // 
            IdSuperPoder.DataPropertyName = "IdSuperPoder";
            IdSuperPoder.HeaderText = "IdSuperPoder";
            IdSuperPoder.MinimumWidth = 6;
            IdSuperPoder.Name = "IdSuperPoder";
            IdSuperPoder.ReadOnly = true;
            IdSuperPoder.Visible = false;
            IdSuperPoder.Width = 125;
            // 
            // btnAgregarSuperPoder
            // 
            btnAgregarSuperPoder.Font = new Font("Segoe UI", 12F);
            btnAgregarSuperPoder.Location = new Point(406, 71);
            btnAgregarSuperPoder.Margin = new Padding(3, 2, 3, 2);
            btnAgregarSuperPoder.Name = "btnAgregarSuperPoder";
            btnAgregarSuperPoder.Size = new Size(148, 37);
            btnAgregarSuperPoder.TabIndex = 2;
            btnAgregarSuperPoder.Text = "Agregar Poder";
            btnAgregarSuperPoder.UseVisualStyleBackColor = true;
            btnAgregarSuperPoder.Click += btnAgregarSuperPoder_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 20F);
            lblNombre.Location = new Point(49, 71);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 37);
            lblNombre.TabIndex = 1;
            // 
            // frmSuperHeroe_SuperPoder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 397);
            Controls.Add(btnAgregarSuperPoder);
            Controls.Add(lblNombre);
            Controls.Add(gridSuperPoderes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSuperHeroe_SuperPoder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSuperPoderes";
            Load += frmSuperPoderes_Load;
            ((System.ComponentModel.ISupportInitialize)gridSuperPoderes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridSuperPoderes;
        private Button btnAgregarSuperPoder;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn IdSuperHeroe_SuperPoder;
        private DataGridViewTextBoxColumn IdSuperPoder;
        private Label lblNombre;
    }
}