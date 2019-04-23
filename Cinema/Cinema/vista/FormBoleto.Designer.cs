namespace Cinema.vista
{
    partial class FormBoleto
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
            this.Salas = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCosto = new System.Windows.Forms.TextBox();
            this.textAsiento = new System.Windows.Forms.TextBox();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.textFolio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Salas
            // 
            this.Salas.AutoSize = true;
            this.Salas.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salas.Location = new System.Drawing.Point(137, 28);
            this.Salas.Name = "Salas";
            this.Salas.Size = new System.Drawing.Size(76, 36);
            this.Salas.TabIndex = 23;
            this.Salas.Text = "Cinema\r\n(Boletos)";
            this.Salas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(248, 147);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(248, 105);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 20;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Costo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Asiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Folio:";
            // 
            // textCosto
            // 
            this.textCosto.Location = new System.Drawing.Point(86, 203);
            this.textCosto.Name = "textCosto";
            this.textCosto.Size = new System.Drawing.Size(113, 20);
            this.textCosto.TabIndex = 15;
            // 
            // textAsiento
            // 
            this.textAsiento.Location = new System.Drawing.Point(86, 162);
            this.textAsiento.Name = "textAsiento";
            this.textAsiento.Size = new System.Drawing.Size(113, 20);
            this.textAsiento.TabIndex = 14;
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(86, 123);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(113, 20);
            this.textFecha.TabIndex = 13;
            // 
            // textFolio
            // 
            this.textFolio.Location = new System.Drawing.Point(86, 86);
            this.textFolio.Name = "textFolio";
            this.textFolio.Size = new System.Drawing.Size(113, 20);
            this.textFolio.TabIndex = 12;
            // 
            // FormBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(342, 261);
            this.ControlBox = false;
            this.Controls.Add(this.Salas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCosto);
            this.Controls.Add(this.textAsiento);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.textFolio);
            this.Name = "FormBoleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Salas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCosto;
        private System.Windows.Forms.TextBox textAsiento;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.TextBox textFolio;
    }
}