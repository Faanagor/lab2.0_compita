namespace app_test_example
{
    partial class Form1
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
            this.buscarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelArchivo = new System.Windows.Forms.Label();
            this.labelHoja = new System.Windows.Forms.Label();
            this.txtHoja = new System.Windows.Forms.TextBox();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.formato_busqueda = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nombre_elemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_elemento = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.componente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden_ejecucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardarButton = new System.Windows.Forms.Button();
            this.actualizarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.implementarButton = new System.Windows.Forms.Button();
            this.deviceButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(582, 125);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 0;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // labelArchivo
            // 
            this.labelArchivo.AutoSize = true;
            this.labelArchivo.Location = new System.Drawing.Point(189, 134);
            this.labelArchivo.Name = "labelArchivo";
            this.labelArchivo.Size = new System.Drawing.Size(43, 13);
            this.labelArchivo.TabIndex = 2;
            this.labelArchivo.Text = "Archivo";
            this.labelArchivo.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelHoja
            // 
            this.labelHoja.AutoSize = true;
            this.labelHoja.Location = new System.Drawing.Point(377, 134);
            this.labelHoja.Name = "labelHoja";
            this.labelHoja.Size = new System.Drawing.Size(62, 13);
            this.labelHoja.TabIndex = 3;
            this.labelHoja.Text = "Hoja a Leer";
            // 
            // txtHoja
            // 
            this.txtHoja.Location = new System.Drawing.Point(445, 127);
            this.txtHoja.Name = "txtHoja";
            this.txtHoja.Size = new System.Drawing.Size(131, 20);
            this.txtHoja.TabIndex = 4;
            this.txtHoja.Text = "sheet1";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(238, 127);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(133, 20);
            this.txtArchivo.TabIndex = 5;
            this.txtArchivo.Text = "book1.xlsx";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.formato_busqueda,
            this.nombre_elemento,
            this.nombre_variable,
            this.tipo_elemento,
            this.componente,
            this.orden_ejecucion});
            this.dataGridView1.Location = new System.Drawing.Point(79, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(651, 304);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // formato_busqueda
            // 
            this.formato_busqueda.HeaderText = "formato_busqueda";
            this.formato_busqueda.Items.AddRange(new object[] {
            "By.id",
            "By.className",
            "By.xpath"});
            this.formato_busqueda.Name = "formato_busqueda";
            this.formato_busqueda.Width = 101;
            // 
            // nombre_elemento
            // 
            this.nombre_elemento.HeaderText = "nombre_elemento";
            this.nombre_elemento.Name = "nombre_elemento";
            this.nombre_elemento.Width = 116;
            // 
            // nombre_variable
            // 
            this.nombre_variable.HeaderText = "nombre_variable";
            this.nombre_variable.Name = "nombre_variable";
            this.nombre_variable.Width = 110;
            // 
            // tipo_elemento
            // 
            this.tipo_elemento.HeaderText = "tipo_elemento";
            this.tipo_elemento.Items.AddRange(new object[] {
            "Boton",
            "Etiqueta",
            "Caja de texo"});
            this.tipo_elemento.Name = "tipo_elemento";
            this.tipo_elemento.Width = 79;
            // 
            // componente
            // 
            this.componente.HeaderText = "componente";
            this.componente.Name = "componente";
            this.componente.Width = 91;
            // 
            // orden_ejecucion
            // 
            this.orden_ejecucion.HeaderText = "orden_ejecucion";
            this.orden_ejecucion.Name = "orden_ejecucion";
            this.orden_ejecucion.Width = 111;
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(255, 479);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(149, 23);
            this.guardarButton.TabIndex = 9;
            this.guardarButton.Text = "Guardar en Nuevo archivo";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // actualizarButton
            // 
            this.actualizarButton.Location = new System.Drawing.Point(126, 479);
            this.actualizarButton.Name = "actualizarButton";
            this.actualizarButton.Size = new System.Drawing.Size(75, 23);
            this.actualizarButton.TabIndex = 10;
            this.actualizarButton.Text = "Actualizar";
            this.actualizarButton.UseVisualStyleBackColor = true;
            this.actualizarButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(597, 479);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(99, 23);
            this.cancelarButton.TabIndex = 11;
            this.cancelarButton.Text = "Cerrar Aplicación";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // implementarButton
            // 
            this.implementarButton.Location = new System.Drawing.Point(463, 479);
            this.implementarButton.Name = "implementarButton";
            this.implementarButton.Size = new System.Drawing.Size(75, 23);
            this.implementarButton.TabIndex = 26;
            this.implementarButton.Text = "Implementar";
            this.implementarButton.UseVisualStyleBackColor = true;
            // 
            // deviceButton
            // 
            this.deviceButton.Location = new System.Drawing.Point(129, 13);
            this.deviceButton.Name = "deviceButton";
            this.deviceButton.Size = new System.Drawing.Size(93, 46);
            this.deviceButton.TabIndex = 27;
            this.deviceButton.Text = "Buscar Dispositivos";
            this.deviceButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Dispositivos encontrados"});
            this.listBox1.Location = new System.Drawing.Point(239, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(133, 69);
            this.listBox1.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(393, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "device 1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(393, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 30;
            this.textBox2.Text = "device 2";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(393, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 31;
            this.textBox3.Text = "device 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 530);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.deviceButton);
            this.Controls.Add(this.implementarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.actualizarButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.txtHoja);
            this.Controls.Add(this.labelHoja);
            this.Controls.Add(this.labelArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelArchivo;
        private System.Windows.Forms.Label labelHoja;
        private System.Windows.Forms.TextBox txtHoja;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button guardarButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button actualizarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.DataGridViewComboBoxColumn formato_busqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_elemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_variable;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipo_elemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn componente;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden_ejecucion;
        private System.Windows.Forms.Button implementarButton;
        private System.Windows.Forms.Button deviceButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

