using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIA
{
    class ProductoVenta : Base
    {
        public string NumeroVenta { get; set; }
        public string CodigoProducto { get; set; }
        public string CantidadProductos { get; set; }
        public string TotalSubVenta { get; set; }

        public string Nombre { get; set; }
        public string Precio { get; set; }
        public int insert()
        {
            string sql = String.Format(
                "INSERT INTO producto_vendido VALUES ('{0}','{1}','{2}','{3}')",
                this.NumeroVenta,this.CodigoProducto,this.CantidadProductos,this.TotalSubVenta
                );
            int done = create_or_update(sql);

            return done;
                
        }
    }
}
