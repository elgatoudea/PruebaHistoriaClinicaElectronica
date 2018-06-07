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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvListadoPacientes = new System.Windows.Forms.DataGridView();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.cboTipoDocumento);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(457, 53);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "&Tipo de Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Número de &ID";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(362, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(157, 56);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(176, 20);
            this.txtID.TabIndex = 10;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(157, 15);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(176, 21);
            this.cboTipoDocumento.TabIndex = 12;
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
            this.dgvListadoPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroDocumento,
            this.Nombres,
            this.PrimerApellido,
            this.SegundoApellido,
            this.FechaNacimiento,
            this.Telefono,
            this.IdEstadoCivil});
            this.dgvListadoPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoPacientes.Location = new System.Drawing.Point(0, 0);
            this.dgvListadoPacientes.Name = "dgvListadoPacientes";
            this.dgvListadoPacientes.ReadOnly = true;
            this.dgvListadoPacientes.Size = new System.Drawing.Size(1000, 368);
            this.dgvListadoPacientes.TabIndex = 0;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.DataPropertyName = "NumeroDocumento";
            this.NumeroDocumento.HeaderText = "Número de Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.DataPropertyName = "PrimerApellido";
            this.PrimerApellido.HeaderText = "Primer Apellido";
            this.PrimerApellido.Name = "PrimerApellido";
            this.PrimerApellido.ReadOnly = true;
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.DataPropertyName = "SegundoApellido";
            this.SegundoApellido.HeaderText = "Segundo Apellido";
            this.SegundoApellido.Name = "SegundoApellido";
            this.SegundoApellido.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // IdEstadoCivil
            // 
            this.IdEstadoCivil.DataPropertyName = "IdEstadoCivil";
            this.IdEstadoCivil.HeaderText = "Estado Civil";
            this.IdEstadoCivil.Name = "IdEstadoCivil";
            this.IdEstadoCivil.ReadOnly = true;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstadoCivil;
    }
}