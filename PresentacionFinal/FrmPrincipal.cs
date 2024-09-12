using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionFinal
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarArticulos();
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Marca");
            cbxCampo.Items.Add("Precio");
        }

        private void mostrarArticulos()
        {
            ArticuloDatos negocio = new ArticuloDatos();
            List<Articulo> listaArticulos = negocio.listarArticulos();

            dgvArticulos.DataSource = listaArticulos;
            ocultarColumna();
            mostrarImagen(listaArticulos[0].UrlImagen);
        }

        private void ocultarColumna()
        {
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void mostrarImagen(string direccion)
        {
            try
            {
                pbxArticulos.Load(direccion);
            }
            catch (Exception ex)
            {
                pbxArticulos.Load("https://media.istockphoto.com/id/1421859468/es/vector/se%C3%B1al-de-advertencia-3d-vector-yellow-con-concepto-de-signo-de-exclamaci%C3%B3n.jpg?s=612x612&w=0&k=20&c=04OHvyeeranmIn5KAoP1wG_USDMRk2TV3P6-B2XPlg4=");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            mostrarImagen(articuloSeleccionado.UrlImagen);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo nuevoArt = new frmAgregarArticulo();
            nuevoArt.ShowDialog();
            mostrarArticulos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregarArticulo frmModifica = new frmAgregarArticulo(seleccionado);
            frmModifica.ShowDialog();
            mostrarArticulos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmEliminacion frmElimina = new frmEliminacion(seleccionado);
            frmElimina.ShowDialog();
            mostrarArticulos();
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = (string)cbxCampo.SelectedItem;

            switch (opcion)
            {
                case "Nombre":
                    cbxCriterio.Items.Clear();
                    cbxCriterio.Items.Add("Comienza con");
                    cbxCriterio.Items.Add("Termina con");
                    cbxCriterio.Items.Add("Contiene");
                    break;
                case "Marca":
                    cbxCriterio.Items.Clear();
                    cbxCriterio.Items.Add("Comienza con");
                    cbxCriterio.Items.Add("Termina con");
                    cbxCriterio.Items.Add("Contiene");
                    break;
                case "Precio":
                    cbxCriterio.Items.Clear();
                    cbxCriterio.Items.Add("Precio mayor a");
                    cbxCriterio.Items.Add("Precio menor a");
                    cbxCriterio.Items.Add("Precio igual a");
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloDatos articBuscado = new ArticuloDatos();

            try
            {
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txbFiltro.Text;

               dgvArticulos.DataSource = articBuscado.listarArticulos(campo, criterio, filtro);
               ocultarColumna();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
