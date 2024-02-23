using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebClima
{
    // Se requiere el uso de un timer
    public partial class Main : Form
    {
        int contSegundos = 0;
        int dias = 0;
        public Main()
        {
            InitializeComponent();
            // Inicia la navegación y la carga inicial de datos

            // Muestra la hora actual en el formulario
            txtReloj.Text = DateTime.Now.ToString("HH : mm : ss");
        }

        // Carga la página con los datos del clima buscados en Google en WebBrowser.Document
        void Navergar()
        {
            // Construye la URL utilizando la región y la fecha actual
            string fecha = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
            string url = "https://www.google.com/search?q=clima+" + txtRegion.Text + "+" + fecha + "&sxsrf=ALeKk011EDbPNb1s4xkQe-x3u2EhlfQPbg%";
            browser.Navigate(url);
        }

        // Evento que se ejecuta cuando la página se carga completamente
        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Procesa los datos climáticos una vez que la página está completamente cargada
            Weather();
        }

        // Carga los datos obtenidos en el WebBrowser.Document
        public void Weather()
        {
            if (browser.Document != null)
            {
                try
                {
                    //// Obtiene datos climáticos específicos de la página y los muestra en el formulario
                    lblZona.Text = browser.Document.GetElementById("wob_loc").InnerText;
                    lblGrados.Text = browser.Document.GetElementById("wob_tm").InnerText;
                    picClima.ImageLocation = browser.Document.GetElementById("wob_tci").GetAttribute("src");
                    lblDetalles.Text = browser.Document.GetElementById("wob_dc").InnerText;
                    lblHum.Text = browser.Document.GetElementById("wob_hm").InnerText;
                    lblFecha.Text = DateTime.Now.ToLongDateString();
                    lblHora.Text = "última actualización a las " + DateTime.Now.ToShortTimeString() + " hs.";
                }
                catch (Exception er)
                {
                    // Maneja cualquier error durante la obtención de datos
                    Console.WriteLine("Error! " + er.Message);
                    // Muestra mensajes de datos no disponibles
                    lblZona.Text = "NO SE PUDO TRAER LOS DATOS.";
                    picClima = new PictureBox();
                    lblGrados.Text = "S/D";
                    lblDetalles.Text = "S/D";
                    lblHum.Text = "S/D";
                    lblFecha.Text = DateTime.Now.ToLongDateString();
                }
            }
            else
            {
                // Muestra mensajes de datos no disponibles si el documento es nulo
                lblZona.Text = "NO SE PUDO TRAER LOS DATOS.";
                lblGrados.Text = "S/D";
                lblDetalles.Text = "S/D";
                lblHum.Text = "S/D";
                lblFecha.Text = DateTime.Now.ToLongDateString();
            }
        }

        // Método similar a Weather, pero para traer datos de días posteriores
        //void TraerClimasPost(DateTime d)
        //{
        //    string fecha = d.Day + "-" + d.Month + "-" + d.Year;
        //    string url = "https://www.google.com/search?q=clima+" + txtRegion.Text + "+" + fecha + "&sxsrf=ALeKk011EDbPNb1s4xkQe-x3u2EhlfQPbg%";
        //    browserPost.Navigate(url);
        //}

        //// Evento DocumentCompleted para el segundo navegador
        //private void browserPost_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        //{
        //    TraerClimas();
        //}

        // Método para obtener datos climáticos de días posteriores
        //void TraerClimas()
        //{
        //    if (dias <= 7)
        //    {
        //        DateTime d = DateTime.Today.AddDays(dias);

        //        try
        //        {
        //            // Utiliza un switch para asignar datos climáticos según el día
        //            switch (dias)
        //            {
        //                case 1:
        //                    lblClima1.Text = browserPost.Document.GetElementById("wob_tm").InnerText;
        //                    pbClima1.ImageLocation = browserPost.Document.GetElementById("wob_tci").GetAttribute("src");
        //                    lblHum1.Text = browserPost.Document.GetElementById("wob_hm").InnerText;
        //                    lblClimaF1.Text = d.ToString("dddd d");
        //                    break;
        //                // Repite el patrón para los siguientes días
        //                // ...
        //                case 7:
        //                    lblClima7.Text = browserPost.Document.GetElementById("wob_tm").InnerText;
        //                    pbClima7.ImageLocation = browserPost.Document.GetElementById("wob_tci").GetAttribute("src");
        //                    lblHum7.Text = browserPost.Document.GetElementById("wob_hm").InnerText;
        //                    lblClimaF7.Text = d.ToString("dddd d");
        //                    break;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            // Maneja cualquier error durante la obtención de datos para días posteriores
        //            Console.WriteLine("Error! : " + ex.Message);
        //            // Muestra mensajes de datos no disponibles
        //            lblClima1.Text = "S/D";
        //            pbClima1 = new PictureBox();
        //            lblHum1.Text = "S/D"; ;
        //            lblClimaF1.Text = "S/D"; ;

        //            // Repite el patrón para los siguientes días
        //            // ...

        //            lblClima7.Text = "S/D";
        //            pbClima7 = new PictureBox();
        //            lblHum7.Text = "S/D"; ;
        //            lblClimaF7.Text = "S/D"; ;
        //        }

        //        dias++;
        //        TraerClimasPost(d);
        //    }
        //}

        // Actualiza los datos automáticamente desde un timer
        private void timer_Tick(object sender, EventArgs e)
        {
            contSegundos++;
            if (contSegundos >= 600) // 10 minutos
            {
                contSegundos = 0;
                Navergar();
                dias = 0;
                //TraerClimasPost(DateTime.Today);
            }
        }

        // Actualiza los datos manualmente desde un botón
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Navergar();
            dias = 0;
            //TraerClimasPost(DateTime.Today);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }

}
