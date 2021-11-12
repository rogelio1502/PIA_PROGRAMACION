using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIA
{
    class Padre : Form
    {
        public static bool validation(DataGridView dataGridView)
        {
            if (dataGridView.CurrentRow.Cells[0].Value != null)
            {

                return true;
            }
            else
            {
                MessageBox.Show("Selecciona Un Item, Por Favor.");
                return false;

            }

        }
        public static bool delete(DataGridView dataGridView, string title, Func<string, int> delete)
        {
            bool go = validation(dataGridView);
            if (go)
            {

                string id = dataGridView.CurrentRow.Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show(String.Format("Desea eliminar el {1} con ID {0}?", id, title), "!Espere un momento!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {


                    int deleted = delete(id);

                    if (deleted > 0)
                    {
                        MessageBox.Show("Registro Eliminado de forma correcta.");
                        //new PuestosPanel().ShowPuestos();
                        return true;

                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el Registro.");
                    }
                }
            }
            return false;
        }
        public static void onlyLetters(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void noSpaces(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void onlyNumbers(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void todosLosCampos()
        {
            MessageBox.Show("Ingrese todos los campos.");

        }
        public static void openFormFromLogin(Form closed, Form new_form)
        {
            new_form.Show();
            closed.Hide();
        }
        public static void FormOpenNoLogin(Form closed, Form open_form)
        {
            open_form.Show();
            closed.Dispose();
        }
        
    }
}
