using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Voiture
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void GestionAgenceView_Click(object sender, EventArgs e)
        {
            GestionAgence gestionAgenceForm = new GestionAgence();
            gestionAgenceForm.Show();
        }

        private void GestionVoitureView_Click(object sender, EventArgs e)
        {
            Form1 GestionVoiture = new Form1();
            GestionVoiture.Show();
        }

        private void GestionClientView_Click(object sender, EventArgs e)
        {
            Client GestionClient = new Client();
            GestionClient.Show();
        }

        private void GestionLocationView_Click(object sender, EventArgs e)
        {
            Location GestionLocalisation = new Location();
            GestionLocalisation.Show();
        }
    }
}
