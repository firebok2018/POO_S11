namespace WindowsFormsApp1
{
    partial class Form2
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
            this.txtnom = new System.Windows.Forms.TextBox();
            this.dglista = new System.Windows.Forms.DataGridView();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dglista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(128, 62);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(219, 20);
            this.txtnom.TabIndex = 5;
            // 
            // dglista
            // 
            this.dglista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglista.Location = new System.Drawing.Point(14, 115);
            this.dglista.Name = "dglista";
            this.dglista.Size = new System.Drawing.Size(773, 301);
            this.dglista.TabIndex = 4;
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(700, 59);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(75, 23);
            this.btnconsultar.TabIndex = 3;
            this.btnconsultar.Text = "Consular";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "echa";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.dglista);
            this.Controls.Add(this.btnconsultar);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dglista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.DataGridView dglista;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Label label1;
    }
}