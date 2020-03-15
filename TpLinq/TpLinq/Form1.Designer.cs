namespace TpLinq
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
            this.gridEmployees = new System.Windows.Forms.DataGridView();
            this.dataGridEmpleCity = new System.Windows.Forms.DataGridView();
            this.dataGridTitle = new System.Windows.Forms.DataGridView();
            this.dataGridUsa = new System.Windows.Forms.DataGridView();
            this.dataGridSales = new System.Windows.Forms.DataGridView();
            this.gridCustomCity = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomCity)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEmployees
            // 
            this.gridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployees.Location = new System.Drawing.Point(12, 12);
            this.gridEmployees.Name = "gridEmployees";
            this.gridEmployees.Size = new System.Drawing.Size(302, 103);
            this.gridEmployees.TabIndex = 0;
            // 
            // dataGridEmpleCity
            // 
            this.dataGridEmpleCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpleCity.Location = new System.Drawing.Point(350, 13);
            this.dataGridEmpleCity.Name = "dataGridEmpleCity";
            this.dataGridEmpleCity.Size = new System.Drawing.Size(285, 102);
            this.dataGridEmpleCity.TabIndex = 1;
            // 
            // dataGridTitle
            // 
            this.dataGridTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTitle.Location = new System.Drawing.Point(12, 130);
            this.dataGridTitle.Name = "dataGridTitle";
            this.dataGridTitle.Size = new System.Drawing.Size(302, 90);
            this.dataGridTitle.TabIndex = 2;
            // 
            // dataGridUsa
            // 
            this.dataGridUsa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsa.Location = new System.Drawing.Point(350, 130);
            this.dataGridUsa.Name = "dataGridUsa";
            this.dataGridUsa.Size = new System.Drawing.Size(285, 90);
            this.dataGridUsa.TabIndex = 3;
            // 
            // dataGridSales
            // 
            this.dataGridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSales.Location = new System.Drawing.Point(12, 235);
            this.dataGridSales.Name = "dataGridSales";
            this.dataGridSales.Size = new System.Drawing.Size(302, 102);
            this.dataGridSales.TabIndex = 4;
            // 
            // gridCustomCity
            // 
            this.gridCustomCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomCity.Location = new System.Drawing.Point(350, 235);
            this.gridCustomCity.Name = "gridCustomCity";
            this.gridCustomCity.Size = new System.Drawing.Size(438, 170);
            this.gridCustomCity.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "BotonCambio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridCustomCity);
            this.Controls.Add(this.dataGridSales);
            this.Controls.Add(this.dataGridUsa);
            this.Controls.Add(this.dataGridTitle);
            this.Controls.Add(this.dataGridEmpleCity);
            this.Controls.Add(this.gridEmployees);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomCity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmployees;
        private System.Windows.Forms.DataGridView dataGridEmpleCity;
        private System.Windows.Forms.DataGridView dataGridTitle;
        private System.Windows.Forms.DataGridView dataGridUsa;
        private System.Windows.Forms.DataGridView dataGridSales;
        private System.Windows.Forms.DataGridView gridCustomCity;
        private System.Windows.Forms.Button button1;
    }
}

