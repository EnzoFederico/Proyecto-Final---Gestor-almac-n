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
        private Articulo articulo = null;
        public frmAgregarArticulo()
        {
            InitializeComponent();
            Text = "Agregar articulo nuevo";
        }

        public frmAgregarArticulo(Articulo artiElegido)
        {
            InitializeComponent();
            articulo = artiElegido;
            Text = "Modificar Articulo";
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                MarcaDatos marca = new MarcaDatos();
                CategoriaDatos categoria = new CategoriaDatos();

                cbxMarca.DataSource = marca.listarMarcas();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxCategoria.DataSource = categoria.listarCategorias();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txbNombre.Text = articulo.Nombre;
                    txbCodigo.Text = articulo.Codigo;
                    txbDescripcion.Text = articulo.Descripcion;
                    txbPrecio.Text = articulo.Precio.ToString();
                    txbImagen.Text = articulo.UrlImagen;
                    cbxMarca.SelectedValue = articulo.Descripcion;
                    cbxCategoria.SelectedValue = articulo.Descripcion;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Articulo articNuevo = new Articulo();
            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                if(articulo == null)
                    articulo = new Articulo();

                articulo.Nombre = txbNombre.Text;
                articulo.Codigo = txbCodigo.Text;
                articulo.Descripcion = txbDescripcion.Text;
                articulo.UrlImagen = txbImagen.Text;
                articulo.Precio = decimal.Parse(txbPrecio.Text);
                articulo.marca = (Marca)cbxMarca.SelectedItem;
                articulo.categoria = (Categoria)cbxCategoria.SelectedItem;

                if(articulo.Id != 0)
                {
                    datos.modificar(articulo);
                    MessageBox.Show("Se ha modificado el articulo exitosamente.");
                }
                else
                {
                    datos.agregar(articulo);
                    MessageBox.Show("El articulo se agrego exitosamente.");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
