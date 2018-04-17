namespace MiCalculadora
{
    partial class LaCalculadora
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.NumeroUno = new System.Windows.Forms.TextBox();
            this.NumeroDos = new System.Windows.Forms.TextBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(252, 193);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 23);
            this.btnDecimal.TabIndex = 0;
            this.btnDecimal.Text = "Decimal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(54, 193);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(75, 23);
            this.btnBinario.TabIndex = 1;
            this.btnBinario.Text = "Binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(342, 9);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 17);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // cmbOperador
            // 
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Location = new System.Drawing.Point(158, 36);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(99, 24);
            this.cmbOperador.TabIndex = 7;
            this.cmbOperador.SelectedIndexChanged += new System.EventHandler(this.cmbOperador_SelectedIndexChanged);
            // 
            // NumeroUno
            // 
            this.NumeroUno.Location = new System.Drawing.Point(12, 36);
            this.NumeroUno.Name = "NumeroUno";
            this.NumeroUno.Size = new System.Drawing.Size(100, 22);
            this.NumeroUno.TabIndex = 8;
            // 
            // NumeroDos
            // 
            this.NumeroDos.Location = new System.Drawing.Point(287, 36);
            this.NumeroDos.Name = "NumeroDos";
            this.NumeroDos.Size = new System.Drawing.Size(100, 22);
            this.NumeroDos.TabIndex = 9;
            this.NumeroDos.TextChanged += new System.EventHandler(this.NumeroDos_TextChanged);
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(54, 107);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(75, 23);
            this.btnOperar.TabIndex = 10;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(182, 107);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(312, 107);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // LaCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 253);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.NumeroDos);
            this.Controls.Add(this.NumeroUno);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnDecimal);
            this.Name = "LaCalculadora";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.TextBox NumeroUno;
        private System.Windows.Forms.TextBox NumeroDos;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
    }
}

