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
            lblNombre = new Label();
            btnAgregarSuperPoder = new Button();
            Descripcion = new DataGridViewTextBoxColumn();
            IdSuperHeroe_SuperPoder = new DataGridViewTextBoxColumn();
            IdSuperPoder = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridSuperPoderes).BeginInit();
            SuspendLayout();
            // 
            // gridSuperPoderes
            // 
            gridSuperPoderes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSuperPoderes.Columns.AddRange(new DataGridViewColumn[] { Descripcion, IdSuperHeroe_SuperPoder, IdSuperPoder });
            gridSuperPoderes.Location = new Point(110, 179);
            gridSuperPoderes.Name = "gridSuperPoderes";
            gridSuperPoderes.RowHeadersWidth = 51;
            gridSuperPoderes.Size = new Size(577, 308);
            gridSuperPoderes.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 28F);
            lblNombre.Location = new Point(56, 57);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 62);
            lblNombre.TabIndex = 1;
            // 
            // btnAgregarSuperPoder
            // 
            btnAgregarSuperPoder.Font = new Font("Segoe UI", 12F);
            btnAgregarSuperPoder.Location = new Point(648, 110);
            btnAgregarSuperPoder.Name = "btnAgregarSuperPoder";
            btnAgregarSuperPoder.Size = new Size(169, 49);
            btnAgregarSuperPoder.TabIndex = 2;
            btnAgregarSuperPoder.Text = "Agregar Poder";
            btnAgregarSuperPoder.UseVisualStyleBackColor = true;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            // 
            // IdSuperHeroe_SuperPoder
            // 
            IdSuperHeroe_SuperPoder.DataPropertyName = "IdSuperHeroe_SuperPoder";
            IdSuperHeroe_SuperPoder.HeaderText = "IdSuperHeroe_SuperPoder";
            IdSuperHeroe_SuperPoder.MinimumWidth = 6;
            IdSuperHeroe_SuperPoder.Name = "IdSuperHeroe_SuperPoder";
            IdSuperHeroe_SuperPoder.Visible = false;
            IdSuperHeroe_SuperPoder.Width = 125;
            // 
            // IdSuperPoder
            // 
            IdSuperPoder.DataPropertyName = "IdSuperPoder";
            IdSuperPoder.HeaderText = "IdSuperPoder";
            IdSuperPoder.MinimumWidth = 6;
            IdSuperPoder.Name = "IdSuperPoder";
            IdSuperPoder.Visible = false;
            IdSuperPoder.Width = 125;
            // 
            // frmSuperHeroe_SuperPoder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 592);
            Controls.Add(btnAgregarSuperPoder);
            Controls.Add(lblNombre);
            Controls.Add(gridSuperPoderes);
            Name = "frmSuperHeroe_SuperPoder";
            Text = "frmSuperPoderes";
            Load += frmSuperPoderes_Load;
            ((System.ComponentModel.ISupportInitialize)gridSuperPoderes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridSuperPoderes;
        private Label lblNombre;
        private Button btnAgregarSuperPoder;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn IdSuperHeroe_SuperPoder;
        private DataGridViewTextBoxColumn IdSuperPoder;
    }
}