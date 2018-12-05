using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites
{
    public class Etudiant
    {
        public int num_Etud { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string ville { get; set; }
        public string adresse { get; set; }
        public string telephone { get; set; }
        public string date_naissance { get; set; }
        public string CIN { get; set; }
        public int CNE { get; set; }
        public Image image { get; set; }
        public int numC { get; set; }
        public bool genre { get; set; }

        public Etudiant(int num_Etud, string nom, string prenom, string ville, string adresse, string telephone, string date_naissance, string cIN, int cNE, Image image, int numC, bool genre)
        {
            this.num_Etud = num_Etud;
            this.nom = nom;
            this.prenom = prenom;
            this.ville = ville;
            this.adresse = adresse;
            this.telephone = telephone;
            this.date_naissance = date_naissance;
            CIN = cIN;
            CNE = cNE;
            this.image = image;
            this.numC = numC;
            this.genre = genre;
        }

        public Etudiant()
        {
        }

    }
}
