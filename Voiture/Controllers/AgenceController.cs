using System;
using System.Collections.Generic;
using System.Data.OleDb;
using Voiture.Models;

namespace Voiture.Controllers
{
    class AgenceController
    {
        public void AddAgence(AgenceModel agence)
        {
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "INSERT INTO AGENCE (NOM_AGENCE, ADRESSE, NUM_TEL, EMAIL) VALUES (@NOM_AGENCE, @ADRESSE, @NUM_TEL, @EMAIL)";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NOM_AGENCE", agence.NOM_AGENCE);
                    cmd.Parameters.AddWithValue("@ADRESSE", agence.ADRESSE);
                    cmd.Parameters.AddWithValue("@NUM_TEL", agence.NUM_TEL);
                    cmd.Parameters.AddWithValue("@EMAIL", agence.EMAIL);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to retrieve all agencies
        public List<AgenceModel> GetAllAgences()
        {
            List<AgenceModel> agences = new List<AgenceModel>();
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "SELECT NOM_AGENCE, ADRESSE, NUM_TEL, EMAIL FROM AGENCE";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        agences.Add(new AgenceModel
                        {
                            NOM_AGENCE = reader.GetString(0),
                            ADRESSE = reader.GetString(1),
                            NUM_TEL = reader.GetString(2),
                            EMAIL = reader.GetString(3)
                        });
                    }
                }
            }
            return agences;
        }

        // Method to get the latest agency ID
        public int GetLatestAgenceId()
        {
            int latestId = 0;
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "SELECT MAX(ID_AGENCE) AS LastID FROM AGENCE";

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

        // Method to update an existing agency
        public bool UpdateAgence(AgenceModel agence, int id)
        {
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "UPDATE AGENCE SET NOM_AGENCE = @NOM_AGENCE, ADRESSE = @ADRESSE, NUM_TEL = @NUM_TEL, EMAIL = @EMAIL WHERE ID_AGENCE = @ID_AGENCE";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NOM_AGENCE", agence.NOM_AGENCE);
                    cmd.Parameters.AddWithValue("@ADRESSE", agence.ADRESSE);
                    cmd.Parameters.AddWithValue("@NUM_TEL", agence.NUM_TEL);
                    cmd.Parameters.AddWithValue("@EMAIL", agence.EMAIL);
                    cmd.Parameters.AddWithValue("@ID_AGENCE", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0; 
                }
            }
        }


        public bool DeleteAgence(int idAgence)
        {
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "DELETE FROM AGENCE WHERE ID_AGENCE = @ID_AGENCE";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_AGENCE", idAgence);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

    }
}
