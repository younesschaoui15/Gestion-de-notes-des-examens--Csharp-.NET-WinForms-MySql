using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites
{
    public class Classe
    {
        public int numC { get; set; }
        public string nomC { get; set; }
        public int nbrEtudianrs { get; set; }
        public string numSalle { get; set; }
        public int numF{ get; set; }

        public Classe(int numC, string nomC, int nbrEtudianrs, string numSalle, int numF)
        {
            this.numC = numC;
            this.nomC = nomC;
            this.nbrEtudianrs = nbrEtudianrs;
            this.numSalle = numSalle;
            this.numF = numF;
        }

        public Classe()
        {
        
        }
    }
}
