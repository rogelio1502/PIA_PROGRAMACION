using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIA
{
    public partial class PanelCobrar : Form
    {
        Productos producto = new Productos();
        Ventas ventas = new Ventas();
        int suma_total = 0;
        int eliminado = 0;
        string path = "C:/Users/52812/Desktop/";

        public PanelCobrar()
        {
            InitializeComponent();
            this.CenterToScreen();
            precio_txt.ReadOnly = true;
            subtotaltxt.ReadOnly = true;
            nombre_txt.ReadOnly = true;
            totalventatxt.ReadOnly = true;
            cantidad_txt.Enabled = false;
            codigotxt.ShortcutsEnabled = false;
            cantidad_txt.ShortcutsEnabled = false;


        }

        private void PanelCobrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(datagridproducts.Rows.Count > 1)
            {
                DialogResult dialogResult = MessageBox.Show(String.Format("Desea Salir? Los datos de la venta se perderán :("), "!Espere un momento!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    Menu menu = new Menu();
                    Padre.FormOpenNoLogin(this, menu);

                }
            }
            else
            {
                Menu menu = new Menu();
                Padre.FormOpenNoLogin(this, menu);
            }
            
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if(codigotxt.Text != "")
            {
                
                List<Productos> producto_list_one = producto.getProductoNotLike(codigotxt.Text);
                if(producto_list_one.Count > 0)
                {
                    Productos _producto = producto_list_one.First<Productos>();
                    nombre_txt.Text = _producto.Nombre;
                    precio_txt.Text = _producto.Precio;
                    cantidad_txt.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Ningún producto con el código ingresado.");

                }
            }
            else
            {
                clear();

                MessageBox.Show("Ingrese el código del producto.");

            }
        }

        private void codigoKeyPress(object sender, KeyPressEventArgs e)
        {
            Padre.onlyNumbers(e);
        }


        private void cantidadPressDown(object sender, KeyPressEventArgs e)
        {
            Padre.onlyNumbers(e);
        }

        private void cantidad_txt_TextChanged(object sender, EventArgs e)
        {
            if(cantidad_txt.Text.Length > 0)
            {
                int q = Convert.ToInt32(cantidad_txt.Text);
                int p = Convert.ToInt32(precio_txt.Text);
                int subtotal = q * p;
                subtotaltxt.Text = Convert.ToString(subtotal);
            }
            else
            {
                subtotaltxt.Text ="";

            }



        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            precio_txt.Text = "";
            subtotaltxt.Text = "";
            nombre_txt.Text = "";
            cantidad_txt.Enabled = false;
            codigotxt.Text = "";
            cantidad_txt.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(codigotxt.Text != "" && nombre_txt.Text != "" && precio_txt.Text != "" && cantidad_txt.Text != "" && subtotaltxt.Text != "")
            {
                int esta_agregado = 0;
                if(datagridproducts.Rows.Count > 1)
                {
                    for (int i = 0; i < datagridproducts.Rows.Count; i++)
                    {
                        if (datagridproducts.Rows[i].Cells[0].Value == codigotxt.Text)
                        {
                            esta_agregado = 1;
                            break;
                        }
                    }
                    
                }
                
                if(esta_agregado != 1)
                {
                    if(producto.getStockById(codigotxt.Text) >= Convert.ToInt32(cantidad_txt.Text))
                    {
                        

                        
                        if(suma_total < 9999999)
                        {
                            int suma_total_espectativa = Convert.ToInt32(subtotaltxt.Text) + suma_total;
                            if (suma_total_espectativa <= 9999999)
                            {
                                datagridproducts.Rows.Add(
                                codigotxt.Text,
                                nombre_txt.Text,
                                precio_txt.Text,
                                cantidad_txt.Text,
                                subtotaltxt.Text

                                );

                                


                                if (suma_total == 9999999)
                                {
                                    MessageBox.Show("Limite de venta alcanzado, favor de cobrar");
                                }
                                clear();
                            }
                            else
                            {
                                MessageBox.Show("Imposible agregar este producto a la venta, supera el limite de transacción (9,999,999).");
                            }
                            
                        }
                            
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente stock para despachar este producto.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("El producto ya se encuentra añadido, favor de modificar el item.");
                    
                }
                


            }
            else
            {
                Padre.todosLosCampos();
            }
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (datagridproducts.Rows.Count > 1)
            {
                bool isSelected = Padre.validation(datagridproducts);
                if (isSelected)
                {
                    datagridproducts.Rows.RemoveAt(datagridproducts.CurrentRow.Index);
                    eliminado = 1;
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Nada que eliminar");
            }
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (datagridproducts.Rows.Count > 1)
            {
                bool isSelected = Padre.validation(datagridproducts);
                if (isSelected)
                {
                    codigotxt.Text = datagridproducts.CurrentRow.Cells[0].Value.ToString();
                    nombre_txt.Text = datagridproducts.CurrentRow.Cells[1].Value.ToString();
                    precio_txt.Text = datagridproducts.CurrentRow.Cells[2].Value.ToString();
                    cantidad_txt.Text = datagridproducts.CurrentRow.Cells[3].Value.ToString();
                    cantidad_txt.Enabled = true;
                    datagridproducts.Rows.RemoveAt(datagridproducts.CurrentRow.Index);


                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Nada que modificar");
            }
        }

        private void btn_quitar_todo_Click(object sender, EventArgs e)
        {
            datagridproducts.Rows.Clear();
            
        }
        
        private void a(object sender, DataGridViewRowsAddedEventArgs e)
        {
            suma_total = 0;
            
            if (datagridproducts.Rows.Count > 1)
            {
                for (int i = 0; i < datagridproducts.Rows.Count; i++)
                {
                    if (datagridproducts.Rows[i].Cells[4].Value != "")
                    {
                        suma_total += Convert.ToInt32(datagridproducts.Rows[i].Cells[4].Value);
                    }
                }

            }
            else
            {
                if (subtotaltxt.Text != "")
                {

                    suma_total += Convert.ToInt32(subtotaltxt.Text);
                }
                

            }
            totalventatxt.Text = suma_total.ToString();

        }

        private void b(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            suma_total = 0;

            if (datagridproducts.Rows.Count > 1)
            {
                for (int i = 0; i < datagridproducts.Rows.Count; i++)
                {
                    if (datagridproducts.Rows[i].Cells[4].Value != "")
                    {
                        suma_total += Convert.ToInt32(datagridproducts.Rows[i].Cells[4].Value);
                    }
                }

            }
            else
            {
                suma_total = 0;
            }
            totalventatxt.Text = suma_total.ToString();

        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(String.Format("Desea cobrar la venta?"), "!Espere un momento!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (datagridproducts.Rows.Count > 1)
                {
                    ventas.Fecha = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
                    ventas.TotalVenta = "0";
                    int inserted = ventas.insert();
                    if (inserted == 1)
                    {
                        int id_venta = ventas.getLastId();
                        List<ProductoVenta> productoVentas = new List<ProductoVenta>();
                        for (int i = 0; i < datagridproducts.Rows.Count - 1; i++)
                        {
                            if (datagridproducts.Rows[i].Cells[0].Value != "")
                            {
                                productoVentas.Add(
                                        new ProductoVenta
                                        {
                                            NumeroVenta = id_venta.ToString(),
                                            CodigoProducto = datagridproducts.Rows[i].Cells[0].Value.ToString(),
                                            CantidadProductos = datagridproducts.Rows[i].Cells[3].Value.ToString(),
                                            TotalSubVenta = datagridproducts.Rows[i].Cells[4].Value.ToString(),
                                            Nombre = datagridproducts.Rows[i].Cells[1].Value.ToString(),
                                            Precio = datagridproducts.Rows[i].Cells[2].Value.ToString()
                                        }
                                     );


                            }
                        }
                        suma_total = 0;
                        string ticket = "";
                        foreach (ProductoVenta item in productoVentas)
                        {
                            ProductoVenta productoVenta = new ProductoVenta();
                            productoVenta.NumeroVenta = item.NumeroVenta;
                            productoVenta.TotalSubVenta = item.TotalSubVenta;
                            productoVenta.CantidadProductos = item.CantidadProductos;
                            productoVenta.CodigoProducto = item.CodigoProducto;
                            suma_total += Convert.ToInt32(item.TotalSubVenta);
                            Productos producto = new Productos
                            {
                                Codigo = item.CodigoProducto,
                                Inventario = item.CantidadProductos
                            };
                            producto.updateStock("restar");
                            int inserted_product_venta = productoVenta.insert();
                            if (inserted_product_venta != 1)
                            {
                                MessageBox.Show(String.Format("Error producto con ID {0}.", item.CodigoProducto));
                                suma_total -= Convert.ToInt32(item.TotalSubVenta);
                            }
                            else
                            {
                                ticket += String.Format("Ticket de la venta número {0}\nFecha {1}\n", id_venta, ventas.Fecha);
                                ticket += "Codigo\t\tNombre\t\tPU\tPiezas\tSubtotal\n";
                                ticket += String.Format(
                                        "{0},{1},{2},{3},{4}\n",
                                        item.CodigoProducto, item.Nombre, item.Precio, item.CantidadProductos, item.TotalSubVenta
                                    );

                            }

                        }
                        ventas.NumeroVenta = id_venta.ToString();
                        ventas.TotalVenta = suma_total.ToString();
                        int venta_actualizada = ventas.update();
                        if (venta_actualizada != 1)
                        {
                            MessageBox.Show("Error al actualizar la venta");
                        }
                        else
                        {
                            MessageBox.Show("Venta Realizada con éxito.");
                            datagridproducts.Rows.Clear();
                            ticket += String.Format(
                                    "Total Venta: {0}", ventas.TotalVenta
                                    );
                            try
                            {
                                path += String.Format("{0}", ventas.Fecha.Replace('/', '-').Replace(':', '-'));
                                File.WriteAllText(@path, ticket);
                                MessageBox.Show(String.Format("Ticket Generado con éxito. Guardado en:\n{0}", path));

                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Error al guardar el ticket...");
                            }


                        }



                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
                else
                {
                    MessageBox.Show("Ninguna venta añadidia");
                }

            }
           
        }

        private void codigoClick(object sender, EventArgs e)
        {
            clear();
        }
    }
}
