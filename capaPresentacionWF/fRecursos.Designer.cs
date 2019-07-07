namespace capaPresentacionWF
{
    partial class fRecursos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TexBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dataGridViewRecursos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecursos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 402);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.labelId);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(572, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewRecursos);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.TexBoxBuscar);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(572, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(80, 92);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "Id";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(255, 319);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 3;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(273, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(158, 199);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(273, 112);
            this.textBox4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Registrar Recursos ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Buscar";
            // 
            // TexBoxBuscar
            // 
            this.TexBoxBuscar.Location = new System.Drawing.Point(70, 45);
            this.TexBoxBuscar.Name = "TexBoxBuscar";
            this.TexBoxBuscar.Size = new System.Drawing.Size(272, 20);
            this.TexBoxBuscar.TabIndex = 1;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(364, 43);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(450, 43);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRecursos
            // 
            this.dataGridViewRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecursos.Location = new System.Drawing.Point(26, 103);
            this.dataGridViewRecursos.Name = "dataGridViewRecursos";
            this.dataGridViewRecursos.Size = new System.Drawing.Size(518, 243);
            this.dataGridViewRecursos.TabIndex = 4;
            // 
            // fRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 404);
            this.Controls.Add(this.tabControl1);
            this.Name = "fRecursos";
            this.Text = "Recursos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewRecursos;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.TextBox TexBoxBuscar;
        private System.Windows.Forms.Label label5;
    }
}

