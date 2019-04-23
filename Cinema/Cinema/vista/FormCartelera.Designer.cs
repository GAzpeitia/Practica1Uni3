namespace Cinema.vista
{
    partial class FormCartelera
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
            this.textTipo = new System.Windows.Forms.TextBox();
            this.textHorario = new System.Windows.Forms.TextBox();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.textCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Salas
            // 
            this.Salas.AutoSize = true;
            this.Salas.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salas.Location = new System.Drawing.Point(127, 9);
            this.Salas.Name = "Salas";
            this.Salas.Size = new System.Drawing.Size(88, 36);
            this.Salas.TabIndex = 35;
            this.Salas.Text = "Cinema\r\n(Cartelera)";
            this.Salas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(238, 128);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(238, 86);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 32;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Horario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Id:";
            // 
            // textTipo
            // 
            this.textTipo.Location = new System.Drawing.Point(76, 184);
            this.textTipo.Name = "textTipo";
            this.textTipo.Size = new System.Drawing.Size(113, 20);
            this.textTipo.TabIndex = 27;
            // 
            // textHorario
            // 
            this.textHorario.Location = new System.Drawing.Point(76, 143);
            this.textHorario.Name = "textHorario";
            this.textHorario.Size = new System.Drawing.Size(113, 20);
            this.textHorario.TabIndex = 26;
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(76, 104);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(113, 20);
            this.textFecha.TabIndex = 25;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(76, 67);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(113, 20);
            this.textId.TabIndex = 24;
            // 
            // textCosto
            // 
            this.textCosto.Location = new System.Drawing.Point(76, 220);
            this.textCosto.Name = "textCosto";
            this.textCosto.Size = new System.Drawing.Size(113, 20);
            this.textCosto.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Costo:";
            // 
            // FormCartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 261);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCosto);
            this.Controls.Add(this.Salas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTipo);
            this.Controls.Add(this.textHorario);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.textId);
            this.Name = "FormCartelera";
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
        private System.Windows.Forms.TextBox textTipo;
        private System.Windows.Forms.TextBox textHorario;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textCosto;
        private System.Windows.Forms.Label label5;
    }
}