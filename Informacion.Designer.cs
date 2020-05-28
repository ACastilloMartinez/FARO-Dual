namespace FARO_Dual
{
    partial class Informacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informacion));
            this.btnForms = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRango = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblResUser = new System.Windows.Forms.Label();
            this.lblResNom = new System.Windows.Forms.Label();
            this.lblResRank = new System.Windows.Forms.Label();
            this.lblResNiv = new System.Windows.Forms.Label();
            this.dgvForms = new System.Windows.Forms.DataGridView();
            this.formularioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.airforcedbDataSet = new FARO_Dual.airforcedbDataSet();
            this.formularioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airforcedbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formularioTableAdapter = new FARO_Dual.airforcedbDataSetTableAdapters.formularioTableAdapter();
            this.airforcedbDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nivelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nivelTableAdapter = new FARO_Dual.airforcedbDataSetTableAdapters.nivelTableAdapter();
            this.airforcedbDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.id_form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_pil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_veh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_ter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_ti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_val = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formularioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airforcedbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formularioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airforcedbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airforcedbDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airforcedbDataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnForms
            // 
            this.btnForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForms.Location = new System.Drawing.Point(12, 661);
            this.btnForms.Name = "btnForms";
            this.btnForms.Size = new System.Drawing.Size(200, 75);
            this.btnForms.TabIndex = 0;
            this.btnForms.Text = "VER FORMULARIOS";
            this.btnForms.UseVisualStyleBackColor = true;
            this.btnForms.Click += new System.EventHandler(this.btnForms_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 760);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(200, 75);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(31, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(274, 37);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario del piloto:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(27, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(278, 37);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre del piloto:";
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.BackColor = System.Drawing.Color.Transparent;
            this.lblRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRango.Location = new System.Drawing.Point(48, 107);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(257, 37);
            this.lblRango.TabIndex = 4;
            this.lblRango.Text = "Rango del piloto:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(72, 158);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(233, 37);
            this.lblNivel.TabIndex = 5;
            this.lblNivel.Text = "Nivel del piloto:";
            // 
            // lblResUser
            // 
            this.lblResUser.AutoSize = true;
            this.lblResUser.BackColor = System.Drawing.Color.Transparent;
            this.lblResUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResUser.Location = new System.Drawing.Point(311, 9);
            this.lblResUser.Name = "lblResUser";
            this.lblResUser.Size = new System.Drawing.Size(0, 37);
            this.lblResUser.TabIndex = 6;
            // 
            // lblResNom
            // 
            this.lblResNom.AutoSize = true;
            this.lblResNom.BackColor = System.Drawing.Color.Transparent;
            this.lblResNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResNom.Location = new System.Drawing.Point(311, 58);
            this.lblResNom.Name = "lblResNom";
            this.lblResNom.Size = new System.Drawing.Size(0, 37);
            this.lblResNom.TabIndex = 7;
            // 
            // lblResRank
            // 
            this.lblResRank.AutoSize = true;
            this.lblResRank.BackColor = System.Drawing.Color.Transparent;
            this.lblResRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResRank.Location = new System.Drawing.Point(311, 107);
            this.lblResRank.Name = "lblResRank";
            this.lblResRank.Size = new System.Drawing.Size(0, 37);
            this.lblResRank.TabIndex = 8;
            // 
            // lblResNiv
            // 
            this.lblResNiv.AutoSize = true;
            this.lblResNiv.BackColor = System.Drawing.Color.Transparent;
            this.lblResNiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResNiv.Location = new System.Drawing.Point(311, 158);
            this.lblResNiv.Name = "lblResNiv";
            this.lblResNiv.Size = new System.Drawing.Size(0, 37);
            this.lblResNiv.TabIndex = 9;
            // 
            // dgvForms
            // 
            this.dgvForms.AllowUserToAddRows = false;
            this.dgvForms.AllowUserToDeleteRows = false;
            this.dgvForms.AllowUserToResizeColumns = false;
            this.dgvForms.AllowUserToResizeRows = false;
            this.dgvForms.AutoGenerateColumns = false;
            this.dgvForms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_form,
            this.nombre_pil,
            this.nombre_veh,
            this.descripcion_h,
            this.descripcion_ter,
            this.descripcion_ti,
            this.descripcion_val});
            this.dgvForms.DataSource = this.formularioBindingSource1;
            this.dgvForms.Location = new System.Drawing.Point(827, 661);
            this.dgvForms.Name = "dgvForms";
            this.dgvForms.ReadOnly = true;
            this.dgvForms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvForms.Size = new System.Drawing.Size(745, 188);
            this.dgvForms.TabIndex = 10;
            // 
            // formularioBindingSource1
            // 
            this.formularioBindingSource1.DataMember = "formulario";
            this.formularioBindingSource1.DataSource = this.airforcedbDataSet;
            // 
            // airforcedbDataSet
            // 
            this.airforcedbDataSet.DataSetName = "airforcedbDataSet";
            this.airforcedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airforcedbDataSetBindingSource
            // 
            this.airforcedbDataSetBindingSource.DataSource = this.airforcedbDataSet;
            this.airforcedbDataSetBindingSource.Position = 0;
            // 
            // formularioTableAdapter
            // 
            this.formularioTableAdapter.ClearBeforeFill = true;
            // 
            // airforcedbDataSetBindingSource1
            // 
            this.airforcedbDataSetBindingSource1.DataSource = this.airforcedbDataSet;
            this.airforcedbDataSetBindingSource1.Position = 0;
            // 
            // nivelBindingSource
            // 
            this.nivelBindingSource.DataMember = "nivel";
            this.nivelBindingSource.DataSource = this.airforcedbDataSetBindingSource1;
            // 
            // nivelTableAdapter
            // 
            this.nivelTableAdapter.ClearBeforeFill = true;
            // 
            // airforcedbDataSetBindingSource2
            // 
            this.airforcedbDataSetBindingSource2.DataSource = this.airforcedbDataSet;
            this.airforcedbDataSetBindingSource2.Position = 0;
            // 
            // id_form
            // 
            this.id_form.DataPropertyName = "id_form";
            this.id_form.HeaderText = "ID Formulario";
            this.id_form.Name = "id_form";
            this.id_form.ReadOnly = true;
            // 
            // nombre_pil
            // 
            this.nombre_pil.DataPropertyName = "nombre_pil";
            this.nombre_pil.HeaderText = "Piloto";
            this.nombre_pil.Name = "nombre_pil";
            this.nombre_pil.ReadOnly = true;
            // 
            // nombre_veh
            // 
            this.nombre_veh.DataPropertyName = "nombre_veh";
            this.nombre_veh.HeaderText = "Vehiculo";
            this.nombre_veh.Name = "nombre_veh";
            this.nombre_veh.ReadOnly = true;
            // 
            // descripcion_h
            // 
            this.descripcion_h.DataPropertyName = "descripcion_h";
            this.descripcion_h.HeaderText = "Hora";
            this.descripcion_h.Name = "descripcion_h";
            this.descripcion_h.ReadOnly = true;
            // 
            // descripcion_ter
            // 
            this.descripcion_ter.DataPropertyName = "descripcion_ter";
            this.descripcion_ter.HeaderText = "Terreno";
            this.descripcion_ter.Name = "descripcion_ter";
            this.descripcion_ter.ReadOnly = true;
            // 
            // descripcion_ti
            // 
            this.descripcion_ti.DataPropertyName = "descripcion_ti";
            this.descripcion_ti.HeaderText = "Tiempo";
            this.descripcion_ti.Name = "descripcion_ti";
            this.descripcion_ti.ReadOnly = true;
            // 
            // descripcion_val
            // 
            this.descripcion_val.DataPropertyName = "descripcion_val";
            this.descripcion_val.HeaderText = "¿Autorizado?";
            this.descripcion_val.Name = "descripcion_val";
            this.descripcion_val.ReadOnly = true;
            // 
            // Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FARO_Dual.Properties.Resources.avion5;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.dgvForms);
            this.Controls.Add(this.lblResNiv);
            this.Controls.Add(this.lblResRank);
            this.Controls.Add(this.lblResNom);
            this.Controls.Add(this.lblResUser);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblRango);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnForms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Informacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Análisis de Riesgo Operativo (FARO) | Información sobre el piloto";
            this.Load += new System.EventHandler(this.Informacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formularioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airforcedbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formularioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airforcedbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airforcedbDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airforcedbDataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForms;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblResUser;
        private System.Windows.Forms.Label lblResNom;
        private System.Windows.Forms.Label lblResRank;
        private System.Windows.Forms.Label lblResNiv;
        private System.Windows.Forms.DataGridView dgvForms;

        private System.Windows.Forms.BindingSource formularioBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn idformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpilotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idterrenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtiempoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource airforcedbDataSetBindingSource;
        private airforcedbDataSet airforcedbDataSet;
        private System.Windows.Forms.BindingSource formularioBindingSource1;
        private airforcedbDataSetTableAdapters.formularioTableAdapter formularioTableAdapter;
        private System.Windows.Forms.BindingSource airforcedbDataSetBindingSource1;
        private System.Windows.Forms.BindingSource nivelBindingSource;
        private airforcedbDataSetTableAdapters.nivelTableAdapter nivelTableAdapter;
        private System.Windows.Forms.BindingSource airforcedbDataSetBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_form;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_pil;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_veh;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_h;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_ter;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_ti;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_val;
    }
}