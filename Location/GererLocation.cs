using controller;
using metiers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp2Bus
{
    public partial class GererLocation : Form
    {
        public GererLocation()
        {
            InitializeComponent();
        }
            private void GererLocation_Load(object sender, EventArgs e)
            {
                cmbBus.DataSource = BusController.GetBus().ToArray();
                cmbBus.DisplayMember = "Immat";
                dgvLocations.Rows.Clear();
            //dgvLocation.DataSource= BusController.GetBus().ToArray();
            foreach (Location l in LocController.GetLocations())
            {
                dgvLocations.Rows.Add(l.DateDebLoc,
                    l.ImmatBus.Immat, l.DateFinLoc, l.Montant
                    , l.Client);
            }
            //l immat mato4hrch 5trha bil data source yaraha object mouch string donc lezem rows 
        }   
        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            // DateTime debut = dtpDebut.Value.Date;
            // DateTime fin = dtpFin.Value.Date;
            DateTime debut = dtpDebut.Value;
            DateTime fin = dtpFin.Value;
            if (fin<debut )
            
                MessageBox.Show("date deb sup a date fin");
            
            if( debut < DateTime.Now)
                MessageBox.Show("date deb inferieur a now");

            Bus busSelectionne = (Bus)cmbBus.SelectedItem;
            Location l = new Location(debut, busSelectionne, fin,
                txtClient.Text);

            if (!LocController.AjouterLocation(l))
            {
                MessageBox.Show("Ce bus n'est pas disponible pour cette période.",
                    "Indisponible", MessageBoxButtons.OK);
            }
            else
            {
                // dgvLocation.DataSource = null;
                // dgvLocation.DataSource = LocController.GetLocations();
                dgvLocations.Rows.Add(l.DateDebLoc,
                   l.ImmatBus.Immat, l.DateFinLoc, l.Montant
                   , l.Client);
                MessageBox.Show($"Location ajoutée. Montant : {l.Montant:F2} DT", "Succès",
                    MessageBoxButtons.OK);
            }
        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            //normalment bool enregister !! 
            if (LocController.EnregistrerLocation())
            {
                MessageBox.Show("Locations enregistrées.", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                GererLocation_Load(sender, e);
            }
            else
            {
                MessageBox.Show("erreur");
            }
        }

        private void btnchercherBus_Click_1(object sender, EventArgs e)
        {
            Bus bus = (Bus)cmbBus.SelectedItem;
            dgvLocation.DataSource = null;
            // non lezem marque et mat dgvLocation.DataSource = LocController.ChercherParBuss(bus.Immat);
            dgvLocation.DataSource = LocController.ChercherParBuss(bus);
            //ou bil rows
            dgvLocations.Rows.Clear();
            foreach (Location l in LocController.ChercherParBus(bus))
            {
                dgvLocations.Rows.Add(l.DateDebLoc,
                    l.ImmatBus.Immat, l.DateFinLoc, l.Montant, l.Client);
            }
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            dgvLocation.DataSource = null;
            dgvLocation.DataSource = LocController.ChercherParJour(dtpRecherche.Value.Date);
        }

    }

    }
