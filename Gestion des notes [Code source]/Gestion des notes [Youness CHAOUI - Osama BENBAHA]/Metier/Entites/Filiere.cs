using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites
{
    public class Filiere
    {
        public int numF { get; set; }
        public string nomF { get; set; }
        public int nbrMatiere { get; set; }
        public int numC { get; set; }

        public Filiere(int numF, string nomF, int nbrMatiere, int numC)
        {
            this.numF = numF;
            this.nomF = nomF;
            this.nbrMatiere = nbrMatiere;
            this.numC = numC;
        }

        public Filiere()
        {
        }
    }
}
