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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            this.CenterToScreen();
            usernametxt.ShortcutsEnabled = false;
            passwordtxt.ShortcutsEnabled = false;
        }

        private void usuariotxtKeyPress(object sender, KeyPressEventArgs e)
        {
            Padre.noSpaces(e);
        }

        private void contraseniaKeyPress(object sender, KeyPressEventArgs e)
        {
            Padre.noSpaces(e);
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            if(usernametxt.Text != "" &&  passwordtxt.Text != "")
            {
                if(usernametxt.Text == "admin" && passwordtxt.Text == "admin")
                {
                    Menu mainMenu = new Menu();
                    Padre.openFormFromLogin(this, mainMenu);
                }
            }
            else
            {
                Padre.todosLosCampos();
            }
        }

        private void loginClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }
    }
}
