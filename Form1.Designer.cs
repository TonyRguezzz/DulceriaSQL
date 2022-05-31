namespace Dulceria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.ventasToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(443, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem,
            this.importarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.exportarToolStripMenuItem.Text = "Exportar ";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 22);
            this.toolStripMenuItem2.Text = "------------------------------";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasToolStripMenuItem,
            this.bajasToolStripMenuItem,
            this.cambiosToolStripMenuItem,
            this.reporteIToolStripMenuItem,
            this.reporteGToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.altasToolStripMenuItem.Text = "Altas";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // bajasToolStripMenuItem
            // 
            this.bajasToolStripMenuItem.Name = "bajasToolStripMenuItem";
            this.bajasToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.bajasToolStripMenuItem.Text = "Bajas";
            // 
            // cambiosToolStripMenuItem
            // 
            this.cambiosToolStripMenuItem.Name = "cambiosToolStripMenuItem";
            this.cambiosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cambiosToolStripMenuItem.Text = "Cambios";
            // 
            // reporteIToolStripMenuItem
            // 
            this.reporteIToolStripMenuItem.Name = "reporteIToolStripMenuItem";
            this.reporteIToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.reporteIToolStripMenuItem.Text = "Reporte I";
            // 
            // reporteGToolStripMenuItem
            // 
            this.reporteGToolStripMenuItem.Name = "reporteGToolStripMenuItem";
            this.reporteGToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.reporteGToolStripMenuItem.Text = "Reporte G";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasToolStripMenuItem1,
            this.bajasToolStripMenuItem1,
            this.cambiosToolStripMenuItem1});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // altasToolStripMenuItem1
            // 
            this.altasToolStripMenuItem1.Name = "altasToolStripMenuItem1";
            this.altasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.altasToolStripMenuItem1.Text = "Altas";
            this.altasToolStripMenuItem1.Click += new System.EventHandler(this.altasToolStripMenuItem1_Click);
            // 
            // bajasToolStripMenuItem1
            // 
            this.bajasToolStripMenuItem1.Name = "bajasToolStripMenuItem1";
            this.bajasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bajasToolStripMenuItem1.Text = "Bajas";
            // 
            // cambiosToolStripMenuItem1
            // 
            this.cambiosToolStripMenuItem1.Name = "cambiosToolStripMenuItem1";
            this.cambiosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cambiosToolStripMenuItem1.Text = "Cambios";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarPedidosToolStripMenuItem,
            this.puntoDeVentaToolStripMenuItem});
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // consultarPedidosToolStripMenuItem
            // 
            this.consultarPedidosToolStripMenuItem.Name = "consultarPedidosToolStripMenuItem";
            this.consultarPedidosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.consultarPedidosToolStripMenuItem.Text = "Consultar pedidos";
            // 
            // puntoDeVentaToolStripMenuItem
            // 
            this.puntoDeVentaToolStripMenuItem.Name = "puntoDeVentaToolStripMenuItem";
            this.puntoDeVentaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.puntoDeVentaToolStripMenuItem.Text = "Punto de Venta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 361);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Dulceria Doña pelos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bajasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cambiosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntoDeVentaToolStripMenuItem;
    }
}

