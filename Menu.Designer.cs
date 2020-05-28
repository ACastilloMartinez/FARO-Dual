namespace FARO_Dual
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnFormulario = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormulario
            // 
            this.btnFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormulario.Location = new System.Drawing.Point(106, 418);
            this.btnFormulario.Name = "btnFormulario";
            this.btnFormulario.Size = new System.Drawing.Size(200, 75);
            this.btnFormulario.TabIndex = 0;
            this.btnFormulario.Text = "INICIAR FARO";
            this.btnFormulario.UseVisualStyleBackColor = true;
            this.btnFormulario.Click += new System.EventHandler(this.btnFormulario_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.Location = new System.Drawing.Point(1299, 418);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(200, 75);
            this.btnInformacion.TabIndex = 1;
            this.btnInformacion.Text = "INFORMACIÓN PILOTO";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.Location = new System.Drawing.Point(771, 725);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(200, 75);
            this.btnLogOff.TabIndex = 2;
            this.btnLogOff.Text = "SALIR";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FARO_Dual.Properties.Resources.avion1;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.btnFormulario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Análisis de Riesgo Operativo (FARO) | Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormulario;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnLogOff;
    }
}