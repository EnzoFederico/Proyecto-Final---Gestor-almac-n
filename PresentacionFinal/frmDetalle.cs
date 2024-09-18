using Dominio;
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
    public partial class frmDetalle : Form
    {
        private Articulo articuloElegido;
        public frmDetalle()
        {
            InitializeComponent();
        }

        public frmDetalle(Articulo seleccionado)
        {
            InitializeComponent();
            articuloElegido = seleccionado;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            lbNombreDet.Text = articuloElegido.Nombre;
            lbCodigoDet.Text = articuloElegido.Codigo;
            lbMarcaDet.Text = articuloElegido.marca.Descripcion;
            lbCategoriaDet.Text = articuloElegido.categoria.Descripcion;
            lbPrecioDet.Text = articuloElegido.Precio.ToString();
            lbDescripDet.Text = articuloElegido.Descripcion;

            try
            {
                pboFoto.Load(articuloElegido.UrlImagen);
            }
            catch (Exception ex)
            {
                pboFoto.Load("https://media.istockphoto.com/id/1421859468/es/vector/se%C3%B1al-de-advertencia-3d-vector-yellow-con-concepto-de-signo-de-exclamaci%C3%B3n.jpg?s=612x612&w=0&k=20&c=04OHvyeeranmIn5KAoP1wG_USDMRk2TV3P6-B2XPlg4=");
            }
        }
    }
}
