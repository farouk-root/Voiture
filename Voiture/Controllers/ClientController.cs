using System;
using System.Collections.Generic;
using System.Data.OleDb;
using Voiture.Models;

namespace Voiture.Controllers
{
    class ClientController
    {
        public void AddClient(ClientModel client)
        {
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "INSERT INTO CLIENT (ID_AGENCE, NOM, PRENOM, DATE_DE_NAISSANCE, TELEPHONE) VALUES (@ID_AGENCE, @NOM, @PRENOM, @DATE_DE_NAISSANCE, @TELEPHONE)";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_AGENCE", client.ID_AGENCE);
                    cmd.Parameters.AddWithValue("@NOM", client.NOM);
                    cmd.Parameters.AddWithValue("@PRENOM", client.PRENOM);
                    cmd.Parameters.AddWithValue("@DATE_DE_NAISSANCE", client.DATE_DE_NAISSANCE);
                    cmd.Parameters.AddWithValue("@TELEPHONE", client.TELEPHONE);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ClientModel> GetAllClients()
        {
            List<ClientModel> clients = new List<ClientModel>();
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "SELECT ID_AGENCE, NOM, PRENOM, DATE_DE_NAISSANCE, TELEPHONE FROM CLIENT";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clients.Add(new ClientModel
                        {
                            ID_AGENCE = reader.GetInt32(0),
                            NOM = reader.GetString(1),
                            PRENOM = reader.GetString(2),
                            DATE_DE_NAISSANCE = reader.GetDateTime(3),
                            TELEPHONE = reader.GetString(4)
                        });
                    }
                }
            }
            return clients;
        }

        public int GetLatestClientId()
        {
            int latestId = 0;
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "SELECT MAX(CIN) AS LastID FROM CLIENT";

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

        public bool UpdateClient(ClientModel client, int id)
        {
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "UPDATE CLIENT SET ID_AGENCE = @ID_AGENCE, NOM = @NOM, PRENOM = @PRENOM, DATE_DE_NAISSANCE = @DATE_DE_NAISSANCE, TELEPHONE = @TELEPHONE WHERE CIN = @ID_CLIENT";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_AGENCE", client.ID_AGENCE);
                    cmd.Parameters.AddWithValue("@NOM", client.NOM);
                    cmd.Parameters.AddWithValue("@PRENOM", client.PRENOM);
                    cmd.Parameters.AddWithValue("@DATE_DE_NAISSANCE", client.DATE_DE_NAISSANCE);
                    cmd.Parameters.AddWithValue("@TELEPHONE", client.TELEPHONE);
                    cmd.Parameters.AddWithValue("@ID_CLIENT", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public bool DeleteClient(int idClient)
        {
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "DELETE FROM CLIENT WHERE CIN = @ID_CLIENT";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_CLIENT", idClient);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
    }
}
