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
        GMapOverlay gmapDepartment;

        double LatInicial = 4.570868;
        double LonInicial = -74.2973328;

        int genero = 0;
        int arma = 0;
        public Form1()
        {
            InitializeComponent();
            principal = new Principal();
            principal.addDepartamento();
            principal.latLonDepartments();
        }

        private void GMapControl1_Load(object sender, EventArgs e)
        {
            map.SetPositionByKeywords("Bogotá,Colombia");
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

        }


        private void mostrarDepartamentos()
        {
            MessageBox.Show("Holaaaa, pude entrar al método de mostrar departamentos");
            foreach (var aux in principal.Departments)
            {
                
                gmapDepartment = new GMapOverlay("marker");
                GMarkerGoogle mark = new GMarkerGoogle(new GMap.NET.PointLatLng(aux.Latitud, aux.Longitud), GMarkerGoogleType.yellow_small);
                gmapDepartment.Markers.Add(mark);

                mark.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                mark.ToolTipText = String.Format("Departamento: " + aux.NameD + "\n" + "Capital: " + aux.Capital + "\n" + "Latitud: " + aux.Latitud + "\n" + "Longitud: " + aux.Longitud);
                mark.ToolTip.TextPadding = new Size(10, 10);

                map.Overlays.Add(gmapDepartment);
            }
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
            map.DragButton = MouseButtons.Left;
            map.CanDragMap = true;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(LatInicial, LonInicial);
            map.MinZoom = 0;
            map.MaxZoom = 24;
            map.Zoom = 7;
            map.AutoScroll = true;


            //marcador
            markerOverlay = new GMapOverlay("Marcador");

            //cargarCapitales();

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

            map.Overlays.Add(markerOverlay);


        }

        private void GMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = map.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = map.FromLocalToLatLng(e.X, e.Y).Lng;

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
                lblMensajeTotal.Text = "Total asesinados por arma blanca: \n" + totalArma1.ToString();
            }
            else if(arma == 2)
            {
                totalArma2 = principal.armaFuegoT();
                lblMensajeTotal.Text = "Total asesinados por arma de fuego: \n" + totalArma2.ToString();
            }
        }

        private void BtMostrar2_Click(object sender, EventArgs e)
        {
            int totalMujeres = 0;
            int totalHombres = 0;

            
            if (genero == 1)
            {
                totalMujeres = principal.MujeresT();
                lblMensajeTotal.Text = "Total mujeres asesinadas: \n"+totalMujeres.ToString();
            }
            else if (genero == 2)
            {
                totalHombres = principal.HombresT();
                lblMensajeTotal.Text = "Total hombres asesinados: \n" + totalHombres.ToString();
            }
        }

        private void BtMostrar1_Click(object sender, EventArgs e)
        {
            map.SetPositionByKeywords("Medellín, Colombia");
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

        private void Button1_Click(object sender, EventArgs e)
        {
            mostrarDepartamentos();
        }
    }
}
