namespace HistoriaClinicaElectronica.Interfaz
{
    partial class Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvListadoPacientes = new System.Windows.Forms.DataGridView();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoSangre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVinculacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoFijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CualDeporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoLibre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CualTiempoLibre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProblemaSalud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsumoSustancias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TratamientoPsicologico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttpMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMostrarTodo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(431, 37);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(126, 23);
            this.btnMostrarTodo.TabIndex = 23;
            this.btnMostrarTodo.Text = "&Mostrar todos los datos";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HistoriaClinicaElectronica.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(591, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Número de &ID";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(293, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "&Buscar";
            this.ttpMensaje.SetToolTip(this.btnBuscar, "Para Poder Buscar debes comprar la licencia");
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(102, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(176, 20);
            this.txtID.TabIndex = 10;
            this.ttpMensaje.SetToolTip(this.txtID, "Para poder Buscar debes comprar la licencia");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvListadoPacientes);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 368);
            this.panel2.TabIndex = 1;
            // 
            // dgvListadoPacientes
            // 
            this.dgvListadoPacientes.AllowUserToAddRows = false;
            this.dgvListadoPacientes.AllowUserToDeleteRows = false;
            this.dgvListadoPacientes.AllowUserToOrderColumns = true;
            this.dgvListadoPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvListadoPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDocumento,
            this.NumeroDocumento,
            this.Nombres,
            this.PrimerApellido,
            this.SegundoApellido,
            this.Sexo,
            this.TipoSangre,
            this.FechaNacimiento,
            this.TipoVinculacion,
            this.TelefonoFijo,
            this.Telefono,
            this.IdEstadoCivil,
            this.Deporte,
            this.CualDeporte,
            this.TiempoLibre,
            this.CualTiempoLibre,
            this.ProblemaSalud,
            this.Medicamento,
            this.ConsumoSustancias,
            this.TratamientoPsicologico,
            this.Tratamiento,
            this.Otros});
            this.dgvListadoPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoPacientes.Location = new System.Drawing.Point(0, 0);
            this.dgvListadoPacientes.Name = "dgvListadoPacientes";
            this.dgvListadoPacientes.ReadOnly = true;
            this.dgvListadoPacientes.Size = new System.Drawing.Size(1000, 368);
            this.dgvListadoPacientes.TabIndex = 0;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TipoDocumento.DataPropertyName = "IdTipoDocumento";
            this.TipoDocumento.HeaderText = "Tipo de Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 115;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.DataPropertyName = "NumeroDocumento";
            this.NumeroDocumento.HeaderText = "Número de Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Width = 130;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 74;
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.DataPropertyName = "PrimerApellido";
            this.PrimerApellido.HeaderText = "Primer Apellido";
            this.PrimerApellido.Name = "PrimerApellido";
            this.PrimerApellido.ReadOnly = true;
            this.PrimerApellido.Width = 93;
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.DataPropertyName = "SegundoApellido";
            this.SegundoApellido.HeaderText = "Segundo Apellido";
            this.SegundoApellido.Name = "SegundoApellido";
            this.SegundoApellido.ReadOnly = true;
            this.SegundoApellido.Width = 105;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 56;
            // 
            // TipoSangre
            // 
            this.TipoSangre.DataPropertyName = "IdTipoSangre";
            this.TipoSangre.HeaderText = "Tipo de Sangre";
            this.TipoSangre.Name = "TipoSangre";
            this.TipoSangre.ReadOnly = true;
            this.TipoSangre.Width = 96;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 122;
            // 
            // TipoVinculacion
            // 
            this.TipoVinculacion.DataPropertyName = "IdTipoVinculacion";
            this.TipoVinculacion.HeaderText = "Tipo de Vinculacion";
            this.TipoVinculacion.Name = "TipoVinculacion";
            this.TipoVinculacion.ReadOnly = true;
            this.TipoVinculacion.Width = 115;
            // 
            // TelefonoFijo
            // 
            this.TelefonoFijo.DataPropertyName = "TelefonoFijo";
            this.TelefonoFijo.HeaderText = "Telefono Fijo";
            this.TelefonoFijo.Name = "TelefonoFijo";
            this.TelefonoFijo.ReadOnly = true;
            this.TelefonoFijo.Width = 86;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono Celular";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // IdEstadoCivil
            // 
            this.IdEstadoCivil.DataPropertyName = "IdEstadoCivil";
            this.IdEstadoCivil.HeaderText = "Estado Civil";
            this.IdEstadoCivil.Name = "IdEstadoCivil";
            this.IdEstadoCivil.ReadOnly = true;
            this.IdEstadoCivil.Width = 80;
            // 
            // Deporte
            // 
            this.Deporte.DataPropertyName = "Deporte";
            this.Deporte.HeaderText = "Deporte";
            this.Deporte.Name = "Deporte";
            this.Deporte.ReadOnly = true;
            this.Deporte.Width = 70;
            // 
            // CualDeporte
            // 
            this.CualDeporte.DataPropertyName = "CualDeporte";
            this.CualDeporte.HeaderText = "Cual Deporte";
            this.CualDeporte.Name = "CualDeporte";
            this.CualDeporte.ReadOnly = true;
            this.CualDeporte.Width = 87;
            // 
            // TiempoLibre
            // 
            this.TiempoLibre.DataPropertyName = "TiempoLibre";
            this.TiempoLibre.HeaderText = "Tiempo Libre";
            this.TiempoLibre.Name = "TiempoLibre";
            this.TiempoLibre.ReadOnly = true;
            this.TiempoLibre.Width = 86;
            // 
            // CualTiempoLibre
            // 
            this.CualTiempoLibre.DataPropertyName = "CualTiempoLibre";
            this.CualTiempoLibre.HeaderText = "Cual Tiempo Libre";
            this.CualTiempoLibre.Name = "CualTiempoLibre";
            this.CualTiempoLibre.ReadOnly = true;
            this.CualTiempoLibre.Width = 107;
            // 
            // ProblemaSalud
            // 
            this.ProblemaSalud.DataPropertyName = "ProblemaSalud";
            this.ProblemaSalud.HeaderText = "Problema de Salud";
            this.ProblemaSalud.Name = "ProblemaSalud";
            this.ProblemaSalud.ReadOnly = true;
            this.ProblemaSalud.Width = 87;
            // 
            // Medicamento
            // 
            this.Medicamento.DataPropertyName = "Medicamento";
            this.Medicamento.HeaderText = "Medicamento";
            this.Medicamento.Name = "Medicamento";
            this.Medicamento.ReadOnly = true;
            this.Medicamento.Width = 96;
            // 
            // ConsumoSustancias
            // 
            this.ConsumoSustancias.DataPropertyName = "ConsumoSustancias";
            this.ConsumoSustancias.HeaderText = "Consumo de Sustancias";
            this.ConsumoSustancias.Name = "ConsumoSustancias";
            this.ConsumoSustancias.ReadOnly = true;
            this.ConsumoSustancias.Width = 133;
            // 
            // TratamientoPsicologico
            // 
            this.TratamientoPsicologico.DataPropertyName = "TratamientoPsicologico";
            this.TratamientoPsicologico.HeaderText = "Tratamiento Psicologico";
            this.TratamientoPsicologico.Name = "TratamientoPsicologico";
            this.TratamientoPsicologico.ReadOnly = true;
            this.TratamientoPsicologico.Width = 132;
            // 
            // Tratamiento
            // 
            this.Tratamiento.DataPropertyName = "Tratamiento";
            this.Tratamiento.HeaderText = "Tratamiento";
            this.Tratamiento.Name = "Tratamiento";
            this.Tratamiento.ReadOnly = true;
            this.Tratamiento.Width = 88;
            // 
            // Otros
            // 
            this.Otros.DataPropertyName = "Otros";
            this.Otros.HeaderText = "Otros";
            this.Otros.Name = "Otros";
            this.Otros.ReadOnly = true;
            this.Otros.Width = 57;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvListadoPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoSangre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVinculacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoFijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn CualDeporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoLibre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CualTiempoLibre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemaSalud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsumoSustancias;
        private System.Windows.Forms.DataGridViewTextBoxColumn TratamientoPsicologico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otros;
        private System.Windows.Forms.ToolTip ttpMensaje;
    }
}