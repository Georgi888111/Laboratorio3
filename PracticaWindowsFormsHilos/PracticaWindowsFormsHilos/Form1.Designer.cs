namespace PracticaWindowsFormsHilos
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
            this.btnSaludo = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnCambioForm = new System.Windows.Forms.Button();
            this.textEnvio = new System.Windows.Forms.TextBox();
            this.btnGridView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaludo
            // 
            this.btnSaludo.Location = new System.Drawing.Point(33, 143);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(115, 33);
            this.btnSaludo.TabIndex = 0;
            this.btnSaludo.Text = "Saludo";
            this.btnSaludo.UseVisualStyleBackColor = true;
            this.btnSaludo.Click += new System.EventHandler(this.btnSaludo_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(29, 34);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(51, 20);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "label1";
            // 
            // btnCambioForm
            // 
            this.btnCambioForm.Location = new System.Drawing.Point(33, 210);
            this.btnCambioForm.Name = "btnCambioForm";
            this.btnCambioForm.Size = new System.Drawing.Size(115, 31);
            this.btnCambioForm.TabIndex = 2;
            this.btnCambioForm.Text = "Cambio";
            this.btnCambioForm.UseVisualStyleBackColor = true;
            this.btnCambioForm.Click += new System.EventHandler(this.btnCambioForm_Click);
            // 
            // textEnvio
            // 
            this.textEnvio.Location = new System.Drawing.Point(33, 89);
            this.textEnvio.Name = "textEnvio";
            this.textEnvio.Size = new System.Drawing.Size(267, 26);
            this.textEnvio.TabIndex = 3;
            // 
            // btnGridView
            // 
            this.btnGridView.Location = new System.Drawing.Point(33, 258);
            this.btnGridView.Name = "btnGridView";
            this.btnGridView.Size = new System.Drawing.Size(115, 34);
            this.btnGridView.TabIndex = 4;
            this.btnGridView.Text = "GridView";
            this.btnGridView.UseVisualStyleBackColor = true;
            this.btnGridView.Click += new System.EventHandler(this.btnGridView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 304);
            this.Controls.Add(this.btnGridView);
            this.Controls.Add(this.textEnvio);
            this.Controls.Add(this.btnCambioForm);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnSaludo);
            this.Name = "Form1";
            this.Text = "Practica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnCambioForm;
        private System.Windows.Forms.TextBox textEnvio;
        private System.Windows.Forms.Button btnGridView;
    }
}

