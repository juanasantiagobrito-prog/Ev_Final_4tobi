namespace Ev_Final_4tobi
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
            this.TextUsuario = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.BtnIngesar = new System.Windows.Forms.Button();
            this.LBL1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextUsuario
            // 
            this.TextUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextUsuario.Location = new System.Drawing.Point(114, 58);
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(100, 22);
            this.TextUsuario.TabIndex = 0;
            this.TextUsuario.TextChanged += new System.EventHandler(this.textUsuaio_TextChanged);
            // 
            // textContraseña
            // 
            this.textContraseña.ForeColor = System.Drawing.Color.Red;
            this.textContraseña.Location = new System.Drawing.Point(342, 58);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(100, 22);
            this.textContraseña.TabIndex = 1;
            this.textContraseña.TextChanged += new System.EventHandler(this.textContraseña_TextChanged);
            // 
            // BtnIngesar
            // 
            this.BtnIngesar.Location = new System.Drawing.Point(128, 122);
            this.BtnIngesar.Name = "BtnIngesar";
            this.BtnIngesar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngesar.TabIndex = 2;
            this.BtnIngesar.Text = "Ingresar";
            this.BtnIngesar.UseVisualStyleBackColor = true;
            this.BtnIngesar.Click += new System.EventHandler(this.BtnIngesar_Click);
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Location = new System.Drawing.Point(325, 122);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(88, 16);
            this.LBL1.TabIndex = 3;
            this.LBL1.Text = "Examen Final";
            this.LBL1.Click += new System.EventHandler(this.LBL1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.BtnIngesar);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.TextUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextUsuario;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Button BtnIngesar;
        private System.Windows.Forms.Label LBL1;
    }
}

