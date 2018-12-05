using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites
{
    public class Matiere
    {
        public int numM { get; set; }
        public string nomM { get; set; }
        public int nbrheures { get; set; }
        public int? num_Ens { get; set; }
        public Image image { get; set; }

        public Matiere(int numM, string nomM, int nbrheures, int? num_Ens, Image img)
        {
            this.numM = numM;
            this.nomM = nomM;
            this.nbrheures = nbrheures;
            this.num_Ens = num_Ens;
            image = img;
        }

        public Matiere()
        {
        }
    }
}
