using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace PresentacionFinal
{
    public partial class frmEliminacion : Form
    {
        private Articulo articulo = null;
        public frmEliminacion(Articulo articuloSeleccionado)
        {
            InitializeComponent();
            articulo = articuloSeleccionado;
        }

        private void frmEliminacion_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloDatos articEliminar = new ArticuloDatos();
            articEliminar.eliminar(articulo.Id);
            MessageBox.Show("El articulo se eliminó permanentemente!!");
            Close();
        }

        private void btnBajaLogica_Click(object sender, EventArgs e)
        {
            ArticuloDatos articBaja = new ArticuloDatos();
            articBaja.bajaLogica(articulo.Id);
            MessageBox.Show("El articulo se dio de baja.");
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
