using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites
{
    public class Enseignant
    {
        public int num_Ens{get; set;}
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string ville { get; set; }
        public string adresse { get; set; }
        public string telephone { get; set; }
        public string CIN { get; set; }
        public string login { get; set; }
        public bool genre { get; set; }
        public Image image { get; set; }

        public Enseignant(int num_Ens, string nom, string prenom, string email, string ville, string adresse, string telephone, string cIN, string login, bool genre, Image image)
        {
            this.num_Ens = num_Ens;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.ville = ville;
            this.adresse = adresse;
            this.telephone = telephone;
            this.CIN = cIN;
            this.login = login;
            this.genre = genre;
            this.image = image;
        }

        public Enseignant()
        {
        }

        public string toString()
        {
            string s = "Num: " + num_Ens + ", Nom: " + nom + " prenom: " + prenom + " email: " + email + " tele: " + telephone+" Genre: "+genre;
            return s;
        }
    }
}
