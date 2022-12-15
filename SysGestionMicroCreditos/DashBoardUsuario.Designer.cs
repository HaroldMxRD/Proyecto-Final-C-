namespace SysGestionMicroCreditos
{
    partial class dashboardusuario
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
            this.mensajeusuario = new System.Windows.Forms.Label();
            this.tipodeusuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mensajeusuario
            // 
            this.mensajeusuario.AutoSize = true;
            this.mensajeusuario.Location = new System.Drawing.Point(391, 183);
            this.mensajeusuario.Name = "mensajeusuario";
            this.mensajeusuario.Size = new System.Drawing.Size(0, 20);
            this.mensajeusuario.TabIndex = 0;
            // 
            // tipodeusuario
            // 
            this.tipodeusuario.AutoSize = true;
            this.tipodeusuario.Location = new System.Drawing.Point(339, 349);
            this.tipodeusuario.Name = "tipodeusuario";
            this.tipodeusuario.Size = new System.Drawing.Size(72, 20);
            this.tipodeusuario.TabIndex = 1;
            this.tipodeusuario.Text = "Usuario: ";
            this.tipodeusuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // dashboardusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 507);
            this.Controls.Add(this.tipodeusuario);
            this.Controls.Add(this.mensajeusuario);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "dashboardusuario";
            this.Text = "DashBoardUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mensajeusuario;
        private System.Windows.Forms.Label tipodeusuario;
    }
}