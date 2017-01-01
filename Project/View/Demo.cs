using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droid_logistique
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void buttonArrivals_Click(object sender, EventArgs e)
        {
            panelDeparture1.TextHtml = InterfaceLogistique.ACTION_131_afficher_arrive(textBoxArrivals.Text);
            //panelDeparture1.Station = textBoxArrivals.Text;
        }
        private void buttonDepartures_Click(object sender, EventArgs e)
        {
            panelDeparture1.TextHtml = InterfaceLogistique.ACTION_130_afficher_departs(textBoxDepartures.Text);
            //panelDeparture1.Station = textBoxDepartures.Text;
        }
        private void buttonStations_Click(object sender, EventArgs e)
        {
            panelDeparture1.TextHtml = InterfaceLogistique.ACTION_132_decrire_gare(textBoxStations.Text);
        }
        private void buttonDepartureDate_Click(object sender, EventArgs e)
        {
            panelDeparture1.TextHtml = InterfaceLogistique.ACTION_133_partir_train(textBoxFrom.Text, textBoxTo.Text, timePicker.Value);
        }
        private void buttonArrivalDate_Click(object sender, EventArgs e)
        {
            panelDeparture1.TextHtml = InterfaceLogistique.ACTION_134_arrive_train(textBoxFrom.Text, textBoxTo.Text, timePicker.Value);
        }
    }
}
