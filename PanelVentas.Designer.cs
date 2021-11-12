namespace PIA
{
    partial class PanelVentas
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
            this.datagridventas = new System.Windows.Forms.DataGridView();
            this.venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnnoventa = new System.Windows.Forms.Label();
            this.numeroventas = new System.Windows.Forms.TextBox();
            this.buscarfecha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.fe = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buscarcodigo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridventas)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridventas
            // 
            this.datagridventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.venta,
            this.total_venta,
            this.fecha});
            this.datagridventas.Location = new System.Drawing.Point(428, 83);
            this.datagridventas.Name = "datagridventas";
            this.datagridventas.Size = new System.Drawing.Size(343, 335);
            this.datagridventas.TabIndex = 0;
            // 
            // venta
            // 
            this.venta.HeaderText = "VENTA";
            this.venta.Name = "venta";
            this.venta.ReadOnly = true;
            // 
            // total_venta
            // 
            this.total_venta.HeaderText = "Total Venta";
            this.total_venta.Name = "total_venta";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // btnnoventa
            // 
            this.btnnoventa.AutoSize = true;
            this.btnnoventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnoventa.Location = new System.Drawing.Point(44, 108);
            this.btnnoventa.Name = "btnnoventa";
            this.btnnoventa.Size = new System.Drawing.Size(226, 26);
            this.btnnoventa.TabIndex = 1;
            this.btnnoventa.Text = "NUMERO DE VENTA";
            // 
            // numeroventas
            // 
            this.numeroventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroventas.Location = new System.Drawing.Point(49, 149);
            this.numeroventas.MaxLength = 8;
            this.numeroventas.Name = "numeroventas";
            this.numeroventas.Size = new System.Drawing.Size(350, 32);
            this.numeroventas.TabIndex = 2;
            this.numeroventas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // buscarfecha
            // 
            this.buscarfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarfecha.Location = new System.Drawing.Point(49, 337);
            this.buscarfecha.Name = "buscarfecha";
            this.buscarfecha.Size = new System.Drawing.Size(130, 37);
            this.buscarfecha.TabIndex = 6;
            this.buscarfecha.Text = "Buscar";
            this.buscarfecha.UseVisualStyleBackColor = true;
            this.buscarfecha.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "HISTORICO DE VENTAS";
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(235, 337);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(130, 37);
            this.refresh.TabIndex = 8;
            this.refresh.Text = "Recargar";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // fe
            // 
            this.fe.AutoSize = true;
            this.fe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fe.Location = new System.Drawing.Point(44, 253);
            this.fe.Name = "fe";
            this.fe.Size = new System.Drawing.Size(135, 26);
            this.fe.TabIndex = 3;
            this.fe.Text = "Fecha Venta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(49, 293);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(350, 32);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // buscarcodigo
            // 
            this.buscarcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarcodigo.Location = new System.Drawing.Point(49, 197);
            this.buscarcodigo.Name = "buscarcodigo";
            this.buscarcodigo.Size = new System.Drawing.Size(130, 37);
            this.buscarcodigo.TabIndex = 9;
            this.buscarcodigo.Text = "Buscar";
            this.buscarcodigo.UseVisualStyleBackColor = true;
            this.buscarcodigo.Click += new System.EventHandler(this.buscarcodigo_Click);
            // 
            // PanelVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscarcodigo);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarfecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.fe);
            this.Controls.Add(this.numeroventas);
            this.Controls.Add(this.btnnoventa);
            this.Controls.Add(this.datagridventas);
            this.Name = "PanelVentas";
            this.Text = "PanelVentas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.panelVentasClosed);
            ((System.ComponentModel.ISupportInitialize)(this.datagridventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.Label btnnoventa;
        private System.Windows.Forms.TextBox numeroventas;
        private System.Windows.Forms.Button buscarfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label fe;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buscarcodigo;
    }
}