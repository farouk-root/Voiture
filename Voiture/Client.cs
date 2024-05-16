using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Voiture.Controllers;
using Voiture.Models;

namespace Voiture
{
    public partial class Client : Form
    {
        ClientController clientControl = new ClientController();
        int selectedClient = 0;
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vOITUREDataSet.AGENCE' table. You can move, or remove it, as needed.
            this.aGENCETableAdapter.Fill(this.vOITUREDataSet.AGENCE);
            // TODO: This line of code loads data into the 'vOITUREDataSet.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.vOITUREDataSet.CLIENT);

        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            int id = clientControl.GetLatestClientId();
            id++;
            txt_CIN.Text = "TN-11566500" + id.ToString();
            txt_Nom.Text = "";
            txt_prenom.Text = "";
            txt_tel.Text = "";
            
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nom.Text) || string.IsNullOrWhiteSpace(txt_prenom.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add a new car?", "Confirm Addition", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    ClientModel client = new ClientModel(Convert.ToUInt16(comboBox1.SelectedValue),txt_Nom.Text,txt_prenom.Text,date_naissance.Value,txt_tel.Text);
                    clientControl.AddClient(client);
                    this.cLIENTTableAdapter.Fill(this.vOITUREDataSet.CLIENT);

                    MessageBox.Show("New car added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Operation cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            ClientModel updatedClient = new ClientModel
            {
                ID_AGENCE = Convert.ToUInt16(comboBox1.SelectedValue),
                NOM = txt_Nom.Text,
                PRENOM = txt_prenom.Text,
                DATE_DE_NAISSANCE = date_naissance.Value,
                TELEPHONE = txt_tel.Text
            };
            int clientToUpdate = selectedClient;
            bool success = false;
            if (selectedClient > 0)
                success = clientControl.UpdateClient(updatedClient, clientToUpdate);
            if (success)
            {
                MessageBox.Show("Client updated successfully!");
                this.cLIENTTableAdapter.Fill(this.vOITUREDataSet.CLIENT);
            }
            else
                MessageBox.Show("Update failed. Please check the details.");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedClient = Convert.ToInt16(row.Cells[0].Value);
                comboBox1.SelectedValue = row.Cells[1].Value;
                txt_Nom.Text = row.Cells[2].Value.ToString();
                txt_prenom.Text = row.Cells[3].Value.ToString();
                date_naissance.Text = row.Cells[4].Value.ToString();
                txt_tel.Text = row.Cells[5].Value.ToString();
                txt_CIN.Text = "TN-11566500" + selectedClient.ToString();
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (selectedClient > 0)
            {
                VoitureController controller = new VoitureController();
                bool deleted = clientControl.DeleteClient(selectedClient);

                if (deleted)
                {
                    MessageBox.Show("Voiture deleted successfully.");
                    this.cLIENTTableAdapter.Fill(this.vOITUREDataSet.CLIENT);
                }
                else
                {
                    MessageBox.Show("Failed to delete voiture. Maybe the MATRICULE doesn't exist.");
                }
            }
        }
        private void Load_Data()
        {
            var currentRow = this.cLIENTBindingSource.Current as DataRowView;
            selectedClient = Convert.ToInt16(currentRow["CIN"]);
            txt_CIN.Text = "TN-1156650" + currentRow["CIN"].ToString();
            txt_Nom.Text = currentRow["NOM"].ToString();
            txt_Nom.Text = currentRow["PRENOM"].ToString();
            txt_prenom.Text = currentRow["PRENOM"].ToString();
            txt_tel.Text = currentRow["TELEPHONE"].ToString();
            date_naissance.Text = currentRow["DATE_DE_NAISSANCE"].ToString();
        }

        private void Debut_Click(object sender, EventArgs e)
        {
            this.cLIENTBindingSource.MoveFirst();
            Load_Data();
        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            this.cLIENTBindingSource.MoveNext();
            Load_Data();
        }

        private void Precedant_Click(object sender, EventArgs e)
        {
            this.cLIENTBindingSource.MovePrevious();
            Load_Data();
        }

        private void Dernier_Click(object sender, EventArgs e)
        {
            this.cLIENTBindingSource.MoveLast();
            Load_Data();
        }



    }
}
