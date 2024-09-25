namespace PresentacionFinal
{
    partial class frmEliminacion
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBajaLogica = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbNota = new System.Windows.Forms.Label();
            this.lbTextoAclaracion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(64, 192);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 51);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminacion permanente";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBajaLogica
            // 
            this.btnBajaLogica.Location = new System.Drawing.Point(215, 194);
            this.btnBajaLogica.Name = "btnBajaLogica";
            this.btnBajaLogica.Size = new System.Drawing.Size(147, 47);
            this.btnBajaLogica.TabIndex = 1;
            this.btnBajaLogica.Text = "Baja Logica";
            this.btnBajaLogica.UseVisualStyleBackColor = true;
            this.btnBajaLogica.Click += new System.EventHandler(this.btnBajaLogica_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(391, 194);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 47);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbNota
            // 
            this.lbNota.AutoSize = true;
            this.lbNota.Location = new System.Drawing.Point(26, 17);
            this.lbNota.Name = "lbNota";
            this.lbNota.Size = new System.Drawing.Size(71, 16);
            this.lbNota.TabIndex = 3;
            this.lbNota.Text = "Aclaración";
            // 
            // lbTextoAclaracion
            // 
            this.lbTextoAclaracion.AutoSize = true;
            this.lbTextoAclaracion.Location = new System.Drawing.Point(12, 51);
            this.lbTextoAclaracion.Name = "lbTextoAclaracion";
            this.lbTextoAclaracion.Size = new System.Drawing.Size(0, 16);
            this.lbTextoAclaracion.TabIndex = 4;
            // 
            // frmEliminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.lbTextoAclaracion);
            this.Controls.Add(this.lbNota);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBajaLogica);
            this.Controls.Add(this.btnEliminar);
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "frmEliminacion";
            this.Text = "Eliminacion";
            this.Load += new System.EventHandler(this.frmEliminacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBajaLogica;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbNota;
        private System.Windows.Forms.Label lbTextoAclaracion;
    }
}