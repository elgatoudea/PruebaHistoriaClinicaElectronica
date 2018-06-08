namespace HistoriaClinicaElectronica.Interfaz
{
    partial class Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbInicio = new System.Windows.Forms.PictureBox();
            this.ptbAdelante = new System.Windows.Forms.PictureBox();
            this.ptbAtras = new System.Windows.Forms.PictureBox();
            this.wbrAgenda = new System.Windows.Forms.WebBrowser();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdelante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ptbInicio);
            this.panel1.Controls.Add(this.ptbAdelante);
            this.panel1.Controls.Add(this.ptbAtras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 30);
            this.panel1.TabIndex = 0;
            // 
            // ptbInicio
            // 
            this.ptbInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbInicio.Image = global::HistoriaClinicaElectronica.Properties.Resources.Home;
            this.ptbInicio.Location = new System.Drawing.Point(6, 3);
            this.ptbInicio.Name = "ptbInicio";
            this.ptbInicio.Size = new System.Drawing.Size(21, 24);
            this.ptbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbInicio.TabIndex = 2;
            this.ptbInicio.TabStop = false;
            this.toolTip1.SetToolTip(this.ptbInicio, "Inicio");
            this.ptbInicio.Click += new System.EventHandler(this.ptbInicio_Click);
            // 
            // ptbAdelante
            // 
            this.ptbAdelante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAdelante.Image = global::HistoriaClinicaElectronica.Properties.Resources.Adelante;
            this.ptbAdelante.Location = new System.Drawing.Point(65, 3);
            this.ptbAdelante.Name = "ptbAdelante";
            this.ptbAdelante.Size = new System.Drawing.Size(21, 24);
            this.ptbAdelante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAdelante.TabIndex = 1;
            this.ptbAdelante.TabStop = false;
            this.toolTip1.SetToolTip(this.ptbAdelante, "Adelante");
            this.ptbAdelante.Click += new System.EventHandler(this.ptbAdelante_Click);
            // 
            // ptbAtras
            // 
            this.ptbAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAtras.Image = global::HistoriaClinicaElectronica.Properties.Resources.Atras;
            this.ptbAtras.Location = new System.Drawing.Point(38, 3);
            this.ptbAtras.Name = "ptbAtras";
            this.ptbAtras.Size = new System.Drawing.Size(21, 24);
            this.ptbAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAtras.TabIndex = 0;
            this.ptbAtras.TabStop = false;
            this.toolTip1.SetToolTip(this.ptbAtras, "Atras");
            this.ptbAtras.Click += new System.EventHandler(this.ptbAtras_Click);
            // 
            // wbrAgenda
            // 
            this.wbrAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbrAgenda.Location = new System.Drawing.Point(0, 30);
            this.wbrAgenda.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrAgenda.Name = "wbrAgenda";
            this.wbrAgenda.Size = new System.Drawing.Size(866, 402);
            this.wbrAgenda.TabIndex = 1;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 432);
            this.Controls.Add(this.wbrAgenda);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Agenda_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdelante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbAtras;
        private System.Windows.Forms.PictureBox ptbAdelante;
        private System.Windows.Forms.WebBrowser wbrAgenda;
        private System.Windows.Forms.PictureBox ptbInicio;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}