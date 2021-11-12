namespace PIA
{
    partial class PanelProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datagridproducts = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codigotxt = new System.Windows.Forms.TextBox();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.preciotxt = new System.Windows.Forms.TextBox();
            this.cantidadtxt = new System.Windows.Forms.TextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.todobtn = new System.Windows.Forms.Button();
            this.btn_listo_update = new System.Windows.Forms.Button();
            this.cancelarbtn = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridproducts
            // 
            this.datagridproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridproducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.precio,
            this.inventario});
            this.datagridproducts.Location = new System.Drawing.Point(55, 92);
            this.datagridproducts.Name = "datagridproducts";
            this.datagridproducts.Size = new System.Drawing.Size(464, 400);
            this.datagridproducts.TabIndex = 0;
            this.datagridproducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridproducts_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // inventario
            // 
            this.inventario.HeaderText = "Inventario";
            this.inventario.Name = "inventario";
            this.inventario.ReadOnly = true;
            // 
            // producto_buscar
            // 
            this.producto_buscar.Location = new System.Drawing.Point(191, 52);
            this.producto_buscar.MaxLength = 13;
            this.producto_buscar.Name = "producto_buscar";
            this.producto_buscar.Size = new System.Drawing.Size(172, 20);
            this.producto_buscar.TabIndex = 1;
            this.producto_buscar.TextChanged += new System.EventHandler(this.producto_buscar_TextChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(369, 49);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "CODIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(612, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "CANTIDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(612, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "PRECIO";
            // 
            // codigotxt
            // 
            this.codigotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigotxt.Location = new System.Drawing.Point(615, 141);
            this.codigotxt.MaxLength = 13;
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.Size = new System.Drawing.Size(306, 30);
            this.codigotxt.TabIndex = 7;
            this.codigotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigoKeyPress);
            // 
            // nombretxt
            // 
            this.nombretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombretxt.Location = new System.Drawing.Point(615, 261);
            this.nombretxt.MaxLength = 45;
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(306, 30);
            this.nombretxt.TabIndex = 8;
            // 
            // preciotxt
            // 
            this.preciotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciotxt.Location = new System.Drawing.Point(615, 367);
            this.preciotxt.MaxLength = 4;
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(306, 30);
            this.preciotxt.TabIndex = 9;
            this.preciotxt.TextChanged += new System.EventHandler(this.preciotxt_TextChanged);
            this.preciotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preciotxtKeyPress);
            // 
            // cantidadtxt
            // 
            this.cantidadtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadtxt.Location = new System.Drawing.Point(615, 462);
            this.cantidadtxt.MaxLength = 4;
            this.cantidadtxt.Name = "cantidadtxt";
            this.cantidadtxt.Size = new System.Drawing.Size(306, 30);
            this.cantidadtxt.TabIndex = 10;
            this.cantidadtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadKeyPress);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Location = new System.Drawing.Point(55, 524);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(189, 47);
            this.btn_actualizar.TabIndex = 11;
            this.btn_actualizar.Text = "ACTUALIZAR";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(255, 524);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(189, 47);
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(786, 524);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(135, 47);
            this.savebtn.TabIndex = 13;
            this.savebtn.Text = "GUARDAR";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(612, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "INFORMACIÓN DEL PRODUCTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "CODIGO O NOMBRE";
            // 
            // todobtn
            // 
            this.todobtn.Location = new System.Drawing.Point(450, 49);
            this.todobtn.Name = "todobtn";
            this.todobtn.Size = new System.Drawing.Size(69, 23);
            this.todobtn.TabIndex = 16;
            this.todobtn.Text = "TODO";
            this.todobtn.UseVisualStyleBackColor = true;
            this.todobtn.Click += new System.EventHandler(this.todobtn_Click);
            // 
            // btn_listo_update
            // 
            this.btn_listo_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listo_update.Location = new System.Drawing.Point(786, 524);
            this.btn_listo_update.Name = "btn_listo_update";
            this.btn_listo_update.Size = new System.Drawing.Size(135, 47);
            this.btn_listo_update.TabIndex = 17;
            this.btn_listo_update.Text = "LISTO";
            this.btn_listo_update.UseVisualStyleBackColor = true;
            this.btn_listo_update.Click += new System.EventHandler(this.btn_listo_update_Click);
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarbtn.Location = new System.Drawing.Point(615, 524);
            this.cancelarbtn.Name = "cancelarbtn";
            this.cancelarbtn.Size = new System.Drawing.Size(58, 47);
            this.cancelarbtn.TabIndex = 18;
            this.cancelarbtn.Text = "X";
            this.cancelarbtn.UseVisualStyleBackColor = true;
            this.cancelarbtn.Click += new System.EventHandler(this.cancelarbtn_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clean.Location = new System.Drawing.Point(679, 524);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(101, 47);
            this.btn_clean.TabIndex = 19;
            this.btn_clean.Text = "LIMPIAR";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // PanelProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 620);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.cancelarbtn);
            this.Controls.Add(this.btn_listo_update);
            this.Controls.Add(this.todobtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.cantidadtxt);
            this.Controls.Add(this.preciotxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.codigotxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.producto_buscar);
            this.Controls.Add(this.datagridproducts);
            this.Name = "PanelProductos";
            this.Text = "PanelProductos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.productosClosed);
            this.Load += new System.EventHandler(this.PanelProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridproducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridproducts;
        private System.Windows.Forms.TextBox producto_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codigotxt;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox preciotxt;
        private System.Windows.Forms.TextBox cantidadtxt;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventario;
        private System.Windows.Forms.Button todobtn;
        private System.Windows.Forms.Button btn_listo_update;
        private System.Windows.Forms.Button cancelarbtn;
        private System.Windows.Forms.Button btn_clean;
    }
}