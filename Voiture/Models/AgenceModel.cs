using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voiture.Models
{
    class AgenceModel
    {
        public string NOM_AGENCE { get; set; }
        public string ADRESSE { get; set; }
        public string NUM_TEL { get; set; }
        public string EMAIL { get; set; }
        public AgenceModel()
        {
        }
        public AgenceModel(string nomAgence, string adresse, string numTel, string email)
        {
            NOM_AGENCE = nomAgence;
            ADRESSE = adresse;
            NUM_TEL = numTel;
            EMAIL = email;
        }
    }
}
