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
            lbTextoAclaracion.Text = "Antes de elegir una opción, debe tener en cuenta que si elige la 'eliminación permanente'\nlos datos seran borrados permanentemente de la base de datos. \n\nSi elige la opción de baja logica, al articulo sera removido de la lista de articulos, \npero sera conservada en la base de datos,\ny en el futuro si quiere los puede volver a recuperar.";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿De verdad queres eleminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                ArticuloDatos articEliminar = new ArticuloDatos();
                articEliminar.eliminar(articulo.Id);
                MessageBox.Show("El articulo se eliminó permanentemente!!");
                Close();
            }
            else
            {
                Close();
            }
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
