using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using System.IO;

namespace pruebaGmaps
{
    public partial class Form1 : Form
    {

        Principal principal;

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        double LatInicial = 4.570868;
        double LonInicial = -74.2973328;

        int genero = 0;
        int arma = 0;
        public Form1()
        {
            InitializeComponent();
            principal = new Principal();
            principal.addDepartamento();
            
        }

        private void GMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void cargarCapitales()
        {
            StreamReader leer = new StreamReader(Path.GetFullPath("Departamentos.txt"));
            String linea = leer.ReadLine();
            try
            {
                while (linea != null)
                {
                    String[] elementos;
                    elementos = linea.Split(',');

                    if (elementos != null && elementos.Length == 4)
                    {
                        Double Lat = double.Parse(elementos[2]);
                        Double Lng = double.Parse(elementos[3]);

                        Console.WriteLine(Lat.ToString() + "," + Lng.ToString() + "Capitales");

                        marker = new GMarkerGoogle(new PointLatLng(Lat, Lng), GMarkerGoogleType.red);
                        markerOverlay.Markers.Add(marker);

                    }
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Inicialización del mapa
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LonInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 7;
            gMapControl1.AutoScroll = true;


            //marcador
            markerOverlay = new GMapOverlay("Marcador");

            cargarCapitales();

            /**
            StreamReader leer = new StreamReader(Path.GetFullPath("Departamentos.txt"));
            String linea = leer.ReadLine();
            try
            {
                while (linea != null)
                {
                    String[] elementos;
                    elementos = linea.Split(',');

                    if (elementos != null && elementos.Length == 4)
                    {
                        Double Lat = double.Parse(elementos[2]);
                        Double Lng = double.Parse(elementos[3]);

                        marker = new GMarkerGoogle(new PointLatLng(Lat, Lng), GMarkerGoogleType.red);
                        markerOverlay.Markers.Add(marker);

                    }
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }

            //*/



            //marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LonInicial), GMarkerGoogleType.purple);
            markerOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación: \n Latitud:{0} \n Longitud:{1}", LatInicial, LonInicial);

            gMapControl1.Overlays.Add(markerOverlay);


        }

        private void GMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            marker.Position = new PointLatLng(lat, lng);

            marker.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", lat, lng);


        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RbtOpcion1_CheckedChanged(object sender, EventArgs e)
        {
            paneOpcion1.Visible = true;
            paneOpcion2.Visible = false;
            paneOpcion3.Visible = false;
        }

        private void RbtOpcion2_CheckedChanged(object sender, EventArgs e)
        {
            paneOpcion1.Visible = false;
            paneOpcion2.Visible = true;
            paneOpcion3.Visible = false;
        }

        private void RbtOpcion3_CheckedChanged(object sender, EventArgs e)
        {
            paneOpcion1.Visible = false;
            paneOpcion2.Visible = false;
            paneOpcion3.Visible = true;
        }

        private void PaneOpcion1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Btmostrar_Click(object sender, EventArgs e)
        {

        }

        private void BtMostrar3_Click(object sender, EventArgs e)
        {
            int totalArma1 = 0;
            int totalArma2 = 0;
            if(arma == 1)
            {
                totalArma1 = principal.armaBlancaT();
                lblMensajeTotal.Text = totalArma1.ToString();
            }
            else if(arma == 2)
            {
                totalArma2 = principal.armaFuegoT();
                lblMensajeTotal.Text = totalArma2.ToString();
            }
        }

        private void BtMostrar2_Click(object sender, EventArgs e)
        {
            int totalMujeres = 0;
            int totalHombres = 0;


            if (genero == 1)
            {
                MessageBox.Show("Hola, entré 1");
                totalMujeres = principal.MujeresT();
                lblMensajeTotal.Text = totalMujeres.ToString();
            }
            else if (genero == 2)
            {
                MessageBox.Show("Hola, entré 2");
                totalHombres = principal.HombresT();
                lblMensajeTotal.Text = totalHombres.ToString();
            }
        }

        private void BtMostrar1_Click(object sender, EventArgs e)
        {
            gMapControl1.SetPositionByKeywords("Medellín, Colombia");
            //no funciona jeje
        }

        private void RbtArma1_CheckedChanged(object sender, EventArgs e)
        {
            arma = 1;
        }

        private void RbtArma2_CheckedChanged(object sender, EventArgs e)
        {
            arma = 2;
        }

        private void RbtHombres_CheckedChanged(object sender, EventArgs e)
        {
            genero = 2;
        }

        private void RbtMujeres_CheckedChanged(object sender, EventArgs e)
        {
            genero = 1;
        }
    }
}
