using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionFinal
{
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articNuevo = new Articulo();
            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                articNuevo.Nombre = txbNombre.Text;
                articNuevo.Codigo = txbCodigo.Text;
                articNuevo.Descripcion = txbDescripcion.Text;
                articNuevo.UrlImagen = txbImagen.Text;
                articNuevo.Precio = int.Parse(txbPrecio.Text);
                articNuevo.marca = (Marca)cbxMarca.SelectedItem;
                articNuevo.categoria = (Categoria)cbxCategoria.SelectedItem;

                datos.agregar(articNuevo);
                MessageBox.Show("El articulo se agrego exitosamente.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaDatos marca = new MarcaDatos();
            CategoriaDatos categoria = new CategoriaDatos();

            cbxMarca.DataSource = marca.listarMarcas();
            cbxCategoria.DataSource = categoria.listarCategorias();
        }
    }
}
