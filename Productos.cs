using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIA
{
    class Productos : Base
    {
        public string Codigo { set; get; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Inventario { get; set; }

        public List<Productos> GetProductos()
        {
            string sql = "SELECT * FROM productos";
            MySqlDataReader rdr = select(sql);
            List<Productos> productos = new List<Productos>();
            
            while(rdr.Read())
            {
                productos.Add(
                        new Productos
                        {
                            Codigo = rdr[0].ToString(),
                            Nombre = rdr[1].ToString(),
                            Precio = rdr[2].ToString(),
                            Inventario = rdr[3].ToString()
                        }
                    );
            }
            
            return productos;
        }
        public List<Productos> getProducto(string parametro)
        {
            string sql = String.Format("SELECT * FROM productos WHERE codigo LIKE '%{0}%' OR nombre LIKE '%{0}%'",parametro);
            MySqlDataReader rdr = select(sql);
            List<Productos> productos = new List<Productos>();

            while (rdr.Read())
            {
                productos.Add(
                        new Productos
                        {
                            Codigo = rdr[0].ToString(),
                            Nombre = rdr[1].ToString(),
                            Precio = rdr[2].ToString(),
                            Inventario = rdr[3].ToString()
                        }
                    );
            }
            return productos;
        }
        public List<Productos> getProductoNotLike(string codigo)
        {
            string sql = String.Format("SELECT * FROM productos WHERE codigo = '{0}'", codigo);
            MySqlDataReader rdr = select(sql);
            List<Productos> productos = new List<Productos>();

            while (rdr.Read())
            {
                productos.Add(
                        new Productos
                        {
                            Codigo = rdr[0].ToString(),
                            Nombre = rdr[1].ToString(),
                            Precio = rdr[2].ToString(),
                            Inventario = rdr[3].ToString()
                        }
                    );
            }
            return productos;
        }
        public int updateStock(string todo)
        {
            string sql = "";
            if(todo == "restar")
            {
                sql = String.Format(
                "UPDATE productos SET  cantidad = cantidad - '{1}'  WHERE codigo = '{0}'",
                this.Codigo, this.Inventario
                );
            }
            else if(todo == "sumar")
            {
                sql = String.Format(
                "UPDATE productos SET  cantidad = cantidad + '{1}'  WHERE codigo = '{0}'",
                this.Codigo, this.Inventario
                );
            }
            else
            {
                return 7;
            }
            int done = create_or_update(sql);
            return done;
        }
        public int getStockById(string id)
        {
            string sql = String.Format(
                    "SELECT cantidad FROM productos WHERE codigo = '{0}'",id
                );
            MySqlDataReader rdr = select(sql);
            List<Productos> productos = new List<Productos>();

            while (rdr.Read())
            {
                productos.Add(
                        new Productos
                        {
                            Inventario = rdr[0].ToString()
                        }
                    );
            }
            if(productos.Count > 0)
            {
                return Convert.ToInt32(productos.First<Productos>().Inventario);
            }
            return 0;
        }


        public int insert()
        {
            string sql = String.Format(
                "INSERT INTO productos VALUES ('{0}','{1}','{2}','{3}')",
                this.Codigo.ToString(),this.Nombre.ToString(),this.Precio.ToString(),this.Inventario.ToString()
                );
            int done = create_or_update(sql);
            return done;
        }
        public int delete(string codigo)
        {
            string sql = String.Format(
                "DELETE FROM productos WHERE codigo = '{0}'", codigo
                );
            int done = create_or_update(sql);
            return done;
        }
        public int update(string codigo)
        {
            string sql = String.Format(
                "UPDATE productos SET codigo = '{1}', nombre = '{2}', precio = '{3}', cantidad = '{4}'  WHERE codigo = '{0}'", 
                codigo,this.Codigo,this.Nombre,this.Precio,this.Inventario
                );
            int done = create_or_update(sql);
            return done;
        }


    }
}
