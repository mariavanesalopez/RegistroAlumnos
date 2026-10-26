namespace RegistroAlumnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNotaMatematica = new System.Windows.Forms.TextBox();
            this.txtNotaLenguaje = new System.Windows.Forms.TextBox();
            this.txtNotaFisica = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.dgvDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMatematica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLenguaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCondicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Complete los datos:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Matemática";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lenguaje";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Física";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ingrese las notas de:";
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDni.Location = new System.Drawing.Point(34, 74);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 22);
            this.txtDni.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNombre.Location = new System.Drawing.Point(232, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(367, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // txtNotaMatematica
            // 
            this.txtNotaMatematica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotaMatematica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNotaMatematica.Location = new System.Drawing.Point(297, 137);
            this.txtNotaMatematica.Name = "txtNotaMatematica";
            this.txtNotaMatematica.Size = new System.Drawing.Size(37, 19);
            this.txtNotaMatematica.TabIndex = 10;
            // 
            // txtNotaLenguaje
            // 
            this.txtNotaLenguaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotaLenguaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNotaLenguaje.Location = new System.Drawing.Point(446, 137);
            this.txtNotaLenguaje.Name = "txtNotaLenguaje";
            this.txtNotaLenguaje.Size = new System.Drawing.Size(37, 19);
            this.txtNotaLenguaje.TabIndex = 11;
            // 
            // txtNotaFisica
            // 
            this.txtNotaFisica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNotaFisica.Location = new System.Drawing.Point(605, 137);
            this.txtNotaFisica.Name = "txtNotaFisica";
            this.txtNotaFisica.Size = new System.Drawing.Size(37, 19);
            this.txtNotaFisica.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(254, 194);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(254, 36);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "G U A R D A R";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToOrderColumns = true;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDni,
            this.dgvNombre,
            this.dgvMatematica,
            this.dgvLenguaje,
            this.dgvFisica,
            this.dgvPromedio,
            this.dgvCondicion});
            this.dgvNotas.Location = new System.Drawing.Point(24, 261);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.RowHeadersVisible = false;
            this.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotas.Size = new System.Drawing.Size(690, 119);
            this.dgvNotas.TabIndex = 14;
            // 
            // dgvDni
            // 
            this.dgvDni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDni.DataPropertyName = "DNI";
            this.dgvDni.HeaderText = "DNI";
            this.dgvDni.Name = "dgvDni";
            // 
            // dgvNombre
            // 
            this.dgvNombre.DataPropertyName = "Nombre";
            this.dgvNombre.HeaderText = "NOMBRE";
            this.dgvNombre.Name = "dgvNombre";
            // 
            // dgvMatematica
            // 
            this.dgvMatematica.DataPropertyName = "NotaMate";
            this.dgvMatematica.HeaderText = "MATEMATICA";
            this.dgvMatematica.Name = "dgvMatematica";
            // 
            // dgvLenguaje
            // 
            this.dgvLenguaje.DataPropertyName = "NotaLengua";
            this.dgvLenguaje.HeaderText = "LENGUAJE";
            this.dgvLenguaje.Name = "dgvLenguaje";
            // 
            // dgvFisica
            // 
            this.dgvFisica.DataPropertyName = "NotaFisica";
            this.dgvFisica.HeaderText = "FISICA";
            this.dgvFisica.Name = "dgvFisica";
            // 
            // dgvPromedio
            // 
            this.dgvPromedio.DataPropertyName = "Promedio";
            this.dgvPromedio.HeaderText = "PROMEDIO";
            this.dgvPromedio.Name = "dgvPromedio";
            // 
            // dgvCondicion
            // 
            this.dgvCondicion.DataPropertyName = "Condicion";
            this.dgvCondicion.HeaderText = "CONDICION";
            this.dgvCondicion.Name = "dgvCondicion";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(434, 405);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 33);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(577, 405);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 33);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNotaFisica);
            this.Controls.Add(this.txtNotaLenguaje);
            this.Controls.Add(this.txtNotaMatematica);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNotaMatematica;
        private System.Windows.Forms.TextBox txtNotaLenguaje;
        private System.Windows.Forms.TextBox txtNotaFisica;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMatematica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLenguaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCondicion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
    }
}

