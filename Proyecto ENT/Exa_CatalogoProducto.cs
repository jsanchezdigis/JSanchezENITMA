using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ENT
{
    public class Exa_CatalogoProducto
    {
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public int IdUsuario { get; set; }
        public string FechaCreacion { get; set; }
        public List<object> CatalogoProductos { get; set; }
    }
}
