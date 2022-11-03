namespace WindowsPresentacion
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
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.lstMedicosClinicos = new System.Windows.Forms.ListBox();
            this.btnVerMedicos = new System.Windows.Forms.Button();
            this.lstHabitaciones = new System.Windows.Forms.ListBox();
            this.btnVerPacientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDatos
            // 
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Location = new System.Drawing.Point(54, 187);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.Size = new System.Drawing.Size(244, 150);
            this.gridDatos.TabIndex = 0;
            // 
            // lstMedicosClinicos
            // 
            this.lstMedicosClinicos.FormattingEnabled = true;
            this.lstMedicosClinicos.Location = new System.Drawing.Point(360, 232);
            this.lstMedicosClinicos.Name = "lstMedicosClinicos";
            this.lstMedicosClinicos.Size = new System.Drawing.Size(120, 95);
            this.lstMedicosClinicos.TabIndex = 1;
            // 
            // btnVerMedicos
            // 
            this.btnVerMedicos.Location = new System.Drawing.Point(74, 109);
            this.btnVerMedicos.Name = "btnVerMedicos";
            this.btnVerMedicos.Size = new System.Drawing.Size(206, 37);
            this.btnVerMedicos.TabIndex = 2;
            this.btnVerMedicos.Text = "Ver Medicos";
            this.btnVerMedicos.UseVisualStyleBackColor = true;
            this.btnVerMedicos.Click += new System.EventHandler(this.btnVerMedicos_Click);
            // 
            // lstHabitaciones
            // 
            this.lstHabitaciones.FormattingEnabled = true;
            this.lstHabitaciones.Location = new System.Drawing.Point(576, 232);
            this.lstHabitaciones.Name = "lstHabitaciones";
            this.lstHabitaciones.Size = new System.Drawing.Size(120, 95);
            this.lstHabitaciones.TabIndex = 3;
            // 
            // btnVerPacientes
            // 
            this.btnVerPacientes.Location = new System.Drawing.Point(360, 169);
            this.btnVerPacientes.Name = "btnVerPacientes";
            this.btnVerPacientes.Size = new System.Drawing.Size(128, 23);
            this.btnVerPacientes.TabIndex = 4;
            this.btnVerPacientes.Text = "Ver pacientes";
            this.btnVerPacientes.UseVisualStyleBackColor = true;
            this.btnVerPacientes.Click += new System.EventHandler(this.btnVerPacientes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerPacientes);
            this.Controls.Add(this.lstHabitaciones);
            this.Controls.Add(this.btnVerMedicos);
            this.Controls.Add(this.lstMedicosClinicos);
            this.Controls.Add(this.gridDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDatos;
        private System.Windows.Forms.ListBox lstMedicosClinicos;
        private System.Windows.Forms.Button btnVerMedicos;
        private System.Windows.Forms.ListBox lstHabitaciones;
        private System.Windows.Forms.Button btnVerPacientes;
    }
}

