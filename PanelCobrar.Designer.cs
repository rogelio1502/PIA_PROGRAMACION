namespace PIA
{
    partial class PanelCobrar
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
            this.preciou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.codigotxt = new System.Windows.Forms.TextBox();
            this.precio_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cantidad_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subtotaltxt = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.totalventatxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_quitar_todo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridproducts
            // 
            this.datagridproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridproducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.preciou,
            this.inventario,
            this.total});
            this.datagridproducts.Location = new System.Drawing.Point(491, 87);
            this.datagridproducts.Name = "datagridproducts";
            this.datagridproducts.Size = new System.Drawing.Size(579, 375);
            this.datagridproducts.TabIndex = 1;
            this.datagridproducts.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.a);
            this.datagridproducts.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.b);
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
            // preciou
            // 
            this.preciou.HeaderText = "Precio Unitario";
            this.preciou.Name = "preciou";
            this.preciou.ReadOnly = true;
            // 
            // inventario
            // 
            this.inventario.HeaderText = "Piezas";
            this.inventario.Name = "inventario";
            this.inventario.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Sub Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(22, 117);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(125, 31);
            this.lbl_codigo.TabIndex = 2;
            this.lbl_codigo.Text = "CODIGO";
            // 
            // codigotxt
            // 
            this.codigotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigotxt.Location = new System.Drawing.Point(28, 151);
            this.codigotxt.MaxLength = 13;
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.Size = new System.Drawing.Size(251, 38);
            this.codigotxt.TabIndex = 3;
            this.codigotxt.Click += new System.EventHandler(this.codigoClick);
            this.codigotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigoKeyPress);
            // 
            // precio_txt
            // 
            this.precio_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_txt.Location = new System.Drawing.Point(301, 235);
            this.precio_txt.MaxLength = 4;
            this.precio_txt.Name = "precio_txt";
            this.precio_txt.Size = new System.Drawing.Size(149, 38);
            this.precio_txt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "PRECIO";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(301, 151);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(149, 38);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // cantidad_txt
            // 
            this.cantidad_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad_txt.Location = new System.Drawing.Point(28, 328);
            this.cantidad_txt.MaxLength = 4;
            this.cantidad_txt.Name = "cantidad_txt";
            this.cantidad_txt.Size = new System.Drawing.Size(149, 38);
            this.cantidad_txt.TabIndex = 8;
            this.cantidad_txt.TextChanged += new System.EventHandler(this.cantidad_txt_TextChanged);
            this.cantidad_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadPressDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "CANTIDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "SUBTOTAL";
            // 
            // subtotaltxt
            // 
            this.subtotaltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotaltxt.Location = new System.Drawing.Point(209, 328);
            this.subtotaltxt.MaxLength = 8;
            this.subtotaltxt.Name = "subtotaltxt";
            this.subtotaltxt.Size = new System.Drawing.Size(251, 38);
            this.subtotaltxt.TabIndex = 10;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(28, 419);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(163, 43);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "AGREGAR";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(197, 527);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(163, 43);
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(28, 527);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(163, 43);
            this.btn_modificar.TabIndex = 13;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(587, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "PRODUCTOS AÑADIDOS";
            // 
            // totalventatxt
            // 
            this.totalventatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalventatxt.Location = new System.Drawing.Point(603, 527);
            this.totalventatxt.MaxLength = 7;
            this.totalventatxt.Name = "totalventatxt";
            this.totalventatxt.Size = new System.Drawing.Size(344, 38);
            this.totalventatxt.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "TOTAL";
            // 
            // btn_pagar
            // 
            this.btn_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar.Location = new System.Drawing.Point(953, 522);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(119, 43);
            this.btn_pagar.TabIndex = 17;
            this.btn_pagar.Text = "COBRAR";
            this.btn_pagar.UseVisualStyleBackColor = true;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "INFO PRODUCTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "NOMBRE";
            // 
            // nombre_txt
            // 
            this.nombre_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_txt.Location = new System.Drawing.Point(31, 235);
            this.nombre_txt.MaxLength = 4;
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(246, 38);
            this.nombre_txt.TabIndex = 20;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(197, 419);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(166, 43);
            this.btn_limpiar.TabIndex = 21;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_quitar_todo
            // 
            this.btn_quitar_todo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar_todo.Location = new System.Drawing.Point(491, 468);
            this.btn_quitar_todo.Name = "btn_quitar_todo";
            this.btn_quitar_todo.Size = new System.Drawing.Size(211, 43);
            this.btn_quitar_todo.TabIndex = 22;
            this.btn_quitar_todo.Text = "ELIMINAR TODO";
            this.btn_quitar_todo.UseVisualStyleBackColor = true;
            this.btn_quitar_todo.Click += new System.EventHandler(this.btn_quitar_todo_Click);
            // 
            // PanelCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 614);
            this.Controls.Add(this.btn_quitar_todo);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.nombre_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.totalventatxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.subtotaltxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantidad_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.precio_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigotxt);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.datagridproducts);
            this.Name = "PanelCobrar";
            this.Text = "PanelCobrar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PanelCobrar_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.datagridproducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridproducts;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox codigotxt;
        private System.Windows.Forms.TextBox precio_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox cantidad_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subtotaltxt;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalventatxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciou;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button btn_quitar_todo;
    }
}