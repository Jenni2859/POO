namespace POO
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
            this.btnPOO = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEstablecer = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtIDAnimal = new System.Windows.Forms.TextBox();
            this.txtEdadAnimal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.CajaImprimir = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CajaImprimir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPOO
            // 
            this.btnPOO.Location = new System.Drawing.Point(21, 73);
            this.btnPOO.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPOO.Name = "btnPOO";
            this.btnPOO.Size = new System.Drawing.Size(229, 62);
            this.btnPOO.TabIndex = 0;
            this.btnPOO.Text = "POO";
            this.btnPOO.UseVisualStyleBackColor = true;
            this.btnPOO.Click += new System.EventHandler(this.btnPOO_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(84, 231);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(347, 40);
            this.txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEdad.Location = new System.Drawing.Point(84, 286);
            this.txtEdad.Multiline = true;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(347, 40);
            this.txtEdad.TabIndex = 2;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCedula.Location = new System.Drawing.Point(84, 176);
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(347, 40);
            this.txtCedula.TabIndex = 3;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(271, 368);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(236, 63);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar valores";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPOO);
            this.panel1.Controls.Add(this.btnAsignar);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.txtEdad);
            this.panel1.Location = new System.Drawing.Point(42, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 443);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnEstablecer);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.txtRaza);
            this.panel2.Controls.Add(this.txtIDAnimal);
            this.panel2.Controls.Add(this.txtEdadAnimal);
            this.panel2.Location = new System.Drawing.Point(587, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 443);
            this.panel2.TabIndex = 6;
            // 
            // btnEstablecer
            // 
            this.btnEstablecer.Location = new System.Drawing.Point(91, 266);
            this.btnEstablecer.Margin = new System.Windows.Forms.Padding(6);
            this.btnEstablecer.Name = "btnEstablecer";
            this.btnEstablecer.Size = new System.Drawing.Size(347, 41);
            this.btnEstablecer.TabIndex = 0;
            this.btnEstablecer.Text = "Establecer valores";
            this.btnEstablecer.UseVisualStyleBackColor = true;
            this.btnEstablecer.Click += new System.EventHandler(this.btnEstablecer_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(91, 316);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(347, 35);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir valores";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtRaza
            // 
            this.txtRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRaza.ForeColor = System.Drawing.Color.Silver;
            this.txtRaza.Location = new System.Drawing.Point(91, 156);
            this.txtRaza.Multiline = true;
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(347, 40);
            this.txtRaza.TabIndex = 1;
            this.txtRaza.Text = "Raza";
            this.txtRaza.Click += new System.EventHandler(this.txtRaza_Click);
            // 
            // txtIDAnimal
            // 
            this.txtIDAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIDAnimal.ForeColor = System.Drawing.Color.Silver;
            this.txtIDAnimal.Location = new System.Drawing.Point(91, 93);
            this.txtIDAnimal.Multiline = true;
            this.txtIDAnimal.Name = "txtIDAnimal";
            this.txtIDAnimal.Size = new System.Drawing.Size(347, 40);
            this.txtIDAnimal.TabIndex = 3;
            this.txtIDAnimal.Text = "ID";
            this.txtIDAnimal.Click += new System.EventHandler(this.txtIDAnimal_Click);
            // 
            // txtEdadAnimal
            // 
            this.txtEdadAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEdadAnimal.ForeColor = System.Drawing.Color.Silver;
            this.txtEdadAnimal.Location = new System.Drawing.Point(91, 217);
            this.txtEdadAnimal.Multiline = true;
            this.txtEdadAnimal.Name = "txtEdadAnimal";
            this.txtEdadAnimal.Size = new System.Drawing.Size(347, 40);
            this.txtEdadAnimal.TabIndex = 2;
            this.txtEdadAnimal.Text = "Edad";
            this.txtEdadAnimal.Click += new System.EventHandler(this.txtEdadAnimal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clase Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clase Animal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(88, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Raza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(91, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Edad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(17, 389);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 42);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar Animal";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEliminar.Location = new System.Drawing.Point(346, 393);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 35);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar Animal";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // CajaImprimir
            // 
            this.CajaImprimir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CajaImprimir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CajaImprimir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CajaImprimir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Raza,
            this.Edad});
            this.CajaImprimir.Location = new System.Drawing.Point(587, 467);
            this.CajaImprimir.Name = "CajaImprimir";
            this.CajaImprimir.Size = new System.Drawing.Size(522, 150);
            this.CajaImprimir.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Raza
            // 
            this.Raza.HeaderText = "Raza";
            this.Raza.Name = "Raza";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1161, 796);
            this.Controls.Add(this.CajaImprimir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CajaImprimir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPOO;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEstablecer;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtIDAnimal;
        private System.Windows.Forms.TextBox txtEdadAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView CajaImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
    }
}

