namespace WindowsFormsApplication1
{
    partial class ABMEjemplo
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btMostrar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCompania = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btInsert = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btSearchId = new System.Windows.Forms.Button();
            this.btSearchName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 235);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(715, 156);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
           
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(576, 397);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(152, 23);
            this.btMostrar.TabIndex = 1;
            this.btMostrar.Text = "Mostrar Grilla";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(91, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(195, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtCompania
            // 
            this.txtCompania.Location = new System.Drawing.Point(91, 40);
            this.txtCompania.Name = "txtCompania";
            this.txtCompania.Size = new System.Drawing.Size(195, 20);
            this.txtCompania.TabIndex = 3;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(91, 67);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(195, 20);
            this.txtContacto.TabIndex = 4;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(91, 94);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(195, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(91, 121);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(195, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(91, 148);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(195, 20);
            this.txtCiudad.TabIndex = 7;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(532, 120);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(195, 20);
            this.txtFax.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(532, 93);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(195, 20);
            this.txtTelefono.TabIndex = 11;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(532, 66);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(195, 20);
            this.txtPais.TabIndex = 10;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(532, 39);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(195, 20);
            this.txtCodPostal.TabIndex = 9;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(532, 12);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(195, 20);
            this.txtRegion.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(67, 19);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 13;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "compania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "contacto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "titulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "ciudad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "region";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "codpostal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(500, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "pais";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(481, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "telefono";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(502, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Fax";
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(331, 9);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 23);
            this.btInsert.TabIndex = 24;
            this.btInsert.Text = "INSERT";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(331, 62);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 25;
            this.btUpdate.Text = "UPDATE";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(331, 117);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 26;
            this.btDelete.Text = "DELETE";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre Compañia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "ID Compañia";
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(91, 194);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(100, 20);
            this.txtSearchId.TabIndex = 29;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(400, 196);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(173, 20);
            this.txtSearchName.TabIndex = 30;
            // 
            // btSearchId
            // 
            this.btSearchId.Location = new System.Drawing.Point(197, 193);
            this.btSearchId.Name = "btSearchId";
            this.btSearchId.Size = new System.Drawing.Size(75, 23);
            this.btSearchId.TabIndex = 31;
            this.btSearchId.Text = "BuscarXID";
            this.btSearchId.UseVisualStyleBackColor = true;
            this.btSearchId.Click += new System.EventHandler(this.btSearchId_Click);
            // 
            // btSearchName
            // 
            this.btSearchName.Location = new System.Drawing.Point(579, 193);
            this.btSearchName.Name = "btSearchName";
            this.btSearchName.Size = new System.Drawing.Size(131, 23);
            this.btSearchName.TabIndex = 32;
            this.btSearchName.Text = "BuscarXNombre";
            this.btSearchName.UseVisualStyleBackColor = true;
            this.btSearchName.Click += new System.EventHandler(this.btSearchName_Click);
            // 
            // ABMEjemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 432);
            this.Controls.Add(this.btSearchName);
            this.Controls.Add(this.btSearchId);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.txtSearchId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtCompania);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.dgvClientes);
            this.Name = "ABMEjemplo";
            this.Text = "ABMEjemplo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCompania;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btSearchId;
        private System.Windows.Forms.Button btSearchName;
    }
}