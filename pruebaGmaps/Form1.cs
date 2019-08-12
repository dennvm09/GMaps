using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace pruebaGmaps
{
    public partial class Form1 : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        double LatInicial = 4.570868;
        double LonInicial = -74.2973328;
        public Form1()
        {
            InitializeComponent();
        }

        private void GMapControl1_Load(object sender, EventArgs e)
        {

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
    }
}
