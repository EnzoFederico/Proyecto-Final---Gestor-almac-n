using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        [DisplayName ("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [DisplayName ("Marca")]
        public Marca marca { get; set; }
        [DisplayName ("Categoria")]
        public Categoria categoria { get; set; }
        public string UrlImagen { get; set; }
        public decimal Precio { get; set; }



    }
}
