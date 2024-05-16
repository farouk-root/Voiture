using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voiture.Models
{
    class VoitureModel
    {
        public int ID_AGENCE { get; set; }
        public string Couleur { get; set; }
        public string Modele { get; set; }
        public DateTime Annee { get; set; }
        public VoitureModel()
        {
        }
        public VoitureModel(int idAgence, string couleur, string modele, DateTime annee)
        {
            ID_AGENCE = idAgence;
            Couleur = couleur;
            Modele = modele;
            Annee = annee;
        }
    }
}
