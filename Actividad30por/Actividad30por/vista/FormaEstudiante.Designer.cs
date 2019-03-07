namespace Actividad30por.vista
{
    partial class FormaEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaEstudiante));
            this.textoNumeroControl = new System.Windows.Forms.TextBox();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.textoEdad = new System.Windows.Forms.TextBox();
            this.textoGenero = new System.Windows.Forms.TextBox();
            this.LabelEstudiante = new System.Windows.Forms.Label();
            this.labelNumeroControl = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.botonMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoNumeroControl
            // 
            this.textoNumeroControl.Location = new System.Drawing.Point(254, 120);
            this.textoNumeroControl.Name = "textoNumeroControl";
            this.textoNumeroControl.Size = new System.Drawing.Size(208, 20);
            this.textoNumeroControl.TabIndex = 0;
            // 
            // textoNombre
            // 
            this.textoNombre.Location = new System.Drawing.Point(254, 158);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(208, 20);
            this.textoNombre.TabIndex = 1;
            // 
            // textoEdad
            // 
            this.textoEdad.Location = new System.Drawing.Point(254, 197);
            this.textoEdad.Name = "textoEdad";
            this.textoEdad.Size = new System.Drawing.Size(208, 20);
            this.textoEdad.TabIndex = 2;
            // 
            // textoGenero
            // 
            this.textoGenero.Location = new System.Drawing.Point(254, 234);
            this.textoGenero.Name = "textoGenero";
            this.textoGenero.Size = new System.Drawing.Size(208, 20);
            this.textoGenero.TabIndex = 3;
            // 
            // LabelEstudiante
            // 
            this.LabelEstudiante.AutoSize = true;
            this.LabelEstudiante.BackColor = System.Drawing.Color.Orange;
            this.LabelEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEstudiante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelEstudiante.Location = new System.Drawing.Point(90, 38);
            this.LabelEstudiante.Name = "LabelEstudiante";
            this.LabelEstudiante.Size = new System.Drawing.Size(312, 37);
            this.LabelEstudiante.TabIndex = 4;
            this.LabelEstudiante.Text = "Datos del Estudiante";
            // 
            // labelNumeroControl
            // 
            this.labelNumeroControl.AutoSize = true;
            this.labelNumeroControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroControl.Location = new System.Drawing.Point(69, 120);
            this.labelNumeroControl.Name = "labelNumeroControl";
            this.labelNumeroControl.Size = new System.Drawing.Size(142, 20);
            this.labelNumeroControl.TabIndex = 5;
            this.labelNumeroControl.Text = "Número de Control";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(146, 156);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Nombre";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.Location = new System.Drawing.Point(164, 195);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(47, 20);
            this.labelEdad.TabIndex = 7;
            this.labelEdad.Text = "Edad";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(148, 232);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(63, 20);
            this.labelGenero.TabIndex = 8;
            this.labelGenero.Text = "Género";
            // 
            // botonMostrar
            // 
            this.botonMostrar.Location = new System.Drawing.Point(367, 279);
            this.botonMostrar.Name = "botonMostrar";
            this.botonMostrar.Size = new System.Drawing.Size(95, 35);
            this.botonMostrar.TabIndex = 9;
            this.botonMostrar.Text = "Mostrar";
            this.botonMostrar.UseVisualStyleBackColor = true;
            this.botonMostrar.Click += new System.EventHandler(this.botonMostrar_Click);
            // 
            // FormaEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 326);
            this.Controls.Add(this.botonMostrar);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNumeroControl);
            this.Controls.Add(this.LabelEstudiante);
            this.Controls.Add(this.textoGenero);
            this.Controls.Add(this.textoEdad);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.textoNumeroControl);
            this.Name = "FormaEstudiante";
            this.Text = "FormaEstudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoNumeroControl;
        private System.Windows.Forms.TextBox textoNombre;
        private System.Windows.Forms.TextBox textoEdad;
        private System.Windows.Forms.TextBox textoGenero;
        private System.Windows.Forms.Label LabelEstudiante;
        private System.Windows.Forms.Label labelNumeroControl;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Button botonMostrar;
    }
}