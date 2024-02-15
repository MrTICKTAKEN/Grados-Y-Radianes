namespace Grados_Y_Radianes
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
            this.GRADtextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RESULTlabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GRADtextBox1
            // 
            this.GRADtextBox1.Location = new System.Drawing.Point(190, 94);
            this.GRADtextBox1.Name = "GRADtextBox1";
            this.GRADtextBox1.Size = new System.Drawing.Size(100, 20);
            this.GRADtextBox1.TabIndex = 0;
            this.GRADtextBox1.TextChanged += new System.EventHandler(this.GRADtextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RESULTlabel1
            // 
            this.RESULTlabel1.AutoSize = true;
            this.RESULTlabel1.Location = new System.Drawing.Point(195, 148);
            this.RESULTlabel1.Name = "RESULTlabel1";
            this.RESULTlabel1.Size = new System.Drawing.Size(0, 13);
            this.RESULTlabel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresa los valores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RESULTlabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GRADtextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GRADtextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label RESULTlabel1;
        private System.Windows.Forms.Label label1;
    }
}

