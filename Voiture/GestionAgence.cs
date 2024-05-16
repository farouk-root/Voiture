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
    public partial class GestionAgence : Form
    {
        AgenceController agenceC = new AgenceController();
        int selectedAgence = 0;
        public GestionAgence()
        {
            InitializeComponent();
        }

        private void GestionAgence_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vOITUREDataSet.AGENCE' table. You can move, or remove it, as needed.
            this.aGENCETableAdapter.Fill(this.vOITUREDataSet.AGENCE);

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nom_agence.Text) ||
                string.IsNullOrWhiteSpace(txt_localisation.Text) ||
                string.IsNullOrWhiteSpace(txt_telephone.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            AgenceModel agence = new AgenceModel
            {
                NOM_AGENCE = txt_nom_agence.Text,
                ADRESSE = txt_localisation.Text,
                NUM_TEL = txt_telephone.Text,
                EMAIL = txt_email.Text
            };

            try
            {
                agenceC.AddAgence(agence);
                MessageBox.Show("Agency added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.aGENCETableAdapter.Fill(this.vOITUREDataSet.AGENCE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add agency: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            int id = agenceC.GetLatestAgenceId();
            txt_ID.Text = "AG-" + Convert.ToString(id + 1);
            txt_nom_agence.Text = "";
            txt_localisation.Text = "";
            txt_telephone.Text = "";
            txt_email.Text = "";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedAgence = Convert.ToInt16(row.Cells[0].Value);
                txt_nom_agence.Text = row.Cells[1].Value.ToString();
                txt_localisation.Text = row.Cells[2].Value.ToString();
                txt_telephone.Text = row.Cells[3].Value.ToString();
                txt_email.Text  = row.Cells[4].Value.ToString();
                txt_ID.Text = "AG-" + selectedAgence;
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (selectedAgence <= 0)
            {
                MessageBox.Show("Please select an agency to modify.", "No Agency Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_nom_agence.Text) ||
                string.IsNullOrWhiteSpace(txt_localisation.Text) ||
                string.IsNullOrWhiteSpace(txt_telephone.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AgenceModel updatedAgence = new AgenceModel
            {
                NOM_AGENCE = txt_nom_agence.Text,
                ADRESSE = txt_localisation.Text,
                NUM_TEL = txt_telephone.Text,
                EMAIL = txt_email.Text
            };
            try
            {
                bool success = agenceC.UpdateAgence(updatedAgence, selectedAgence);
                if (success)
                {
                    MessageBox.Show("Agency updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.aGENCETableAdapter.Fill(this.vOITUREDataSet.AGENCE);
                }
                else
                {
                    MessageBox.Show("Failed to update agency. Please check the details.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (selectedAgence <= 0)
            {
                MessageBox.Show("Please select an agency to delete.", "No Agency Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this agency?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    bool deleted = agenceC.DeleteAgence(selectedAgence);
                    if (deleted)
                    {
                        MessageBox.Show("Agency deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.aGENCETableAdapter.Fill(this.vOITUREDataSet.AGENCE);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete agency. Maybe the agency doesn't exist.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Debut_Click(object sender, EventArgs e)
        {
            this.aGENCEBindingSource.MoveFirst();
            var currentRow = this.aGENCEBindingSource.Current as DataRowView;
            selectedAgence = Convert.ToInt16(currentRow["ID_AGENCE"]);
            txt_ID.Text = "AG-" + currentRow["ID_AGENCE"].ToString();
            txt_nom_agence.Text = currentRow["NOM_AGENCE"].ToString();
            txt_localisation.Text = currentRow["ADRESSE"].ToString();
            txt_telephone.Text = currentRow["NUM_TEL"].ToString();
            txt_email.Text = currentRow["EMAIL"].ToString();
        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            this.aGENCEBindingSource.MoveNext();
            var currentRow = this.aGENCEBindingSource.Current as DataRowView;
            selectedAgence = Convert.ToInt16(currentRow["ID_AGENCE"]);
            txt_ID.Text = "AG-" + currentRow["ID_AGENCE"].ToString();
            txt_nom_agence.Text = currentRow["NOM_AGENCE"].ToString();
            txt_localisation.Text = currentRow["ADRESSE"].ToString();
            txt_telephone.Text = currentRow["NUM_TEL"].ToString();
            txt_email.Text = currentRow["EMAIL"].ToString();
        }

        private void Precedant_Click(object sender, EventArgs e)
        {
            this.aGENCEBindingSource.MovePrevious();
            var currentRow = this.aGENCEBindingSource.Current as DataRowView;
            selectedAgence = Convert.ToInt16(currentRow["ID_AGENCE"]);
            txt_ID.Text = "AG-" + currentRow["ID_AGENCE"].ToString();
            txt_nom_agence.Text = currentRow["NOM_AGENCE"].ToString();
            txt_localisation.Text = currentRow["ADRESSE"].ToString();
            txt_telephone.Text = currentRow["NUM_TEL"].ToString();
            txt_email.Text = currentRow["EMAIL"].ToString();
        }

        private void Dernier_Click(object sender, EventArgs e)
        {
            this.aGENCEBindingSource.MoveLast();
            var currentRow = this.aGENCEBindingSource.Current as DataRowView;
            selectedAgence = Convert.ToInt16(currentRow["ID_AGENCE"]);
            txt_ID.Text = "AG-" + currentRow["ID_AGENCE"].ToString();
            txt_nom_agence.Text = currentRow["NOM_AGENCE"].ToString();
            txt_localisation.Text = currentRow["ADRESSE"].ToString();
            txt_telephone.Text = currentRow["NUM_TEL"].ToString();
            txt_email.Text = currentRow["EMAIL"].ToString();
        }

        

    }
}
