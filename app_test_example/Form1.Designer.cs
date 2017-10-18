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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(565, 29);
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
            this.label1.Location = new System.Drawing.Point(496, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // labelArchivo
            // 
            this.labelArchivo.AutoSize = true;
            this.labelArchivo.Location = new System.Drawing.Point(172, 38);
            this.labelArchivo.Name = "labelArchivo";
            this.labelArchivo.Size = new System.Drawing.Size(43, 13);
            this.labelArchivo.TabIndex = 2;
            this.labelArchivo.Text = "Archivo";
            this.labelArchivo.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelHoja
            // 
            this.labelHoja.AutoSize = true;
            this.labelHoja.Location = new System.Drawing.Point(360, 38);
            this.labelHoja.Name = "labelHoja";
            this.labelHoja.Size = new System.Drawing.Size(62, 13);
            this.labelHoja.TabIndex = 3;
            this.labelHoja.Text = "Hoja a Leer";
            // 
            // txtHoja
            // 
            this.txtHoja.Location = new System.Drawing.Point(428, 31);
            this.txtHoja.Name = "txtHoja";
            this.txtHoja.Size = new System.Drawing.Size(131, 20);
            this.txtHoja.TabIndex = 4;
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(221, 31);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(133, 20);
            this.txtArchivo.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(175, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 274);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(622, 71);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 274);
            this.vScrollBar1.TabIndex = 7;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(175, 327);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(447, 18);
            this.hScrollBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 503);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.txtHoja);
            this.Controls.Add(this.labelHoja);
            this.Controls.Add(this.labelArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarButton);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

