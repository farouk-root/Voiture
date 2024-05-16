using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voiture.Models
{
    class ClientModel
    {
        public int ID_AGENCE  { get; set; }
        public string NOM { get; set; }
        public string PRENOM { get; set; }
        public DateTime DATE_DE_NAISSANCE { get; set; }
        public string TELEPHONE { get; set; }

        public ClientModel()
        {
        }

        public ClientModel(int ID_agence , string nom, string prenom, DateTime dateDeNaissance, string telephone)
        {
            ID_AGENCE = ID_agence;
            NOM = nom;
            PRENOM = prenom;
            DATE_DE_NAISSANCE = dateDeNaissance;
            TELEPHONE = telephone;
        }

    }
}
