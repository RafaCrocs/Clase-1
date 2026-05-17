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
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridSuperPoderes).BeginInit();
            SuspendLayout();
            // 
            // gridSuperPoderes
            // 
            gridSuperPoderes.BackgroundColor = SystemColors.Control;
            gridSuperPoderes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSuperPoderes.Columns.AddRange(new DataGridViewColumn[] { IdSuperPoder, Descripcion });
            gridSuperPoderes.Location = new Point(37, 91);
            gridSuperPoderes.Margin = new Padding(3, 2, 3, 2);
            gridSuperPoderes.Name = "gridSuperPoderes";
            gridSuperPoderes.ReadOnly = true;
            gridSuperPoderes.RowHeadersWidth = 51;
            gridSuperPoderes.Size = new Size(458, 208);
            gridSuperPoderes.TabIndex = 0;
            gridSuperPoderes.CellDoubleClick += gridSuperPoderes_CellDoubleClick;
            gridSuperPoderes.Font = new Font("Segoe UI", 14F);
            gridSuperPoderes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(325, 50);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(170, 37);
            button1.TabIndex = 3;
            button1.Text = "Agregar Super Poder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(37, 45);
            label1.Name = "label1";
            label1.Size = new Size(209, 37);
            label1.TabIndex = 4;
            label1.Text = "Lista de Poderes";
            // 
            // frmSuperPoderes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 347);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(gridSuperPoderes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSuperPoderes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSuperPoderes";
            Load += frmSuperPoderes_Load;
            ((System.ComponentModel.ISupportInitialize)gridSuperPoderes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridSuperPoderes;
        private DataGridViewTextBoxColumn IdSuperPoder;
        private DataGridViewTextBoxColumn Descripcion;
        private Button button1;
        private Label label1;
    }
}