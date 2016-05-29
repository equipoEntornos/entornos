namespace Juego
{
    partial class Form3
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
            this.btnMatematicas = new System.Windows.Forms.Button();
            this.btnLengua = new System.Windows.Forms.Button();
            this.btnSociales = new System.Windows.Forms.Button();
            this.btnNaturales = new System.Windows.Forms.Button();
            this.btnIngles = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.pnlConversacion = new System.Windows.Forms.Panel();
            this.pnlPersonaje1 = new System.Windows.Forms.Panel();
            this.pnlPersonaje2 = new System.Windows.Forms.Panel();
            this.txtDialogo = new System.Windows.Forms.TextBox();
            this.pnlBotones.SuspendLayout();
            this.pnlConversacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMatematicas
            // 
            this.btnMatematicas.AutoSize = true;
            this.btnMatematicas.Location = new System.Drawing.Point(26, 33);
            this.btnMatematicas.Name = "btnMatematicas";
            this.btnMatematicas.Size = new System.Drawing.Size(173, 63);
            this.btnMatematicas.TabIndex = 0;
            this.btnMatematicas.Text = "MATEMATICAS";
            this.btnMatematicas.UseVisualStyleBackColor = true;
            // 
            // btnLengua
            // 
            this.btnLengua.Location = new System.Drawing.Point(205, 33);
            this.btnLengua.Name = "btnLengua";
            this.btnLengua.Size = new System.Drawing.Size(153, 68);
            this.btnLengua.TabIndex = 1;
            this.btnLengua.Text = "LENGUA";
            this.btnLengua.UseVisualStyleBackColor = true;
            // 
            // btnSociales
            // 
            this.btnSociales.Location = new System.Drawing.Point(364, 33);
            this.btnSociales.Name = "btnSociales";
            this.btnSociales.Size = new System.Drawing.Size(153, 68);
            this.btnSociales.TabIndex = 2;
            this.btnSociales.Text = "SOCIALES";
            this.btnSociales.UseVisualStyleBackColor = true;
            // 
            // btnNaturales
            // 
            this.btnNaturales.Location = new System.Drawing.Point(26, 107);
            this.btnNaturales.Name = "btnNaturales";
            this.btnNaturales.Size = new System.Drawing.Size(153, 68);
            this.btnNaturales.TabIndex = 3;
            this.btnNaturales.Text = "NATURALES";
            this.btnNaturales.UseVisualStyleBackColor = true;
            // 
            // btnIngles
            // 
            this.btnIngles.Location = new System.Drawing.Point(185, 107);
            this.btnIngles.Name = "btnIngles";
            this.btnIngles.Size = new System.Drawing.Size(153, 68);
            this.btnIngles.TabIndex = 4;
            this.btnIngles.Text = "INGLÉS";
            this.btnIngles.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(947, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlBotones
            // 
            this.pnlBotones.AutoSize = true;
            this.pnlBotones.Controls.Add(this.btnMatematicas);
            this.pnlBotones.Controls.Add(this.btnIngles);
            this.pnlBotones.Controls.Add(this.btnSociales);
            this.pnlBotones.Controls.Add(this.btnNaturales);
            this.pnlBotones.Controls.Add(this.btnLengua);
            this.pnlBotones.Location = new System.Drawing.Point(236, 33);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(551, 238);
            this.pnlBotones.TabIndex = 6;
            // 
            // pnlConversacion
            // 
            this.pnlConversacion.Controls.Add(this.txtDialogo);
            this.pnlConversacion.Controls.Add(this.pnlPersonaje2);
            this.pnlConversacion.Controls.Add(this.pnlPersonaje1);
            this.pnlConversacion.Location = new System.Drawing.Point(0, 581);
            this.pnlConversacion.Name = "pnlConversacion";
            this.pnlConversacion.Size = new System.Drawing.Size(1022, 187);
            this.pnlConversacion.TabIndex = 7;
            // 
            // pnlPersonaje1
            // 
            this.pnlPersonaje1.Location = new System.Drawing.Point(4, 0);
            this.pnlPersonaje1.Name = "pnlPersonaje1";
            this.pnlPersonaje1.Size = new System.Drawing.Size(172, 184);
            this.pnlPersonaje1.TabIndex = 0;
            // 
            // pnlPersonaje2
            // 
            this.pnlPersonaje2.Location = new System.Drawing.Point(850, 0);
            this.pnlPersonaje2.Name = "pnlPersonaje2";
            this.pnlPersonaje2.Size = new System.Drawing.Size(172, 187);
            this.pnlPersonaje2.TabIndex = 1;
            // 
            // txtDialogo
            // 
            this.txtDialogo.Location = new System.Drawing.Point(182, 1);
            this.txtDialogo.Multiline = true;
            this.txtDialogo.Name = "txtDialogo";
            this.txtDialogo.ReadOnly = true;
            this.txtDialogo.Size = new System.Drawing.Size(662, 183);
            this.txtDialogo.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pnlConversacion);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            this.pnlConversacion.ResumeLayout(false);
            this.pnlConversacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMatematicas;
        private System.Windows.Forms.Button btnLengua;
        private System.Windows.Forms.Button btnSociales;
        private System.Windows.Forms.Button btnNaturales;
        private System.Windows.Forms.Button btnIngles;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel pnlConversacion;
        private System.Windows.Forms.TextBox txtDialogo;
        private System.Windows.Forms.Panel pnlPersonaje2;
        private System.Windows.Forms.Panel pnlPersonaje1;
    }
}