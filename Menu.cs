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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void menuClosed(object sender, FormClosedEventArgs e)
        {
            LOGIN login = new LOGIN();
            Padre.FormOpenNoLogin(this, login);
        }

        private void productos_btn_Click(object sender, EventArgs e)
        {
            PanelProductos panelProductos = new PanelProductos();
            Padre.FormOpenNoLogin(this, panelProductos);
        }

        private void cobrar_btn_Click(object sender, EventArgs e)
        {
            PanelCobrar panelCobrar = new PanelCobrar();
            Padre.FormOpenNoLogin(this, panelCobrar);
        }

        private void ventas_Click(object sender, EventArgs e)
        {
            PanelVentas panelVentas = new PanelVentas();
            Padre.FormOpenNoLogin(this, panelVentas);
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            Padre.FormOpenNoLogin(this, login);
        }
    }
}
