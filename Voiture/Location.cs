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
    public partial class Location : Form
    {
        LocationController locationController = new LocationController();
        int selectedLocation = 0;

        public Location()
        {
            InitializeComponent();
        }

        private void Location_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vOITUREDataSet.LOCATION' table. You can move, or remove it, as needed.
            this.lOCATIONTableAdapter.Fill(this.vOITUREDataSet.LOCATION);
            // TODO: This line of code loads data into the 'vOITUREDataSet.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.vOITUREDataSet.CLIENT);
            // TODO: This line of code loads data into the 'vOITUREDataSet.VOITURE' table. You can move, or remove it, as needed.
            this.vOITURETableAdapter.Fill(this.vOITUREDataSet.VOITURE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = locationController.GetLastIDLocation();
            txt_ID.Text = "LV-" + Convert.ToString(id + 1);
            txt_prix.Text = "";
            txt_matricule.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_prix.Text) || string.IsNullOrWhiteSpace(txt_matricule.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add a new car?", "Confirm Addition", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    LocationModel locationNew = new LocationModel(Convert.ToInt16(txt_matricule.SelectedValue), Convert.ToInt16(txt_client.SelectedValue), new DateTime(2025, 06, 01),new DateTime(2025, 06, 01), Convert.ToInt16(txt_prix.Text));
                    locationController.AddLocation(locationNew);
                    this.lOCATIONTableAdapter.Fill(this.vOITUREDataSet.LOCATION);

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
        private void Load_Data()
        {
            var currentRow = this.lOCATIONBindingSource.Current as DataRowView;
            selectedLocation = Convert.ToInt16(currentRow["ID_LOCATION"]);
            txt_ID.Text = "LV-" + currentRow["ID_LOCATION"].ToString();
            txt_matricule.Text = currentRow["MATRICULE"].ToString();
            txt_client.Text = currentRow["CIN"].ToString();
            txt_prix.Text = currentRow["PRIX"].ToString();
        }

        private void Debut_Click(object sender, EventArgs e)
        {
            this.lOCATIONBindingSource.MoveFirst();
            Load_Data();
        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            this.lOCATIONBindingSource.MoveNext();
            Load_Data();
        }

        private void Precedant_Click(object sender, EventArgs e)
        {
            this.lOCATIONBindingSource.MovePrevious();
            Load_Data();
        }

        private void Dernier_Click(object sender, EventArgs e)
        {
            this.lOCATIONBindingSource.MoveLast();
            Load_Data();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedLocation = Convert.ToInt16(row.Cells[0].Value);
                txt_matricule.SelectedValue = row.Cells[1].Value;
                txt_client.SelectedValue = row.Cells[2].Value;
                dateTimePicker_location.Text = row.Cells[3].Value.ToString();
                dateTimePicker_retour.Text = row.Cells[4].Value.ToString();
                txt_prix.Text = row.Cells[5].Value.ToString();
                txt_ID.Text = "LV-" + selectedLocation;
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (selectedLocation > 0)
            {

                LocationModel updatedLocation = new LocationModel
                {
                    Matricule = Convert.ToInt16(txt_matricule.SelectedValue.ToString()),
                    CIN = Convert.ToInt16(txt_client.SelectedValue.ToString()),
                    DATE_LOCATION = new DateTime(2025, 06, 01),
                    RETOUR_LOCATION = new DateTime(2025, 06, 01),
                    prix = Convert.ToInt16(txt_prix.Text)
                };
                int LocationToUpdate = selectedLocation;

                success = locationController.UpdateLocation(updatedLocation, LocationToUpdate);
            }
            if (success)
            {
                MessageBox.Show("Car updated successfully!");
                this.lOCATIONTableAdapter.Fill(this.vOITUREDataSet.LOCATION);
            }
            else
                MessageBox.Show("Update failed. Please check the details.");
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (selectedLocation > 0)
            {
                VoitureController controller = new VoitureController();
                bool deleted = locationController.DeleteLocation(selectedLocation);

                if (deleted)
                {
                    MessageBox.Show("Voiture deleted successfully.");
                    this.lOCATIONTableAdapter.Fill(this.vOITUREDataSet.LOCATION);
                }
                else
                {
                    MessageBox.Show("Failed to delete voiture. Maybe the MATRICULE doesn't exist.");
                }
            }
        }
    }
}
