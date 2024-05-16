using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voiture.Models
{
    class LocationModel
    {
        public int Matricule { get; set; }
        public int CIN { get; set; }
        public int prix { get; set; }
        public DateTime DATE_LOCATION { get; set; }
        public DateTime RETOUR_LOCATION { get; set; }
        public LocationModel()
        {
        }
        public LocationModel(int matricule, int cin_client, DateTime date_location, DateTime retour , int prix_location)
        {
            Matricule = matricule;
            CIN = cin_client;
            prix = prix_location;
            DATE_LOCATION = date_location;
            RETOUR_LOCATION = retour;
        }

    }
}
