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
            this.bAgregar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.lblLibreta = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.tBDocumento = new System.Windows.Forms.TextBox();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.tBLibreta = new System.Windows.Forms.TextBox();
            this.lBLibreta = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(355, 48);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(119, 49);
            this.bAgregar.TabIndex = 0;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(355, 103);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(119, 49);
            this.bCancelar.TabIndex = 1;
            this.bCancelar.Text = "Remover";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(355, 158);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(119, 49);
            this.bSalir.TabIndex = 2;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // lblLibreta
            // 
            this.lblLibreta.AutoSize = true;
            this.lblLibreta.Location = new System.Drawing.Point(90, 66);
            this.lblLibreta.Name = "lblLibreta";
            this.lblLibreta.Size = new System.Drawing.Size(39, 13);
            this.lblLibreta.TabIndex = 3;
            this.lblLibreta.Text = "Libreta";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(90, 121);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(72, 176);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 5;
            this.lblDocumento.Text = "Documento";
            // 
            // tBDocumento
            // 
            this.tBDocumento.Location = new System.Drawing.Point(135, 173);
            this.tBDocumento.Name = "tBDocumento";
            this.tBDocumento.Size = new System.Drawing.Size(100, 20);
            this.tBDocumento.TabIndex = 6;
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(135, 118);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(100, 20);
            this.tBNombre.TabIndex = 7;
            // 
            // tBLibreta
            // 
            this.tBLibreta.Location = new System.Drawing.Point(135, 63);
            this.tBLibreta.Name = "tBLibreta";
            this.tBLibreta.Size = new System.Drawing.Size(100, 20);
            this.tBLibreta.TabIndex = 8;
            // 
            // lBLibreta
            // 
            this.lBLibreta.FormattingEnabled = true;
            this.lBLibreta.Location = new System.Drawing.Point(75, 229);
            this.lBLibreta.Name = "lBLibreta";
            this.lBLibreta.Size = new System.Drawing.Size(399, 95);
            this.lBLibreta.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 336);
            this.Controls.Add(this.lBLibreta);
            this.Controls.Add(this.tBLibreta);
            this.Controls.Add(this.tBNombre);
            this.Controls.Add(this.tBDocumento);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblLibreta);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Label lblLibreta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox tBDocumento;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.TextBox tBLibreta;
        private System.Windows.Forms.ListBox lBLibreta;
    }
}

