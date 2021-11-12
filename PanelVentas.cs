using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIA
{
    public partial class PanelVentas : Form
    {
        Ventas ventas = new Ventas();
        public PanelVentas()
        {
            InitializeComponent();
            this.CenterToScreen();
            dateTimePicker1.MaxDate = DateTime.Now.Date;
            dateTimePicker1.MinDate = DateTime.Parse("2021-11-5");
            numeroventas.ShortcutsEnabled = false;
            fillVentas();
        }

        public void fillVentas()
        {
            datagridventas.Rows.Clear();
            List<Ventas> ventas_list = ventas.getVentas();
            if (ventas_list.Count > 0)
            {
                foreach (Ventas v in ventas_list)
                {
                    datagridventas.Rows.Add(v.NumeroVenta,v.TotalVenta,v.Fecha);
                }
            }
            else
            {
                MessageBox.Show("Ninguna venta hasta el momento...");
            }
        }

        private void panelVentasClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            Padre.FormOpenNoLogin(this, menu);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Padre.onlyNumbers(e);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            fillVentas();
        }

        private void search_Click(object sender, EventArgs e)
        {
            datagridventas.Rows.Clear();
            ventas.Fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            
            
              
            List<Ventas> ventas_list = ventas.getVentasByFecha();
            if (ventas_list.Count > 0)
            {
                foreach (Ventas v in ventas_list)
                {
                    datagridventas.Rows.Add(v.NumeroVenta, v.TotalVenta, v.Fecha);
                }
            }
            else
            {
                MessageBox.Show("Ninguna venta con los criterios de busqueda proporicionados...");
            }
        }

        private void buscarcodigo_Click(object sender, EventArgs e)
        {
            datagridventas.Rows.Clear();
            ventas.NumeroVenta = numeroventas.Text;

            List<Ventas> ventas_list = ventas.getVentasById();
            if (ventas_list.Count > 0)
            {
                foreach (Ventas v in ventas_list)
                {
                    datagridventas.Rows.Add(v.NumeroVenta, v.TotalVenta, v.Fecha);
                }
            }
            else
            {
                MessageBox.Show("Ninguna venta con los criterios de busqueda proporicionados...");
            }
        }
    }
}
