using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Voiture.Models;
using Voiture.Controllers;

namespace Voiture
{
    public partial class Form1 : Form
    {
        VoitureController voitureController = new VoitureController();
        private int selectedMatricule = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vOITUREDataSet.AGENCE' table. You can move, or remove it, as needed.
            this.aGENCETableAdapter.Fill(this.vOITUREDataSet.AGENCE);
            // TODO: This line of code loads data into the 'vOITUREDataSet.VOITURE' table. You can move, or remove it, as needed.
            this.vOITURETableAdapter.Fill(this.vOITUREDataSet.VOITURE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = voitureController.GetLatestVoitureId();
            txt_ID.Text = "V-" + Convert.ToString(id +1)  ;
            txt_couleur.Text = "";
            txt_annee.Text = "";
            txt_modele.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_couleur.Text) || string.IsNullOrWhiteSpace(txt_modele.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add a new car?", "Confirm Addition", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    VoitureModel v = new VoitureModel(Convert.ToInt16(comboBox_agence.SelectedValue), txt_couleur.Text, txt_modele.Text, new DateTime(2025, 06, 01));
                    voitureController.AddVoiture(v);
                    this.vOITURETableAdapter.Fill(this.vOITUREDataSet.VOITURE);

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
            VoitureModel updatedCar = new VoitureModel
            {
                ID_AGENCE = Convert.ToInt16(comboBox_agence.SelectedValue),
                Couleur = txt_couleur.Text,
                Modele = txt_modele.Text,
                Annee = new DateTime(2025, 06, 01)
            };
            int matriculeToUpdate = selectedMatricule; 
            bool success = false;
            if ( selectedMatricule > 0 )
                 success = voitureController.UpdateVoiture(updatedCar, matriculeToUpdate);
            if (success)
            {
                MessageBox.Show("Car updated successfully!");
                this.vOITURETableAdapter.Fill(this.vOITUREDataSet.VOITURE);
            }
            else
                MessageBox.Show("Update failed. Please check the details.");
        }



        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedMatricule = Convert.ToInt16(row.Cells[0].Value);
                comboBox_agence.SelectedValue = row.Cells[1].Value;
                txt_couleur.Text = row.Cells[2].Value.ToString();
                txt_modele.Text = row.Cells[3].Value.ToString();
                txt_annee.Text = row.Cells[4].Value.ToString();
                txt_ID.Text = "V-" + selectedMatricule;
            }
        }

        private void Debut_Click(object sender, EventArgs e)
        {
            this.vOITUREBindingSource.MoveFirst();
            var currentRow = this.vOITUREBindingSource.Current as DataRowView;
            selectedMatricule = Convert.ToInt16(currentRow["MATRICULE"]);
            Console.WriteLine(selectedMatricule);
            txt_ID.Text = "V-" + currentRow["MATRICULE"].ToString();
            txt_couleur.Text = currentRow["COULEUR"].ToString();
            txt_modele.Text = currentRow["MODELE"].ToString();

        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            this.vOITUREBindingSource.MoveNext();
            var currentRow = this.vOITUREBindingSource.Current as DataRowView;
            selectedMatricule = Convert.ToInt16(currentRow["MATRICULE"]);
            txt_ID.Text = "V-" + currentRow["MATRICULE"].ToString();
            txt_couleur.Text = currentRow["COULEUR"].ToString();
            txt_modele.Text = currentRow["MODELE"].ToString();
        }

        private void Precedant_Click(object sender, EventArgs e)
        {
            this.vOITUREBindingSource.MovePrevious();
            var currentRow = this.vOITUREBindingSource.Current as DataRowView;
            selectedMatricule = Convert.ToInt16(currentRow["MATRICULE"]);
            txt_ID.Text = "V-" + currentRow["MATRICULE"].ToString();
            txt_couleur.Text = currentRow["COULEUR"].ToString();
            txt_modele.Text = currentRow["MODELE"].ToString();
        }

        private void Dernier_Click(object sender, EventArgs e)
        {
            this.vOITUREBindingSource.MoveLast();
            var currentRow = this.vOITUREBindingSource.Current as DataRowView;
            selectedMatricule = Convert.ToInt16(currentRow["MATRICULE"]);
            txt_ID.Text = "V-" + currentRow["MATRICULE"].ToString();
            txt_couleur.Text = currentRow["COULEUR"].ToString();
            txt_modele.Text = currentRow["MODELE"].ToString();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (selectedMatricule > 0)
            {
                VoitureController controller = new VoitureController();
                bool deleted = controller.DeleteVoiture(selectedMatricule);

                if (deleted)
                {
                    MessageBox.Show("Voiture deleted successfully.");
                    this.vOITURETableAdapter.Fill(this.vOITUREDataSet.VOITURE);
                }
                else
                {
                    MessageBox.Show("Failed to delete voiture. Maybe the MATRICULE doesn't exist.");
                }
            }
        }



    }
}
