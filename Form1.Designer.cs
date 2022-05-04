
namespace reproductor
{
    partial class  Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_cargar = new System.Windows.Forms.Button();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnpausa = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPlay = new System.Windows.Forms.Button();
            this.trackbarVolumen = new System.Windows.Forms.TrackBar();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.trackbarDuracion = new System.Windows.Forms.TrackBar();
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(0, 426);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(75, 23);
            this.btn_cargar.TabIndex = 0;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // btnReproducir
            // 
            this.btnReproducir.Location = new System.Drawing.Point(81, 426);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(75, 23);
            this.btnReproducir.TabIndex = 1;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.UseVisualStyleBackColor = true;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(161, 426);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnpausa
            // 
            this.btnpausa.Location = new System.Drawing.Point(242, 426);
            this.btnpausa.Name = "btnpausa";
            this.btnpausa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnpausa.Size = new System.Drawing.Size(75, 23);
            this.btnpausa.TabIndex = 3;
            this.btnpausa.Text = "pausa";
            this.btnpausa.UseVisualStyleBackColor = true;
            this.btnpausa.Click += new System.EventHandler(this.btnpausa_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(423, 436);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(0, 13);
            this.lblRuta.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(342, 426);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // trackbarVolumen
            // 
            this.trackbarVolumen.Location = new System.Drawing.Point(711, 379);
            this.trackbarVolumen.Maximum = 100;
            this.trackbarVolumen.Name = "trackbarVolumen";
            this.trackbarVolumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackbarVolumen.Size = new System.Drawing.Size(45, 70);
            this.trackbarVolumen.TabIndex = 7;
            this.trackbarVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarVolumen.Scroll += new System.EventHandler(this.trackbarVolumen_Scroll);
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(732, 428);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(13, 13);
            this.lblVolumen.TabIndex = 8;
            this.lblVolumen.Text = "0";
            // 
            // trackbarDuracion
            // 
            this.trackbarDuracion.Location = new System.Drawing.Point(0, 375);
            this.trackbarDuracion.Maximum = 100;
            this.trackbarDuracion.Name = "trackbarDuracion";
            this.trackbarDuracion.Size = new System.Drawing.Size(623, 45);
            this.trackbarDuracion.TabIndex = 9;
            this.trackbarDuracion.TickFrequency = 20;
            this.trackbarDuracion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarDuracion.Scroll += new System.EventHandler(this.trackbarDuracion_Scroll);
            // 
            // Media
            // 
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(0, -2);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(799, 375);
            this.Media.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 518);
            this.Controls.Add(this.trackbarDuracion);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.trackbarVolumen);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnpausa);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.btn_cargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackbarVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnpausa;
        private System.Windows.Forms.Label lblRuta;
        private AxWMPLib.AxWindowsMediaPlayer Media;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TrackBar trackbarVolumen;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.TrackBar trackbarDuracion;
    }
}

