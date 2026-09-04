using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controller;
using metiers;

namespace Tp2Bus
{
    public partial class GererBus : Form
    {
        public GererBus()
        {
            InitializeComponent();
        }

        private void GererBus_Load(object sender, EventArgs e)
        {
            dgvBus.DataSource = null;
            dgvBus.DataSource = BusController.GetBus().ToArray();
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            if (txtCapacite.Text != "")
            {
                dgvBus.DataSource = BusController.chercherCap(Convert.ToInt32(txtCapacite.Text)).ToArray();
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Validation : bus âgé de plus de 5 ans → prix d'achat max 50 000
            DateTime dateAchat = dtpachat.Value;
            double prixAchat = Convert.ToDouble(txtPrixAchat.Text);
            int age = (DateTime.Today - dateAchat).Days / 365;

            if (age >= 5 && prixAchat > 50000)
            {
                MessageBox.Show("Un bus âgé de 5 ans ou plus ne peut pas avoir un prix d'achat supérieur à 50 000.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bus b = new Bus(
                txtImmat.Text,
                txtMarque.Text,
                dateAchat,
                Convert.ToInt32(txtCapacite.Text),
                prixAchat,
                Convert.ToDouble(txtPrixJour.Text)
            );

            if (!BusController.AjouterBus(b))
            {
                MessageBox.Show("Un bus avec cette immatriculation existe déjà.",
                    "Doublon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("done");
                viderchamp();
           }

 
            dgvBus.DataSource = BusController.GetBus().ToArray();
            MessageBox.Show("Bus ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void viderchamp()
        {
            txtCapacite.Text = "";
            dtpachat.Value = DateTime.Now;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show("enregistrer???", "ATT", MessageBoxButtons.YesNo);
            if (choix == DialogResult.Yes)
            {
                BusController.enregister();
                MessageBox.Show("Modifications enregistrées dans la base.", "Succès",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                //zeyd e5ir msg
            }
           
        }
    }

}
