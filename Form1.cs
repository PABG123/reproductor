using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reproductor
{
    public partial class Form1 : Form
    {
        private string ruta = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lblRuta.Text = ruta;
            }
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            Media.URL = ruta;
            Media.Ctlcontrols.play();

        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            Media.Ctlcontrols.stop();
            

        }

        private void btnpausa_Click(object sender, EventArgs e)
        {
            Media.Ctlcontrols.pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Media.Ctlcontrols.play();

        }

      

        private void trackbarVolumen_Scroll(object sender, EventArgs e)
        {
            Media.settings.volume = trackbarVolumen.Value;
            lblVolumen.Text = Media.settings.volume.ToString();

        }

        private void trackbarDuracion_Scroll(object sender, EventArgs e)
        {
            trackbarDuracion.Maximum = (int)Media.currentMedia.duration;
            if (trackbarDuracion.Value==(int)Media.Ctlcontrols.currentPosition)
            {

            }
            else
            {
                Media.Ctlcontrols.currentPosition = trackbarDuracion.Value;

            }

        }


    }

}
