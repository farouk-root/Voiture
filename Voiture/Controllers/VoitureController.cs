using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Voiture.Models;
using System.Data.OleDb;

namespace Voiture.Controllers
{
    class VoitureController
    {
        public void AddVoiture(VoitureModel voiture)
        {
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "INSERT INTO VOITURE (ID_AGENCE, COULEUR, MODELE, ANNEE) VALUES (@ID_AGENCE, @COULEUR, @MODELE, @ANNEE)";
                
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_AGENCE", voiture.ID_AGENCE);
                    cmd.Parameters.AddWithValue("@COULEUR", voiture.Couleur);
                    cmd.Parameters.AddWithValue("@MODELE", voiture.Modele);
                    cmd.Parameters.AddWithValue("@ANNEE", voiture.Annee);
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Example of a method to retrieve all Voitures
        public List<VoitureModel> GetAllVoitures()
        {
            List<VoitureModel> voitures = new List<VoitureModel>();
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "SELECT ID_AGENCE, Couleur, Modele, Annee FROM VOITURE";
                
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        voitures.Add(new VoitureModel
                        {
                            ID_AGENCE = reader.GetInt32(0),
                            Couleur = reader.GetString(1),
                            Modele = reader.GetString(2),
                            Annee = reader.GetDateTime(3)
                        });
                    }
                }
            }
            return voitures;
        }

        public int GetLatestVoitureId()
        {
            int latestId = 0;
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "SELECT MAX(MATRICULE) AS LastID FROM VOITURE"; 

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read() && !reader.IsDBNull(0))
                    {
                        latestId = reader.GetInt32(0); 
                    }
                }
            }
            return latestId;
        }

        public bool UpdateVoiture(VoitureModel voiture, int matricule)
        {
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "UPDATE VOITURE SET ID_AGENCE = @ID_AGENCE, COULEUR = @COULEUR, MODELE = @MODELE, ANNEE = @ANNEE WHERE MATRICULE = @MATRICULE";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_AGENCE", voiture.ID_AGENCE);
                    cmd.Parameters.AddWithValue("@COULEUR", voiture.Couleur);
                    cmd.Parameters.AddWithValue("@MODELE", voiture.Modele);
                    cmd.Parameters.AddWithValue("@ANNEE", voiture.Annee);
                    cmd.Parameters.AddWithValue("@MATRICULE", matricule);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0; 
                }
            }
        }

        public bool DeleteVoiture(int matricule)
        {
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "DELETE FROM VOITURE WHERE MATRICULE = @MATRICULE";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MATRICULE", matricule);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0; 
                }
            }
        }

    }
}
