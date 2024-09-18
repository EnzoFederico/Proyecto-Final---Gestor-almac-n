namespace PresentacionFinal
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulos = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5nombre = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvArticulos.Location = new System.Drawing.Point(218, 78);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.Size = new System.Drawing.Size(874, 275);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArticulos
            // 
            this.pbxArticulos.Location = new System.Drawing.Point(1102, 78);
            this.pbxArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxArticulos.Name = "pbxArticulos";
            this.pbxArticulos.Size = new System.Drawing.Size(330, 574);
            this.pbxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulos.TabIndex = 3;
            this.pbxArticulos.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(12, 78);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 50);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Articulo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(12, 138);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(200, 50);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar Articulo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 198);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(200, 50);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminación / Baja logíca";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(12, 258);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(200, 50);
            this.btnDetalle.TabIndex = 9;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Location = new System.Drawing.Point(47, 13);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(99, 16);
            this.lbFiltro.TabIndex = 10;
            this.lbFiltro.Text = "Filtro avanzado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Campo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Criterio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Filtro";
            // 
            // cbxCampo
            // 
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(68, 45);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(124, 24);
            this.cbxCampo.TabIndex = 14;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(68, 84);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(124, 24);
            this.cbxCriterio.TabIndex = 15;
            // 
            // txbFiltro
            // 
            this.txbFiltro.Location = new System.Drawing.Point(68, 121);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(124, 22);
            this.txbFiltro.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(68, 164);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 39);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1432, 73);
            this.panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTOR DE ARTICULOS";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.cbxCampo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lbFiltro);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txbFiltro);
            this.panel3.Controls.Add(this.cbxCriterio);
            this.panel3.Location = new System.Drawing.Point(12, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 288);
            this.panel3.TabIndex = 20;
            // 
            // label5nombre
            // 
            this.label5nombre.AutoSize = true;
            this.label5nombre.Location = new System.Drawing.Point(570, 459);
            this.label5nombre.Name = "label5nombre";
            this.label5nombre.Size = new System.Drawing.Size(0, 16);
            this.label5nombre.TabIndex = 21;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(68, 221);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 39);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reseteo";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1432, 653);
            this.Controls.Add(this.label5nombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.pbxArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Gestor de Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5nombre;
        private System.Windows.Forms.Button btnReset;
    }
}

