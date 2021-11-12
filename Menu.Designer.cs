namespace PIA
{
    partial class Menu
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
            this.productos_btn = new System.Windows.Forms.Button();
            this.cobrar_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ventas = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productos_btn
            // 
            this.productos_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productos_btn.Location = new System.Drawing.Point(135, 111);
            this.productos_btn.Name = "productos_btn";
            this.productos_btn.Size = new System.Drawing.Size(323, 76);
            this.productos_btn.TabIndex = 0;
            this.productos_btn.Text = "PRODUCTOS";
            this.productos_btn.UseVisualStyleBackColor = true;
            this.productos_btn.Click += new System.EventHandler(this.productos_btn_Click);
            // 
            // cobrar_btn
            // 
            this.cobrar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobrar_btn.Location = new System.Drawing.Point(135, 193);
            this.cobrar_btn.Name = "cobrar_btn";
            this.cobrar_btn.Size = new System.Drawing.Size(323, 70);
            this.cobrar_btn.TabIndex = 1;
            this.cobrar_btn.Text = "COBRAR";
            this.cobrar_btn.UseVisualStyleBackColor = true;
            this.cobrar_btn.Click += new System.EventHandler(this.cobrar_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // ventas
            // 
            this.ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventas.Location = new System.Drawing.Point(135, 269);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(323, 66);
            this.ventas.TabIndex = 3;
            this.ventas.Text = "VENTAS";
            this.ventas.UseVisualStyleBackColor = true;
            this.ventas.Click += new System.EventHandler(this.ventas_Click);
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(135, 341);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(323, 66);
            this.salir.TabIndex = 4;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 461);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.ventas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cobrar_btn);
            this.Controls.Add(this.productos_btn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menuClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button productos_btn;
        private System.Windows.Forms.Button cobrar_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ventas;
        private System.Windows.Forms.Button salir;
    }
}