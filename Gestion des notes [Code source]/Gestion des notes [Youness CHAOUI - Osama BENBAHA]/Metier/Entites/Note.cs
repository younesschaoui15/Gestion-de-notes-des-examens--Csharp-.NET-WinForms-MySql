using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites
{
    public class note
    {
        public int numM { get; set; }
        public double? mark { get; set; }
        public int num_Etud { get; set; }

        public note(int numM, double? mark, int num_Etud)
        {
            this.numM = numM;
            this.mark = mark;
            this.num_Etud = num_Etud;
        }

        public note()
        {
        }
    }
}
