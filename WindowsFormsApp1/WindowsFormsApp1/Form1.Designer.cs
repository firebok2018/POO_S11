namespace WindowsFormsApp1
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
            this.btnconsultar = new System.Windows.Forms.Button();
            this.dglista = new System.Windows.Forms.DataGridView();
            this.txtnom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dglista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(696, 82);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(75, 23);
            this.btnconsultar.TabIndex = 0;
            this.btnconsultar.Text = "Consular";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // dglista
            // 
            this.dglista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglista.Location = new System.Drawing.Point(10, 138);
            this.dglista.Name = "dglista";
            this.dglista.Size = new System.Drawing.Size(773, 301);
            this.dglista.TabIndex = 1;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(133, 57);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(219, 20);
            this.txtnom.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.dglista);
            this.Controls.Add(this.btnconsultar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dglista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.DataGridView dglista;
        private System.Windows.Forms.TextBox txtnom;
    }
}

