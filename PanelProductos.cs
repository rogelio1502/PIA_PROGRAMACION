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
    public partial class PanelProductos : Form
    {
        Productos productos = new Productos();
        Productos beforedata = new Productos();
        public PanelProductos()
        {
            InitializeComponent();
            
            producto_buscar.ShortcutsEnabled = false;
            codigotxt.ShortcutsEnabled = false;
            nombretxt.ShortcutsEnabled = false;
            preciotxt.ShortcutsEnabled = false;
            cantidadtxt.ShortcutsEnabled = false;

            this.CenterToScreen();
            fillProducts();
            cancelarbtn.Hide();

            btn_listo_update.Hide();
            
        }

        private void fillProducts()
        {
            datagridproducts.Rows.Clear();
            List<Productos> list_productos = productos.GetProductos();
            if(list_productos.Count > 0)
            {
                foreach (Productos p in list_productos)
                {
                    datagridproducts.Rows.Add(p.Codigo,p.Nombre,p.Precio,p.Inventario);
                }
            }
            else
            {
                MessageBox.Show("Ningun producto añadido aún, añada uno...");
            }
        }

        private void PanelProductos_Load(object sender, EventArgs e)
        {

        }

        private void productosClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            Padre.FormOpenNoLogin(this, menu);
        }

        private void datagridproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void codigoKeyPress(object sender, KeyPressEventArgs e)
        {
            Padre.onlyNumbers(e);

        }

        private void preciotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void preciotxtKeyPress(object sender, KeyPressEventArgs e)
        {
            Padre.onlyNumbers(e);
        }

        private void cantidadKeyPress(object sender, KeyPressEventArgs e)
        {
            Padre.onlyNumbers(e);
        }

        private void producto_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if(codigotxt.Text != "" && nombretxt.Text != "" && cantidadtxt.Text != "" && preciotxt.Text != "")
            {
                Productos producto = new Productos
                {
                    Codigo = codigotxt.Text,
                    Nombre = nombretxt.Text,
                    Inventario = cantidadtxt.Text,
                    Precio = preciotxt.Text
                };
                int inserted = producto.insert();
                if(inserted == 1)
                {
                    MessageBox.Show("Registrado con éxito.");
                    fillProducts();
                }
                else if(inserted == 4)
                {
                    MessageBox.Show("Codigo o nombre del producto duplicado, favor de verificar.");

                }
                else
                {
                    MessageBox.Show("Error al insertar el registo.");
                }
            }
            else
            {
                Padre.todosLosCampos();
            }
        }
        private void clear()
        {
            codigotxt.Text = "";
            nombretxt.Text = "";
            preciotxt.Text = "";
            cantidadtxt.Text = "";
        }

        private void todobtn_Click(object sender, EventArgs e)
        {
            fillProducts();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            bool deleted = Padre.delete(datagridproducts, "Producto", productos.delete);
            if (deleted)
            {
                fillProducts();

            }
            else
            {
                MessageBox.Show("El Producto no se puede eliminar,\nya que se encuetra ligado a una venta\nPuedes modificarlo, sí deseas..");
            }
        }
        private void fillSearchProduct()
        {
            datagridproducts.Rows.Clear();
            List<Productos> list_productos = productos.getProducto(producto_buscar.Text);

            if (list_productos.Count > 0)
            {
                foreach (Productos p in list_productos)
                {
                    datagridproducts.Rows.Add(p.Codigo, p.Nombre, p.Precio, p.Inventario);
                }
            }
            else
            {
                MessageBox.Show("Ningun producto encontrado...");
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if(producto_buscar.Text != "")
            {
                fillSearchProduct();
                producto_buscar.Text = "";
            }
            else
            {
                Padre.todosLosCampos();
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            bool selected = Padre.validation(datagridproducts);
            if (selected)
            {
                beforedata.Codigo = datagridproducts.CurrentRow.Cells[0].Value.ToString();
                beforedata.Nombre = datagridproducts.CurrentRow.Cells[1].Value.ToString();
                beforedata.Precio = datagridproducts.CurrentRow.Cells[2].Value.ToString();
                beforedata.Inventario = datagridproducts.CurrentRow.Cells[3].Value.ToString();
               
                codigotxt.Text = beforedata.Codigo;
                nombretxt.Text = beforedata.Nombre;
                preciotxt.Text = beforedata.Precio;
                cantidadtxt.Text = beforedata.Inventario;

                
            }
            btn_listo_update.Show();
            cancelarbtn.Show();

            
            
            
        }

        private void btn_listo_update_Click(object sender, EventArgs e)
        {
            if (codigotxt.Text != "" && nombretxt.Text != "" && preciotxt.Text != "" && cantidadtxt.Text != "")
            {
                if(codigotxt.Text == beforedata.Codigo && nombretxt.Text == beforedata.Nombre && preciotxt.Text == beforedata.Precio && cantidadtxt.Text == beforedata.Inventario)
                {
                    MessageBox.Show("No has actulizado nigún dato :o");
                }
                else
                {
                    productos.Nombre = nombretxt.Text;
                    productos.Codigo = codigotxt.Text;
                    productos.Precio = preciotxt.Text;
                    productos.Inventario = cantidadtxt.Text;
                    int updated = productos.update(beforedata.Codigo);
                    if (updated == 1)
                    {
                        MessageBox.Show("Registro Actualizado con éxito");
                        clear();
                        fillProducts();

                    }
                    else{
                        MessageBox.Show("Error al actualizar el registro.");

                    }
                    btn_listo_update.Hide();
                    cancelarbtn.Hide();

                }
            }
            else
            {
                Padre.todosLosCampos();
            }
        }

        private void cancelarbtn_Click(object sender, EventArgs e)
        {
            clear();
            btn_listo_update.Hide();
            cancelarbtn.Hide();

        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            clear();
        }

        
    }
}
