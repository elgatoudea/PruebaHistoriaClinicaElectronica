namespace HistoriaClinicaElectronica
{
    partial class InicioSesion
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(75, 139);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuario.Size = new System.Drawing.Size(262, 20);
            this.txtUsuario.TabIndex = 0;
            this.ttMensaje.SetToolTip(this.txtUsuario, "Ingrese el Usuario");
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(75, 222);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(262, 20);
            this.txtContraseña.TabIndex = 1;
            this.ttMensaje.SetToolTip(this.txtContraseña, "Ingrese la Contraseña");
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInicio.Image = global::HistoriaClinicaElectronica.Properties.Resources.Inicio1;
            this.btnInicio.Location = new System.Drawing.Point(88, 345);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(209, 54);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Iniciar";
            this.ttMensaje.SetToolTip(this.btnInicio, "Iniciar Sesión");
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "?";
            this.ttMensaje.SetToolTip(this.label1, "Aceptar para Ingresar\r\nEscape para Salir");
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalir.Location = new System.Drawing.Point(386, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(17, 22);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "x";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // InicioSesion
            // 
            this.AcceptButton = this.btnInicio;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HistoriaClinicaElectronica.Properties.Resources.Inicio4;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(383, 435);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InicioSesion_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
    }
}