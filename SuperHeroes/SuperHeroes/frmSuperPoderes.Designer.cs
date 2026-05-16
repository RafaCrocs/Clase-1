namespace SuperHeroes
{
    partial class frmSuperPoderes
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
            IdSuperPoder = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridSuperPoderes).BeginInit();
            SuspendLayout();
            // 
            // gridSuperPoderes
            // 
            gridSuperPoderes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSuperPoderes.Columns.AddRange(new DataGridViewColumn[] { IdSuperPoder, Descripcion });
            gridSuperPoderes.Location = new Point(141, 127);
            gridSuperPoderes.Name = "gridSuperPoderes";
            gridSuperPoderes.RowHeadersWidth = 51;
            gridSuperPoderes.Size = new Size(523, 278);
            gridSuperPoderes.TabIndex = 0;
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
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            // 
            // frmSuperPoderes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridSuperPoderes);
            Name = "frmSuperPoderes";
            Text = "frmSuperPoderes";
            Load += frmSuperPoderes_Load;
            ((System.ComponentModel.ISupportInitialize)gridSuperPoderes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridSuperPoderes;
        private DataGridViewTextBoxColumn IdSuperPoder;
        private DataGridViewTextBoxColumn Descripcion;
    }
}