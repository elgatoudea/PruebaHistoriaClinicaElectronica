namespace HistoriaClinicaElectronica.Interfaz
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbpHistoria = new System.Windows.Forms.TabPage();
            this.gbInformacionPaciente = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboEstrato = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.rbnFemenino = new System.Windows.Forms.RadioButton();
            this.rbnMasculino = new System.Windows.Forms.RadioButton();
            this.label41 = new System.Windows.Forms.Label();
            this.txtTelefonoFijo = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.cboTipoSangre = new System.Windows.Forms.ComboBox();
            this.cboTipoVinculacion = new System.Windows.Forms.ComboBox();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbpDatosPersonales = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtTratamientoPsicologico = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtConsumoSustancias = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtProblemaSalud = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbnSiDeporte = new System.Windows.Forms.RadioButton();
            this.rbnNoDeporte = new System.Windows.Forms.RadioButton();
            this.label36 = new System.Windows.Forms.Label();
            this.txtDeporte = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbnSiActividad = new System.Windows.Forms.RadioButton();
            this.rbnNoAcitividad = new System.Windows.Forms.RadioButton();
            this.txtTiempoLibre = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.erpMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.tbcPrincipal.SuspendLayout();
            this.tbpHistoria.SuspendLayout();
            this.gbInformacionPaciente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbpDatosPersonales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbcPrincipal.Controls.Add(this.tbpHistoria);
            this.tbcPrincipal.Controls.Add(this.tbpDatosPersonales);
            this.tbcPrincipal.Location = new System.Drawing.Point(12, 23);
            this.tbcPrincipal.Multiline = true;
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(1026, 523);
            this.tbcPrincipal.TabIndex = 1;
            // 
            // tbpHistoria
            // 
            this.tbpHistoria.Controls.Add(this.gbInformacionPaciente);
            this.tbpHistoria.Location = new System.Drawing.Point(23, 4);
            this.tbpHistoria.Name = "tbpHistoria";
            this.tbpHistoria.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHistoria.Size = new System.Drawing.Size(999, 515);
            this.tbpHistoria.TabIndex = 0;
            this.tbpHistoria.Text = "Anamnesis";
            this.tbpHistoria.UseVisualStyleBackColor = true;
            // 
            // gbInformacionPaciente
            // 
            this.gbInformacionPaciente.Controls.Add(this.panel1);
            this.gbInformacionPaciente.Controls.Add(this.panel2);
            this.gbInformacionPaciente.Controls.Add(this.dateTimePicker1);
            this.gbInformacionPaciente.Controls.Add(this.pictureBox1);
            this.gbInformacionPaciente.Location = new System.Drawing.Point(16, 18);
            this.gbInformacionPaciente.Name = "gbInformacionPaciente";
            this.gbInformacionPaciente.Size = new System.Drawing.Size(977, 488);
            this.gbInformacionPaciente.TabIndex = 20;
            this.gbInformacionPaciente.TabStop = false;
            this.gbInformacionPaciente.Text = "Información Personal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNumeroDocumento);
            this.panel1.Controls.Add(this.cboTipoDocumento);
            this.panel1.Location = new System.Drawing.Point(235, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 103);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "&Tipo de Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de &ID";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(162, 58);
            this.txtNumeroDocumento.MaxLength = 15;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(176, 20);
            this.txtNumeroDocumento.TabIndex = 2;
            this.txtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress_1);
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(162, 17);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(176, 21);
            this.cboTipoDocumento.TabIndex = 1;
            this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocumento_SelectedIndexChanged_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cboEstrato);
            this.panel2.Controls.Add(this.label39);
            this.panel2.Controls.Add(this.label49);
            this.panel2.Controls.Add(this.rbnFemenino);
            this.panel2.Controls.Add(this.rbnMasculino);
            this.panel2.Controls.Add(this.label41);
            this.panel2.Controls.Add(this.txtTelefonoFijo);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.cboTipoSangre);
            this.panel2.Controls.Add(this.cboTipoVinculacion);
            this.panel2.Controls.Add(this.cboEstadoCivil);
            this.panel2.Controls.Add(this.lblEstadoCivil);
            this.panel2.Controls.Add(this.dtpFechaNacimiento);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSegundoApellido);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPrimerApellido);
            this.panel2.Controls.Add(this.txtNombrePaciente);
            this.panel2.Location = new System.Drawing.Point(16, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 226);
            this.panel2.TabIndex = 17;
            // 
            // cboEstrato
            // 
            this.cboEstrato.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.cboEstrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEstrato.FormattingEnabled = true;
            this.cboEstrato.Location = new System.Drawing.Point(64, 150);
            this.cboEstrato.Name = "cboEstrato";
            this.cboEstrato.Size = new System.Drawing.Size(80, 21);
            this.cboEstrato.TabIndex = 11;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(9, 153);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(40, 13);
            this.label39.TabIndex = 48;
            this.label39.Text = "&Estrato";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(9, 108);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(31, 13);
            this.label49.TabIndex = 46;
            this.label49.Text = "&Sexo";
            // 
            // rbnFemenino
            // 
            this.rbnFemenino.AutoSize = true;
            this.rbnFemenino.Checked = true;
            this.rbnFemenino.Location = new System.Drawing.Point(64, 106);
            this.rbnFemenino.Name = "rbnFemenino";
            this.rbnFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbnFemenino.TabIndex = 7;
            this.rbnFemenino.TabStop = true;
            this.rbnFemenino.Text = "&Femenino";
            this.rbnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbnMasculino
            // 
            this.rbnMasculino.AutoSize = true;
            this.rbnMasculino.Location = new System.Drawing.Point(151, 106);
            this.rbnMasculino.Name = "rbnMasculino";
            this.rbnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbnMasculino.TabIndex = 8;
            this.rbnMasculino.Text = "&Masculino";
            this.rbnMasculino.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(295, 150);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(68, 13);
            this.label41.TabIndex = 43;
            this.label41.Text = "Teléfono Fi&jo";
            // 
            // txtTelefonoFijo
            // 
            this.txtTelefonoFijo.Location = new System.Drawing.Point(394, 150);
            this.txtTelefonoFijo.MaxLength = 10;
            this.txtTelefonoFijo.Name = "txtTelefonoFijo";
            this.txtTelefonoFijo.Size = new System.Drawing.Size(215, 20);
            this.txtTelefonoFijo.TabIndex = 12;
            this.txtTelefonoFijo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoFijo_KeyPress);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(867, 193);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 15;
            this.btnSiguiente.Text = "&Siguiente";
            this.ttMensaje.SetToolTip(this.btnSiguiente, "Regresa al Inicio del Programa");
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // cboTipoSangre
            // 
            this.cboTipoSangre.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.cboTipoSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoSangre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoSangre.FormattingEnabled = true;
            this.cboTipoSangre.Location = new System.Drawing.Point(732, 153);
            this.cboTipoSangre.Name = "cboTipoSangre";
            this.cboTipoSangre.Size = new System.Drawing.Size(82, 21);
            this.cboTipoSangre.TabIndex = 13;
            // 
            // cboTipoVinculacion
            // 
            this.cboTipoVinculacion.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.cboTipoVinculacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVinculacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoVinculacion.FormattingEnabled = true;
            this.cboTipoVinculacion.Location = new System.Drawing.Point(732, 15);
            this.cboTipoVinculacion.Name = "cboTipoVinculacion";
            this.cboTipoVinculacion.Size = new System.Drawing.Size(215, 21);
            this.cboTipoVinculacion.TabIndex = 3;
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(732, 111);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(145, 21);
            this.cboEstadoCivil.TabIndex = 10;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(626, 114);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(62, 13);
            this.lblEstadoCivil.TabIndex = 19;
            this.lblEstadoCivil.Text = "&Estado Civil";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(394, 108);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(215, 20);
            this.dtpFechaNacimiento.TabIndex = 9;
            this.dtpFechaNacimiento.Validating += new System.ComponentModel.CancelEventHandler(this.dtpFechaNacimiento_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Tipo de &Vinculación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tipo de San&gre";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(295, 193);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 13);
            this.label24.TabIndex = 32;
            this.label24.Text = "Teléfono &Celular";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(394, 190);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(215, 20);
            this.txtTelefono.TabIndex = 14;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(295, 108);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "&Fecha Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "&Segundo Apellido";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(732, 58);
            this.txtSegundoApellido.MaxLength = 100;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(215, 20);
            this.txtSegundoApellido.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "&Primer Apellido";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(394, 58);
            this.txtPrimerApellido.MaxLength = 100;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(215, 20);
            this.txtPrimerApellido.TabIndex = 5;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(64, 58);
            this.txtNombrePaciente.MaxLength = 100;
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(215, 20);
            this.txtNombrePaciente.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(397, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HistoriaClinicaElectronica.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(196, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // tbpDatosPersonales
            // 
            this.tbpDatosPersonales.Controls.Add(this.groupBox1);
            this.tbpDatosPersonales.Location = new System.Drawing.Point(23, 4);
            this.tbpDatosPersonales.Name = "tbpDatosPersonales";
            this.tbpDatosPersonales.Size = new System.Drawing.Size(999, 515);
            this.tbpDatosPersonales.TabIndex = 1;
            this.tbpDatosPersonales.Text = "Datos Personales";
            this.tbpDatosPersonales.ToolTipText = "Información de Datos Complementaria";
            this.tbpDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 511);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnGuardar);
            this.panel4.Controls.Add(this.label27);
            this.panel4.Controls.Add(this.txtOtros);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.txtTratamiento);
            this.panel4.Controls.Add(this.label29);
            this.panel4.Controls.Add(this.label30);
            this.panel4.Controls.Add(this.txtTratamientoPsicologico);
            this.panel4.Controls.Add(this.label31);
            this.panel4.Controls.Add(this.label32);
            this.panel4.Controls.Add(this.txtConsumoSustancias);
            this.panel4.Controls.Add(this.label33);
            this.panel4.Controls.Add(this.txtMedicamento);
            this.panel4.Controls.Add(this.label37);
            this.panel4.Controls.Add(this.txtProblemaSalud);
            this.panel4.Controls.Add(this.label38);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(29, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(889, 457);
            this.panel4.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(14, 419);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(101, 383);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 13);
            this.label27.TabIndex = 32;
            this.label27.Text = "Otros:";
            // 
            // txtOtros
            // 
            this.txtOtros.Location = new System.Drawing.Point(142, 380);
            this.txtOtros.Multiline = true;
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(728, 53);
            this.txtOtros.TabIndex = 28;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(37, 324);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(99, 13);
            this.label28.TabIndex = 30;
            this.label28.Text = "Tratamiento Actual:";
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Location = new System.Drawing.Point(142, 321);
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(728, 53);
            this.txtTratamiento.TabIndex = 27;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(23, 278);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(117, 13);
            this.label29.TabIndex = 29;
            this.label29.Text = "psiquiátricos anteriores:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(11, 265);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(129, 13);
            this.label30.TabIndex = 27;
            this.label30.Text = "Tratamientos psicológicos";
            // 
            // txtTratamientoPsicologico
            // 
            this.txtTratamientoPsicologico.Location = new System.Drawing.Point(142, 262);
            this.txtTratamientoPsicologico.Multiline = true;
            this.txtTratamientoPsicologico.Name = "txtTratamientoPsicologico";
            this.txtTratamientoPsicologico.Size = new System.Drawing.Size(728, 53);
            this.txtTratamientoPsicologico.TabIndex = 26;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(65, 219);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 13);
            this.label31.TabIndex = 26;
            this.label31.Text = " psicoactivas:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(17, 206);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(119, 13);
            this.label32.TabIndex = 24;
            this.label32.Text = "Consumo de sustancias";
            // 
            // txtConsumoSustancias
            // 
            this.txtConsumoSustancias.Location = new System.Drawing.Point(142, 203);
            this.txtConsumoSustancias.Multiline = true;
            this.txtConsumoSustancias.Name = "txtConsumoSustancias";
            this.txtConsumoSustancias.Size = new System.Drawing.Size(728, 53);
            this.txtConsumoSustancias.TabIndex = 25;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(57, 147);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(79, 13);
            this.label33.TabIndex = 22;
            this.label33.Text = "Medicamentos:";
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(142, 144);
            this.txtMedicamento.Multiline = true;
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(728, 53);
            this.txtMedicamento.TabIndex = 24;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(34, 88);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(102, 13);
            this.label37.TabIndex = 15;
            this.label37.Text = "Problemas de salud:";
            // 
            // txtProblemaSalud
            // 
            this.txtProblemaSalud.Location = new System.Drawing.Point(142, 85);
            this.txtProblemaSalud.Multiline = true;
            this.txtProblemaSalud.Name = "txtProblemaSalud";
            this.txtProblemaSalud.Size = new System.Drawing.Size(728, 53);
            this.txtProblemaSalud.TabIndex = 23;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(17, 55);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(147, 13);
            this.label38.TabIndex = 13;
            this.label38.Text = "Actividades en el tiempo libre:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbnSiDeporte);
            this.panel3.Controls.Add(this.rbnNoDeporte);
            this.panel3.Controls.Add(this.label36);
            this.panel3.Controls.Add(this.txtDeporte);
            this.panel3.Location = new System.Drawing.Point(14, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(856, 33);
            this.panel3.TabIndex = 52;
            // 
            // rbnSiDeporte
            // 
            this.rbnSiDeporte.AutoSize = true;
            this.rbnSiDeporte.Location = new System.Drawing.Point(167, 7);
            this.rbnSiDeporte.Name = "rbnSiDeporte";
            this.rbnSiDeporte.Size = new System.Drawing.Size(34, 17);
            this.rbnSiDeporte.TabIndex = 17;
            this.rbnSiDeporte.Text = "Si";
            this.rbnSiDeporte.UseVisualStyleBackColor = true;
            this.rbnSiDeporte.CheckedChanged += new System.EventHandler(this.rbnSiDeporte_CheckedChanged);
            // 
            // rbnNoDeporte
            // 
            this.rbnNoDeporte.AutoSize = true;
            this.rbnNoDeporte.Checked = true;
            this.rbnNoDeporte.Location = new System.Drawing.Point(207, 7);
            this.rbnNoDeporte.Name = "rbnNoDeporte";
            this.rbnNoDeporte.Size = new System.Drawing.Size(39, 17);
            this.rbnNoDeporte.TabIndex = 18;
            this.rbnNoDeporte.TabStop = true;
            this.rbnNoDeporte.Text = "No";
            this.rbnNoDeporte.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(9, 9);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(135, 13);
            this.label36.TabIndex = 50;
            this.label36.Text = "Deporte / Actividad Física:";
            // 
            // txtDeporte
            // 
            this.txtDeporte.Location = new System.Drawing.Point(252, 7);
            this.txtDeporte.MaxLength = 100;
            this.txtDeporte.Multiline = true;
            this.txtDeporte.Name = "txtDeporte";
            this.txtDeporte.Size = new System.Drawing.Size(587, 20);
            this.txtDeporte.TabIndex = 21;
            this.txtDeporte.Text = "Ninguno";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rbnSiActividad);
            this.panel5.Controls.Add(this.rbnNoAcitividad);
            this.panel5.Controls.Add(this.txtTiempoLibre);
            this.panel5.Location = new System.Drawing.Point(14, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(856, 33);
            this.panel5.TabIndex = 53;
            // 
            // rbnSiActividad
            // 
            this.rbnSiActividad.AutoSize = true;
            this.rbnSiActividad.Location = new System.Drawing.Point(167, 8);
            this.rbnSiActividad.Name = "rbnSiActividad";
            this.rbnSiActividad.Size = new System.Drawing.Size(34, 17);
            this.rbnSiActividad.TabIndex = 19;
            this.rbnSiActividad.Text = "Si";
            this.rbnSiActividad.UseVisualStyleBackColor = true;
            this.rbnSiActividad.CheckedChanged += new System.EventHandler(this.rbnSiActividad_CheckedChanged);
            // 
            // rbnNoAcitividad
            // 
            this.rbnNoAcitividad.AutoSize = true;
            this.rbnNoAcitividad.Checked = true;
            this.rbnNoAcitividad.Location = new System.Drawing.Point(207, 8);
            this.rbnNoAcitividad.Name = "rbnNoAcitividad";
            this.rbnNoAcitividad.Size = new System.Drawing.Size(39, 17);
            this.rbnNoAcitividad.TabIndex = 20;
            this.rbnNoAcitividad.TabStop = true;
            this.rbnNoAcitividad.Text = "No";
            this.rbnNoAcitividad.UseVisualStyleBackColor = true;
            // 
            // txtTiempoLibre
            // 
            this.txtTiempoLibre.Location = new System.Drawing.Point(252, 7);
            this.txtTiempoLibre.MaxLength = 100;
            this.txtTiempoLibre.Multiline = true;
            this.txtTiempoLibre.Name = "txtTiempoLibre";
            this.txtTiempoLibre.Size = new System.Drawing.Size(587, 20);
            this.txtTiempoLibre.TabIndex = 22;
            this.txtTiempoLibre.Text = "Ninguno";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 552);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "&Regresar";
            this.ttMensaje.SetToolTip(this.btnRegresar, "Regresa al Inicio del Programa");
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // erpMensaje
            // 
            this.erpMensaje.ContainerControl = this;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 583);
            this.ControlBox = false;
            this.Controls.Add(this.tbcPrincipal);
            this.Controls.Add(this.btnRegresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.tbcPrincipal.ResumeLayout(false);
            this.tbpHistoria.ResumeLayout(false);
            this.gbInformacionPaciente.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbpDatosPersonales.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbpHistoria;
        private System.Windows.Forms.GroupBox gbInformacionPaciente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TabPage tbpDatosPersonales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtTratamientoPsicologico;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtConsumoSustancias;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtProblemaSalud;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtTiempoLibre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ErrorProvider erpMensaje;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox cboTipoVinculacion;
        private System.Windows.Forms.ComboBox cboTipoSangre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtTelefonoFijo;
        private System.Windows.Forms.ComboBox cboEstrato;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.RadioButton rbnFemenino;
        private System.Windows.Forms.RadioButton rbnMasculino;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbnSiDeporte;
        private System.Windows.Forms.RadioButton rbnNoDeporte;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtDeporte;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbnSiActividad;
        private System.Windows.Forms.RadioButton rbnNoAcitividad;
    }
}