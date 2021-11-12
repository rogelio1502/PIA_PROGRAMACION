using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIA
{
    class Ventas : Base
    {
        public string NumeroVenta { get; set; }
        public string TotalVenta { get; set; }
        public string Fecha { get; set; }
        public List<Ventas> getVentas()
        {
            string sql = "SELECT * FROM ventas";
            MySqlDataReader rdr = select(sql);
            List<Ventas> ventas = new List<Ventas>();

            while (rdr.Read())
            {
                ventas.Add(
                        new Ventas
                        {
                            NumeroVenta = rdr[0].ToString(),
                            TotalVenta = rdr[1].ToString(),
                            Fecha = rdr[2].ToString(),
                            
                        }
                    );
            }

            return ventas;

        }
        public List<Ventas> getVentasByFecha()
        {
            string sql =String.Format(
                 "SELECT * FROM ventas Where date(fecha) = '{0}'",
                 this.Fecha.Replace('/','-')
                );
            MySqlDataReader rdr = select(sql);
            List<Ventas> ventas = new List<Ventas>();

            while (rdr.Read())
            {
                ventas.Add(
                        new Ventas
                        {
                            NumeroVenta = rdr[0].ToString(),
                            TotalVenta = rdr[1].ToString(),
                            Fecha = rdr[2].ToString(),

                        }
                    );
            }

            return ventas;

        }
        public List<Ventas> getVentasById()
        {
            string sql = String.Format(
                 "SELECT * FROM ventas Where numero_venta = '{0}'",
                 this.NumeroVenta
                );
            MySqlDataReader rdr = select(sql);
            List<Ventas> ventas = new List<Ventas>();

            while (rdr.Read())
            {
                ventas.Add(
                        new Ventas
                        {
                            NumeroVenta = rdr[0].ToString(),
                            TotalVenta = rdr[1].ToString(),
                            Fecha = rdr[2].ToString(),

                        }
                    );
            }

            return ventas;

        }
        public int insert()
        {
            string sql = String.Format(
                    "INSERT INTO  ventas (total_venta,fecha) VALUES('{0}','{1}')",
                    this.TotalVenta,this.Fecha)
                 ;
            int done = create_or_update(sql);

            return done;
        }
        public int update()
        {
            string sql = String.Format(
                       "UPDATE ventas SET total_venta = '{1}' WHERE numero_venta = '{0}'",
                       this.NumeroVenta,this.TotalVenta)
                    ;
            int done = create_or_update(sql);

            return done;

        }
        public int getLastId()
        {
            string sql = "SELECT numero_venta FROM ventas ORDER BY fecha DESC LIMIT 1";
            MySqlDataReader rdr = select(sql);
            List<Ventas> ventas = new List<Ventas>();

            while (rdr.Read())
            {
                ventas.Add(
                        new Ventas
                        {
                            NumeroVenta = rdr[0].ToString()
                        }
                    );
            }
            if (ventas.Count > 0)
            {
                return Convert.ToInt32(ventas.First<Ventas>().NumeroVenta);
            }
            return 0;
   
        }
    }
}
