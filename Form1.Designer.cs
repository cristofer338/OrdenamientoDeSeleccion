namespace OrdenamientoSelecion
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
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.listBoxOrdenado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.ItemHeight = 16;
            this.listBoxNumeros.Location = new System.Drawing.Point(12, 51);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(438, 452);
            this.listBoxNumeros.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(12, 12);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click_1);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(93, 12);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click_1);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(387, 511);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(14, 16);
            this.lblTiempo.TabIndex = 3;
            this.lblTiempo.Text = "0";
            // 
            // listBoxOrdenado
            // 
            this.listBoxOrdenado.FormattingEnabled = true;
            this.listBoxOrdenado.ItemHeight = 16;
            this.listBoxOrdenado.Location = new System.Drawing.Point(456, 51);
            this.listBoxOrdenado.Name = "listBoxOrdenado";
            this.listBoxOrdenado.Size = new System.Drawing.Size(332, 452);
            this.listBoxOrdenado.TabIndex = 4;
            this.listBoxOrdenado.SelectedIndexChanged += new System.EventHandler(this.listBoxOrdenado_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.listBoxOrdenado);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.listBoxNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNumeros;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.ListBox listBoxOrdenado;
    }
}

