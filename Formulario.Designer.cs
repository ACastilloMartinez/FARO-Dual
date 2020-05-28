namespace FARO_Dual
{
    partial class Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblTerreno = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.cbVehiculo = new System.Windows.Forms.ComboBox();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.cbTerreno = new System.Windows.Forms.ComboBox();
            this.cbTiempo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(12, 639);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(200, 75);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 752);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(200, 75);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(20, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(278, 37);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre del piloto:";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(12, 82);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(286, 37);
            this.lblVehiculo.TabIndex = 4;
            this.lblVehiculo.Text = "Vehiculo del piloto:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(74, 140);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(224, 37);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "Hora de vuelo:";
            // 
            // lblTerreno
            // 
            this.lblTerreno.AutoSize = true;
            this.lblTerreno.BackColor = System.Drawing.Color.Transparent;
            this.lblTerreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerreno.Location = new System.Drawing.Point(645, 22);
            this.lblTerreno.Name = "lblTerreno";
            this.lblTerreno.Size = new System.Drawing.Size(423, 37);
            this.lblTerreno.TabIndex = 6;
            this.lblTerreno.Text = "Terreno de la zona de vuelo:";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(650, 82);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(418, 37);
            this.lblTiempo.TabIndex = 7;
            this.lblTiempo.Text = "Tiempo de la zona de vuelo:";
            // 
            // cbNombre
            // 
            this.cbNombre.Enabled = false;
            this.cbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(304, 19);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(335, 45);
            this.cbNombre.TabIndex = 8;
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Location = new System.Drawing.Point(304, 79);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(335, 45);
            this.cbVehiculo.TabIndex = 9;
            // 
            // cbHora
            // 
            this.cbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Location = new System.Drawing.Point(304, 137);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(335, 45);
            this.cbHora.TabIndex = 10;
            // 
            // cbTerreno
            // 
            this.cbTerreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTerreno.FormattingEnabled = true;
            this.cbTerreno.Location = new System.Drawing.Point(1074, 19);
            this.cbTerreno.Name = "cbTerreno";
            this.cbTerreno.Size = new System.Drawing.Size(335, 45);
            this.cbTerreno.TabIndex = 11;
            // 
            // cbTiempo
            // 
            this.cbTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTiempo.FormattingEnabled = true;
            this.cbTiempo.Location = new System.Drawing.Point(1074, 79);
            this.cbTiempo.Name = "cbTiempo";
            this.cbTiempo.Size = new System.Drawing.Size(335, 45);
            this.cbTiempo.TabIndex = 12;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FARO_Dual.Properties.Resources.avion2;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.cbTiempo);
            this.Controls.Add(this.cbTerreno);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.cbVehiculo);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblTerreno);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEnviar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Análisis de Riesgo Operativo (FARO) | Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblTerreno;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.ComboBox cbVehiculo;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.ComboBox cbTerreno;
        private System.Windows.Forms.ComboBox cbTiempo;
    }
}