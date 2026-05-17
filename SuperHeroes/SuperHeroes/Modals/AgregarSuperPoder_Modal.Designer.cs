namespace SuperHeroes.Modals
{
    partial class AgregarSuperPoder_Modal
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
            btnCancelar = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.Font = new Font("Segoe UI", 15F);
            btnCancelar.Location = new Point(171, 193);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 45);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(192, 255, 192);
            btnAgregar.Font = new Font("Segoe UI", 15F);
            btnAgregar.Location = new Point(33, 193);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 45);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(33, 79);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 5;
            label1.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 15F);
            txtDescripcion.Location = new Point(33, 126);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(260, 34);
            txtDescripcion.TabIndex = 4;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(323, 59);
            label2.TabIndex = 8;
            label2.Text = "Nuevo Super Poder";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AgregarSuperPoder_Modal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 279);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarSuperPoder_Modal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarSuperPoder_Modal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAgregar;
        private Label label1;
        private TextBox txtDescripcion;
        private Label label2;
    }
}