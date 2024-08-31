namespace PresentacionFinal
{
    partial class frmAgregarArticulo
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbImagen = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbImagen = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.imbImagen2 = new System.Windows.Forms.PictureBox();
            this.lbImaDescrip = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imbImagen2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(50, 35);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(56, 15);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(50, 77);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(56, 15);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Código:";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(15, 119);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(91, 15);
            this.lbDescripcion.TabIndex = 2;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImagen.Location = new System.Drawing.Point(22, 161);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(84, 15);
            this.lbImagen.TabIndex = 3;
            this.lbImagen.Text = "URL Imagen:";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(50, 203);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(56, 15);
            this.lbPrecio.TabIndex = 4;
            this.lbPrecio.Text = "Precio:";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(57, 244);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(49, 15);
            this.lbMarca.TabIndex = 5;
            this.lbMarca.Text = "Marca:";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(29, 286);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(77, 15);
            this.lbCategoria.TabIndex = 6;
            this.lbCategoria.Text = "Categoria:";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(108, 32);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(157, 20);
            this.txbNombre.TabIndex = 7;
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(108, 74);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(157, 20);
            this.txbCodigo.TabIndex = 8;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(108, 116);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(157, 20);
            this.txbDescripcion.TabIndex = 9;
            // 
            // txbImagen
            // 
            this.txbImagen.Location = new System.Drawing.Point(108, 158);
            this.txbImagen.Name = "txbImagen";
            this.txbImagen.Size = new System.Drawing.Size(157, 20);
            this.txbImagen.TabIndex = 10;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(108, 200);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(157, 20);
            this.txbPrecio.TabIndex = 11;
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(108, 241);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(157, 21);
            this.cbxMarca.TabIndex = 12;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(108, 283);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(157, 21);
            this.cbxCategoria.TabIndex = 13;
            // 
            // imbImagen2
            // 
            this.imbImagen2.Location = new System.Drawing.Point(397, 39);
            this.imbImagen2.Name = "imbImagen2";
            this.imbImagen2.Size = new System.Drawing.Size(344, 393);
            this.imbImagen2.TabIndex = 14;
            this.imbImagen2.TabStop = false;
            // 
            // lbImaDescrip
            // 
            this.lbImaDescrip.AutoSize = true;
            this.lbImaDescrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbImaDescrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbImaDescrip.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbImaDescrip.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImaDescrip.Location = new System.Drawing.Point(487, 9);
            this.lbImaDescrip.Name = "lbImaDescrip";
            this.lbImaDescrip.Size = new System.Drawing.Size(173, 21);
            this.lbImaDescrip.TabIndex = 15;
            this.lbImaDescrip.Text = "Imagen Descriptiva";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(25, 377);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 29);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(222, 378);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 27);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbImaDescrip);
            this.Controls.Add(this.imbImagen2);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbImagen);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbImagen);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbNombre);
            this.Name = "frmAgregarArticulo";
            this.Text = "frmAgregarArticulo";
            this.Load += new System.EventHandler(this.frmAgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imbImagen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbImagen;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.PictureBox imbImagen2;
        private System.Windows.Forms.Label lbImaDescrip;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}