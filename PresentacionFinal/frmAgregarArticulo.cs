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
                cbxMarca.SelectedIndex = -1;
                cbxCategoria.DataSource = categoria.listarCategorias();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.SelectedIndex = -1;
                
                

                if (articulo != null)
                {
                    txbNombre.Text = articulo.Nombre;
                    txbCodigo.Text = articulo.Codigo;
                    txbDescripcion.Text = articulo.Descripcion;
                    txbPrecio.Text = articulo.Precio.ToString();
                    txbImagen.Text = articulo.UrlImagen;
                    mostrarImagen(articulo.UrlImagen);
                    cbxMarca.SelectedValue = articulo.marca.Id;
                    cbxCategoria.SelectedValue = articulo.categoria.Id;
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

                if (validarModificacion())
                    return;

                articulo.Nombre = txbNombre.Text;
                articulo.Codigo = txbCodigo.Text;
                articulo.Descripcion = txbDescripcion.Text;
                articulo.UrlImagen = txbImagen.Text;
                articulo.Precio = decimal.Parse(txbPrecio.Text);
                articulo.marca = (Marca)cbxMarca.SelectedItem;
                articulo.categoria = (Categoria)cbxCategoria.SelectedItem;

                if(articulo.Id != 0)
                {
                    if (validarModificacion())
                        return;

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

        private void mostrarImagen(string direccion)
        {
            try
            {
                picImagen2.Load(direccion);
            }
            catch (Exception ex)
            {
                picImagen2.Load("https://media.istockphoto.com/id/1421859468/es/vector/se%C3%B1al-de-advertencia-3d-vector-yellow-con-concepto-de-signo-de-exclamaci%C3%B3n.jpg?s=612x612&w=0&k=20&c=04OHvyeeranmIn5KAoP1wG_USDMRk2TV3P6-B2XPlg4=");
            }
        }

        private void txbImagen_Leave(object sender, EventArgs e)
        {
            mostrarImagen(txbImagen.Text);
        }

        private bool validarModificacion()
        {
            if(cbxCategoria.SelectedIndex == -1 || cbxMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Lo siento, debe completar todos los campos.\nDebe elegir una marca y categoria.\nEl valor del precio debe ser numerico.");
                return true;
            }

            if (txbNombre.Text == string.Empty || txbCodigo.Text == string.Empty || txbDescripcion.Text == string.Empty || txbImagen.Text== string.Empty || txbPrecio.Text == string.Empty)
            {
                MessageBox.Show("Lo siento, debe completar todos los campos.\nDebe elegir una marca y categoria.\nEl valor del precio debe ser numerico.");
                return true;
            }

            if (!(decimal.TryParse(txbPrecio.Text, out decimal result)))
            {
                MessageBox.Show("Lo siento, debe completar todos los campos.\nDebe elegir una marca y categoria.\nEl valor del precio debe ser numerico.");
                return true;
            }

            return false;
        }
    }
}
