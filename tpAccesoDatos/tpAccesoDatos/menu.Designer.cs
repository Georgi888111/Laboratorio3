namespace tpAccesoDatos
{
    partial class menu
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
            this.btnCargarAu = new System.Windows.Forms.Button();
            this.btnIngresarAut = new System.Windows.Forms.Button();
            this.btnABM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarAu
            // 
            this.btnCargarAu.Location = new System.Drawing.Point(37, 73);
            this.btnCargarAu.Name = "btnCargarAu";
            this.btnCargarAu.Size = new System.Drawing.Size(182, 54);
            this.btnCargarAu.TabIndex = 0;
            this.btnCargarAu.Text = "Cargar Authors";
            this.btnCargarAu.UseVisualStyleBackColor = true;
            this.btnCargarAu.Click += new System.EventHandler(this.BtnCargarAu_Click);
            // 
            // btnIngresarAut
            // 
            this.btnIngresarAut.Location = new System.Drawing.Point(282, 73);
            this.btnIngresarAut.Name = "btnIngresarAut";
            this.btnIngresarAut.Size = new System.Drawing.Size(162, 53);
            this.btnIngresarAut.TabIndex = 1;
            this.btnIngresarAut.Text = "Ingresar Author";
            this.btnIngresarAut.UseVisualStyleBackColor = true;
            this.btnIngresarAut.Click += new System.EventHandler(this.BtnIngresarAut_Click);
            // 
            // btnABM
            // 
            this.btnABM.Location = new System.Drawing.Point(517, 73);
            this.btnABM.Name = "btnABM";
            this.btnABM.Size = new System.Drawing.Size(162, 53);
            this.btnABM.TabIndex = 2;
            this.btnABM.Text = "Formulario ABM";
            this.btnABM.UseVisualStyleBackColor = true;
            this.btnABM.Click += new System.EventHandler(this.BtnABM_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnABM);
            this.Controls.Add(this.btnIngresarAut);
            this.Controls.Add(this.btnCargarAu);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarAu;
        private System.Windows.Forms.Button btnIngresarAut;
        private System.Windows.Forms.Button btnABM;
    }
}