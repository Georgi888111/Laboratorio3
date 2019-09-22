namespace WindowsFormsApplication1
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarGrillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestroDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMEjemploToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formulariosToolStripMenuItem
            // 
            this.formulariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarGrillaToolStripMenuItem,
            this.frmDetalleToolStripMenuItem,
            this.maestroDetalleToolStripMenuItem,
            this.frmClientesToolStripMenuItem,
            this.aBMEjemploToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            this.formulariosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.formulariosToolStripMenuItem.Text = "Formularios";
            // 
            // cargarGrillaToolStripMenuItem
            // 
            this.cargarGrillaToolStripMenuItem.Name = "cargarGrillaToolStripMenuItem";
            this.cargarGrillaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cargarGrillaToolStripMenuItem.Text = "Cargar Grilla";
            this.cargarGrillaToolStripMenuItem.Click += new System.EventHandler(this.cargarGrillaToolStripMenuItem_Click);
            // 
            // frmDetalleToolStripMenuItem
            // 
            this.frmDetalleToolStripMenuItem.Name = "frmDetalleToolStripMenuItem";
            this.frmDetalleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.frmDetalleToolStripMenuItem.Text = "Frm Detalle";
            this.frmDetalleToolStripMenuItem.Click += new System.EventHandler(this.frmDetalleToolStripMenuItem_Click);
            // 
            // frmClientesToolStripMenuItem
            // 
            this.frmClientesToolStripMenuItem.Name = "frmClientesToolStripMenuItem";
            this.frmClientesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.frmClientesToolStripMenuItem.Text = "Frm Clientes";
            this.frmClientesToolStripMenuItem.Click += new System.EventHandler(this.frmClientesToolStripMenuItem_Click);
            // 
            // maestroDetalleToolStripMenuItem
            // 
            this.maestroDetalleToolStripMenuItem.Name = "maestroDetalleToolStripMenuItem";
            this.maestroDetalleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.maestroDetalleToolStripMenuItem.Text = "Maestro-Detalle";
            this.maestroDetalleToolStripMenuItem.Click += new System.EventHandler(this.maestroDetalleToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // aBMEjemploToolStripMenuItem
            // 
            this.aBMEjemploToolStripMenuItem.Name = "aBMEjemploToolStripMenuItem";
            this.aBMEjemploToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aBMEjemploToolStripMenuItem.Text = "ABM Ejemplo";
            this.aBMEjemploToolStripMenuItem.Click += new System.EventHandler(this.aBMEjemploToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 314);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarGrillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestroDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMEjemploToolStripMenuItem;
    }
}