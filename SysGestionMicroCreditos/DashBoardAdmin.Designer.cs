namespace SysGestionMicroCreditos
{
    partial class dashboardadmin
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
            this.mensajeadmin = new System.Windows.Forms.Label();
            this.labladmin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mensajeadmin
            // 
            this.mensajeadmin.AutoSize = true;
            this.mensajeadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeadmin.Location = new System.Drawing.Point(121, 50);
            this.mensajeadmin.Name = "mensajeadmin";
            this.mensajeadmin.Size = new System.Drawing.Size(0, 25);
            this.mensajeadmin.TabIndex = 0;
            this.mensajeadmin.Click += new System.EventHandler(this.label1_Click);
            // 
            // labladmin
            // 
            this.labladmin.AutoSize = true;
            this.labladmin.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labladmin.ForeColor = System.Drawing.Color.Red;
            this.labladmin.Location = new System.Drawing.Point(12, 9);
            this.labladmin.Name = "labladmin";
            this.labladmin.Size = new System.Drawing.Size(307, 31);
            this.labladmin.TabIndex = 1;
            this.labladmin.Text = "D y H Prestamos y Asocs";
            this.labladmin.Click += new System.EventHandler(this.labladmin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 65);
            this.button2.TabIndex = 3;
            this.button2.Text = "GESTIONAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SysGestionMicroCreditos.Properties.Resources.logoSistema;
            this.pictureBox1.Location = new System.Drawing.Point(209, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 345);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labladmin);
            this.Controls.Add(this.mensajeadmin);
            this.Name = "dashboardadmin";
            this.Text = "DashBoard Admin";
            this.Load += new System.EventHandler(this.dashboardadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mensajeadmin;
        private System.Windows.Forms.Label labladmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}