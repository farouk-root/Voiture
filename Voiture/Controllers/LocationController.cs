using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Voiture.Models;
using System.Data.OleDb;

namespace Voiture.Controllers
{
    class LocationController
    {
        public void AddLocation(LocationModel location)
        {
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "INSERT INTO LOCATION (MATRICULE, CIN, DATE_LOCATION, RETOUR_LOCATION , PRIX) VALUES (@MATRICULE, @CIN, @DATE_LOCATION, @RETOUR_LOCATION ,@PRIX )";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MATRICULE", location.Matricule);
                    cmd.Parameters.AddWithValue("@CIN", location.CIN);
                    cmd.Parameters.AddWithValue("@DATE_LOCATION", location.DATE_LOCATION);
                    cmd.Parameters.AddWithValue("@RETOUR_LOCATION", location.RETOUR_LOCATION);
                    cmd.Parameters.AddWithValue("@PRIX", location.prix);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int GetLastIDLocation()
        {
            int latestId = 0;
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "SELECT MAX(ID_LOCATION) AS LastID FROM LOCATION";

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
        public bool UpdateLocation(LocationModel location, int id)
        {
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "UPDATE LOCATION SET  CIN = @CIN, DATE_LOCATION = @DATE_LOCATION, RETOUR_LOCATION = @RETOUR_LOCATION, PRIX = @PRIX WHERE ID_LOCATION = @ID_LOCATION";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    
                    cmd.Parameters.AddWithValue("@CIN", location.CIN);
                    cmd.Parameters.AddWithValue("@DATE_LOCATION", location.DATE_LOCATION);
                    cmd.Parameters.AddWithValue("@RETOUR_LOCATION", location.RETOUR_LOCATION);
                    cmd.Parameters.AddWithValue("@PRIX", location.prix);
                    cmd.Parameters.AddWithValue("@ID_LOCATION", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public bool DeleteLocation(int idLoc)
        {
            using (OleDbConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var query = "DELETE FROM LOCATION WHERE ID_LOCATION = @ID_LOCATION";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_LOCATION", idLoc);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        
    }
}
