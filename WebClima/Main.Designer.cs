namespace WebClima
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.lblZona = new System.Windows.Forms.Label();
            this.lblGrados = new System.Windows.Forms.Label();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.lblHum = new System.Windows.Forms.Label();
            this.picClima = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtReloj = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picClima)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(120, 32);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(37, 17);
            this.lblZona.TabIndex = 0;
            this.lblZona.Text = "zona";
            // 
            // lblGrados
            // 
            this.lblGrados.AutoSize = true;
            this.lblGrados.Location = new System.Drawing.Point(120, 62);
            this.lblGrados.Name = "lblGrados";
            this.lblGrados.Size = new System.Drawing.Size(50, 17);
            this.lblGrados.TabIndex = 1;
            this.lblGrados.Text = "grados";
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Location = new System.Drawing.Point(233, 22);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(58, 17);
            this.lblDetalles.TabIndex = 1;
            this.lblDetalles.Text = "Detalles";
            // 
            // lblHum
            // 
            this.lblHum.AutoSize = true;
            this.lblHum.Location = new System.Drawing.Point(120, 89);
            this.lblHum.Name = "lblHum";
            this.lblHum.Size = new System.Drawing.Size(66, 17);
            this.lblHum.TabIndex = 1;
            this.lblHum.Text = "humedad";
            // 
            // picClima
            // 
            this.picClima.Location = new System.Drawing.Point(33, 32);
            this.picClima.Name = "picClima";
            this.picClima.Size = new System.Drawing.Size(50, 50);
            this.picClima.TabIndex = 2;
            this.picClima.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(120, 117);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(76, 17);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "01/01/2000";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(120, 146);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(40, 17);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "00:00";
            // 
            // txtReloj
            // 
            this.txtReloj.Location = new System.Drawing.Point(12, 361);
            this.txtReloj.Name = "txtReloj";
            this.txtReloj.ReadOnly = true;
            this.txtReloj.Size = new System.Drawing.Size(185, 25);
            this.txtReloj.TabIndex = 3;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(12, 392);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(185, 25);
            this.txtRegion.TabIndex = 3;
            this.txtRegion.Text = "Argentina";
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(236, 62);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.ScriptErrorsSuppressed = true;
            this.browser.Size = new System.Drawing.Size(757, 487);
            this.browser.TabIndex = 4;
            this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(918, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 34);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(12, 423);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(97, 39);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1005, 580);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtReloj);
            this.Controls.Add(this.picClima);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHum);
            this.Controls.Add(this.lblGrados);
            this.Controls.Add(this.lblZona);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Clima";
            ((System.ComponentModel.ISupportInitialize)(this.picClima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.Label lblGrados;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label lblHum;
        private System.Windows.Forms.PictureBox picClima;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtReloj;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Timer timer;
    }
}

