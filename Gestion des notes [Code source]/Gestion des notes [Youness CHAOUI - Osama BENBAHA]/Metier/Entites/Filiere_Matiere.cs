using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites
{
    public class Filiere_Matiere
    {
        public int idFM { get; set; }
        public int numM { get; set; }
        public int numF { get; set; }

        public Filiere_Matiere(int idFM, int numM, int numF)
        {
            this.idFM = idFM;
            this.numM = numM;
            this.numF = numF;
        }

        public Filiere_Matiere()
        {
        }
    }
}
